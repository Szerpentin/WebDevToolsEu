using Blazor.Analytics;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebDevTools.Frontend.BL;

namespace WebDevTools.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddGoogleAnalytics("G-HEJT06HQG2");
            builder.Services.AddScoped<ClipboardService>();
            await builder.Build().RunAsync();
        }
    }
}
