using mini_bot_api;

var builder = WebApplication.CreateBuilder(args);

string MyAllowMyOriginPolicy = "AllowMyOriginPolicy";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
    c =>
    {
        c.AddPolicy(
            MyAllowMyOriginPolicy,
            options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );
    }
    );

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowMyOriginPolicy);

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
