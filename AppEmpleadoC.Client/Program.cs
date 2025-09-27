using AppEmpleadoC.Client;
using AppEmpleadoC.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<EmpleadoService>();
builder.Services.AddScoped<SucursalService>();
builder.Services.AddScoped<DirectorService>();
builder.Services.AddScoped<ClienteService>();
await builder.Build().RunAsync();
