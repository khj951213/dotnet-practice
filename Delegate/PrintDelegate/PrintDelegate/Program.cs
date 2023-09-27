PrintDelegateFunc PrintConsole = (string text) =>
{
    Console.WriteLine(text);
};

PrintDelegateFunc PrintFile = (string text) =>
{
    File.AppendAllText("../../../logs.txt", text);
};

static void ConnectToDatabase(PrintDelegateFunc log)
{
    log("Inserting a new record into a database.");
    log("The record got inserted into the database.");
}

ConnectToDatabase(PrintFile);

delegate void PrintDelegateFunc(string text);