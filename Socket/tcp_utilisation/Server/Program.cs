using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    private static readonly object ConsoleLock = new();

    private static readonly StringBuilder CurrentInput = new();

    private const string Prompt = "You: ";

    static async Task Main(string[] args)
    {
        using var serverSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

        var endpoint = new IPEndPoint(
            IPAddress.Loopback,
            5000);

        serverSocket.Bind(endpoint);
        serverSocket.Listen(10);

        Console.WriteLine("TCP Chat Server");
        Console.WriteLine("Listening on 127.0.0.1:5000...");
        Console.WriteLine();

        using Socket clientSocket = await serverSocket.AcceptAsync();

        Console.WriteLine($"Client connected: {clientSocket.RemoteEndPoint}");

        Console.WriteLine();

        RedrawInput();

        Task receiveTask = ReceiveMessagesAsync(clientSocket, "Client");

        Task sendTask = SendMessagesAsync(clientSocket);

        await Task.WhenAny(receiveTask, sendTask);

        Console.WriteLine();
        Console.WriteLine("Connection closed.");
    }

    static async Task ReceiveMessagesAsync(
        Socket socket,
        string senderName)
    {
        byte[] buffer = new byte[1024];

        // TCP doesn't preserve message boundaries.
        // We keep incomplete data here until we find '\n'.
        StringBuilder pendingData = new();

        try
        {
            while (true)
            {
                int received = await socket.ReceiveAsync(buffer);

                if (received == 0)
                {
                    PrintSystemMessage($"{senderName} disconnected.");

                    break;
                }

                string text = Encoding.UTF8.GetString(buffer, 0, received);

                pendingData.Append(text);

                while (true)
                {
                    string current = pendingData.ToString();

                    int newlineIndex = current.IndexOf('\n');

                    if (newlineIndex == -1)
                        break;

                    string message = current[..newlineIndex].TrimEnd('\r');

                    pendingData.Remove(0, newlineIndex + 1);

                    PrintIncomingMessage(senderName, message);
                }
            }
        }
        catch (SocketException ex)
        {
            PrintSystemMessage($"Socket error: {ex.Message}");
        }
        catch (ObjectDisposedException)
        {
            // Socket was closed.
        }
    }

    static async Task SendMessagesAsync(Socket socket)
    {
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
            {
                string message;

                lock (ConsoleLock)
                {
                    message = CurrentInput.ToString();
                    CurrentInput.Clear();
                    ClearCurrentLine();
                    Console.WriteLine($"You: {message}");
                    RedrawInputUnsafe();
                }

                if (string.IsNullOrWhiteSpace(message)) continue;

                // '\n' marks the end of one chat message.
                byte[] data = Encoding.UTF8.GetBytes(message + "\n");

                await socket.SendAsync(data);
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                lock (ConsoleLock)
                {
                    if (CurrentInput.Length > 0)
                    {
                        CurrentInput.Remove(CurrentInput.Length - 1, 1);
                    }

                    RedrawInputUnsafe();
                }
            }
            else if (!char.IsControl(key.KeyChar))
            {
                lock (ConsoleLock)
                {
                    CurrentInput.Append(key.KeyChar);

                    RedrawInputUnsafe();
                }
            }
        }
    }

    static void PrintIncomingMessage(string sender, string message)
    {
        lock (ConsoleLock)
        {
            ClearCurrentLine();

            Console.WriteLine($"{sender}: {message}");

            RedrawInputUnsafe();
        }
    }

    static void PrintSystemMessage(string message)
    {
        lock (ConsoleLock)
        {
            ClearCurrentLine();

            Console.WriteLine($"[System] {message}");

            RedrawInputUnsafe();
        }
    }

    static void RedrawInput()
    {
        lock (ConsoleLock)
        {
            RedrawInputUnsafe();
        }
    }

    static void RedrawInputUnsafe()
    {
        ClearCurrentLine();

        Console.Write(Prompt + CurrentInput);

        Console.SetCursorPosition(Prompt.Length + CurrentInput.Length, Console.CursorTop);
    }

    static void ClearCurrentLine()
    {
        int line = Console.CursorTop;

        Console.SetCursorPosition(0, line);

        Console.Write(new string(' ', Math.Max(0, Console.WindowWidth - 1)));

        Console.SetCursorPosition(0, line);
    }
}