using DemoVS;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilog();

// Configuração da App
var app = builder.Build();

app.UseLogTempo();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1000);
    return "Teste 2";
});

app.Run();
