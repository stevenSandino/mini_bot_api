using Microsoft.AspNetCore.Builder;
using mini_bot_api.ApiService.Model;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapGet("/responce/{question}", (string question) =>
{
    var responce = new ResponceRecord(question, "");
    return responce;
});
app.MapGet("/responce/", () =>
{
    var responce = new ResponceRecord("", "");
    return responce;
});

app.MapDefaultEndpoints();

app.Run();

public record ResponceRecord(string? question, string answer)
{
    MiniBot miniBot = new MiniBot();
    public string answer => miniBot.getAnswer(question);
}
