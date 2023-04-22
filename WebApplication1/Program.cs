var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var result = "Hello World!";

app.MapGet("/", () => result);

app.Run();