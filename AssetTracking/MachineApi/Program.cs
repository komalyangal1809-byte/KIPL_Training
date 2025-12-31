using MachineApi.Data;
using MachineApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<MachineService>();
builder.Services.AddScoped<IDatareader,TextFileDataReader>();



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseCors("AllowBlazor");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "");
app.Run();
