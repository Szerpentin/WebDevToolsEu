using Blazor.Analytics;
using BlazorDownloadFile;
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

            if (builder.HostEnvironment.IsDevelopment())
            {
                builder.Services.AddScoped(x => new HttpClient() { BaseAddress = new Uri("https://localhost:5002") });
            }
            else
            {
                builder.Services.AddScoped(x => new HttpClient() { BaseAddress = new Uri("https://api.webdevtools.eu") });
            }


            builder.RootComponents.Add<App>("app");
            builder.Services.AddBlazorDownloadFile();
            builder.Services.AddGoogleAnalytics("G-HEJT06HQG2");
            builder.Services.AddScoped<ClipboardService>();
            await builder.Build().RunAsync();
        }
    }
}
