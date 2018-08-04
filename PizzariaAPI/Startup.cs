using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace PizzariaAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
               {
                   option.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = false,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,

                       ValidIssuer = "Teste.Securiry.Bearer",
                       ValidAudience = "Teste.Securiry.Bearer",
                       IssuerSigningKey = ProviderJWT.JwtSecurityKey.Create("Secret_Key-12345678")
                   };

                   option.Events = new JwtBearerEvents
                   {
                       OnAuthenticationFailed = context =>
                       {
                           Console.WriteLine("OnAuthenticationFailed: " + context.Exception.Message);
                           return Task.CompletedTask;
                       },
                       OnTokenValidated = context =>
                       {
                           Console.WriteLine("OnTokenValidated: " + context.SecurityToken);
                           return Task.CompletedTask;
                       }
                   };
               });

            services.AddAuthorization(options =>
           {
               options.AddPolicy("UsuarioAPI",
                   policy => policy.RequireClaim("UsuarioAPINumero"));
           });

                      
            services.AddMvc().AddJsonOptions(opcoes =>
            {
                opcoes.SerializerSettings.NullValueHandling =
                    Newtonsoft.Json.NullValueHandling.Ignore;
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
                builder.WithOrigins("http://*", "*")
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
