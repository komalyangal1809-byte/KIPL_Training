using MachineWebApp.Components;
using MachineWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<MachinesService>((sp, client) =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    client.BaseAddress = new Uri(configuration["BaseUrl"]!);
});

builder.Services.AddHttpClient("ApiClient", (sp, client) =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    client.BaseAddress = new Uri(configuration["BaseUrl"]!);
});

var app = builder.Build();

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