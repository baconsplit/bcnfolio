using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Bcnfolio;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using Bcnfolio.Database;
using Bcnfolio.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddScoped<ISummitTaskService, InMemoryTaskService>();
// builder.Services.AddScoped<ISummitTaskService, DbSummitTaskService>();
// builder.Services.AddDbContextFactory<SummitTaskContext>(opts =>
// opts.UseSqlite("Data Source=todos.sqlite3"));

//builder.Services.AddSynchronizingDataFactory();
await builder.Build().RunAsync();
