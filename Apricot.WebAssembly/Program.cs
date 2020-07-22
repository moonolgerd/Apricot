using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Apricot.Services;
using System.Net.Http;
using Blazored.Toast;
using Blazor.Notifications;

namespace Apricot
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IApricotService, ApricotService>();
            builder.Services.AddBlazoredToast();
            builder.Services.AddNotifications();

            await builder.Build().RunAsync();
        }
    }
}
