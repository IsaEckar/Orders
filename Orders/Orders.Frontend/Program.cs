using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Orders.Frontend;
using Orders.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//unir backend con frontend con addscoped
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7031/") });
builder.Services.AddScoped<IRepository, Repository>();

await builder.Build().RunAsync();