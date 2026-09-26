using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Server is running");

app.MapGet("/blocking", () =>
{
    int threadId = Environment.CurrentManagedThreadId;
    string start = DateTime.Now.ToString("HH:mm:ss.fff");

    Console.WriteLine(
        $"START BLOCKING | {start} | Thread {threadId}");

    Thread.Sleep(5000);

    string end = DateTime.Now.ToString("HH:mm:ss.fff");

    Console.WriteLine(
        $"END   BLOCKING | {end} | Thread {Environment.CurrentManagedThreadId}");

    return "Blocking request finished";
});

app.MapGet("/async", async () =>
{
    int threadId = Environment.CurrentManagedThreadId;
    string start = DateTime.Now.ToString("HH:mm:ss.fff");

    Console.WriteLine(
        $"START ASYNC    | {start} | Thread {threadId}");

    await Task.Delay(5000);

    string end = DateTime.Now.ToString("HH:mm:ss.fff");

    Console.WriteLine(
        $"END   ASYNC    | {end} | Thread {Environment.CurrentManagedThreadId}");

    return "Async request finished";
});


app.Run();

record GeneralResponse()
{
    public bool IsSucess { get; init; }
    public string Response { get; init; } = null!;
}