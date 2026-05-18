using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ModelContextProtocol;
using csharp_mcp_sample;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<NoteRepository>();
builder.Services.AddSingleton<NoteTools>();

builder.Services.AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

var app = builder.Build();
await app.RunAsync();
