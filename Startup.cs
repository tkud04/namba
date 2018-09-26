using System;
using lamba.Interfaces;
using lamba.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.DependencyInjection;

namespace lamba
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvcCore()
                .AddCors()
                .AddJsonFormatters();
				
			services.AddSingleton<IHelper, Helper>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app
                .UseDefaultFiles()
                .UseStaticFiles()
                .UseCors(builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                )
                .UseMvcWithDefaultRoute();

            if (env.IsProduction())
            {
                Console.WriteLine("https");
                var options = new RewriteOptions()
                    .AddRedirectToHttpsPermanent();

                app.UseRewriter(options);
            }
        }
    }
}