using MachineWebApp.Components;
using MachineWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register HttpClient + MachinesService
builder.Services.AddScoped<MachinesService>(sp =>
{
    var http = new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7052/")
    };
    return new MachinesService(http);
});


var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
