var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(int.Parse(port));
});

var app = builder.Build();

// Ruta principal
app.MapGet("/", () => "Hola desde mi API en Render!");

// Ruta de Health Check (Render la usa para ver si tu app está viva)
app.MapGet("/healthz", () => "OK");
//ayuda
app.Run();