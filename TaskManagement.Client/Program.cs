using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using TaskManagement.Client;
using TaskManagement.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5183/") });
builder.Services.AddMudServices();
builder.Services.AddScoped<TaskManagementService>();

await builder.Build().RunAsync();
