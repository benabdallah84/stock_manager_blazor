using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;
using Syncfusion.Blazor;
using comuneProject.Client.Pages.services;
using comuneProject.Shared.Models;

namespace comuneProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTk4MjkzQDMxMzkyZTM0MmUzMGxuaUhUTUhDMTQwazUyNFhRNEhrMUlzTU1HZlBkTU9CdjVtMEJtU3RQb2M9;NTk4Mjk0QDMxMzkyZTM0MmUzMEpySGFXamV4L25TYTJvbkZYeUJ2T3JXNTZiWWlvT0lSYmM1L0JxTHFZMHM9;NTk4Mjk1QDMxMzkyZTM0MmUzMGhEbVhOUU1RQ0VEQXJBNEtlSHpNL21naUZidkVjWExaUlVVNUMwM2RXSUU9;NTk4Mjk2QDMxMzkyZTM0MmUzMGJPWE1nSmIwaXVsbkcvWjg4M0VuMUhZN0QvalgxeldPUCtzeVNaOEluRTA9;NTk4Mjk3QDMxMzkyZTM0MmUzMGJaZ0FDNHBmUFloZHR6Yzk3c3Z6YmZZUzd4UUROMjAxWmlrQmhUYVdmdzg9;NTk4Mjk4QDMxMzkyZTM0MmUzMG5pVlZocEx5RGJ4d0tMVy96MUw0d2tmc1d3RHFIOXR0WHp6Zmt5NWRpeXM9;NTk4Mjk5QDMxMzkyZTM0MmUzMGNSM0c5T3ZNekpNZmpHVk1Bd2UrbHovM3p0T1NsYTkza3dTUnlyUDkxSlU9;NTk4MzAwQDMxMzkyZTM0MmUzMFpTUlJPbHJzUkh1aDdvNFlHZm1wRHZtZXBWYUtEWXQvMDF4Mi9Zc0UrZm89;NTk4MzAxQDMxMzkyZTM0MmUzMEs4MHJTMzBjUHd5OUR2QU5TSnFnK2thS1NrTi8vMm45TENBNW1rK3lEczg9;NTk4MzAyQDMxMzkyZTM0MmUzMEphRHM2T0tmM0srU2V4OUU2Z3haOEUyd2pLZFBCeEUxK1hNVnBwbWI1Qnc9;NTk4MzAzQDMxMzkyZTM0MmUzMEROYjRjZ0U2MjdraFVWcGp4UjJyMDcxVVpJT3JlVG4wN2JQWFE2MkQzYm89");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHxServices().AddHxMessenger();

            /*builder.Services.AddHttpClient<IRepositoryFrontEnd<product>, ProductService>(client => 
            {
              client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });*/
            builder.Services.AddSingleton<IRepositoryFrontEnd<product>, ProductService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
