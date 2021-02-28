using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartSchoolAPI.Data;

namespace SmartSchoolAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SmartContext>(context => 
                context.UseMySql(Configuration.GetConnectionString("MySqlConnection")));

            services.AddControllers().AddNewtonsoftJson(option => 
                option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IRepository, Repository>();

            services.AddVersionedApiExplorer(options => 
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            })
                .AddApiVersioning(options => 
                {
                    options.DefaultApiVersion = new ApiVersion(1, 0);
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.ReportApiVersions = true;
                });

            var ApiProviderDescription = services.BuildServiceProvider()
                .GetService<IApiVersionDescriptionProvider>();

            services.AddSwaggerGen(options => 
            {
                foreach (var description in ApiProviderDescription.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(description.GroupName, new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title =  "Smart School API",
                        Version = description.ApiVersion.ToString(),
                        TermsOfService = new Uri("https://www.termsfeed.com/live/bebc8357-1a71-484f-acfc-5b2ebe1536bf"),
                        Description = "Smart School Web API desenvolvida em AspNet Core",
                        License = new Microsoft.OpenApi.Models.OpenApiLicense
                        {
                            Name = "MIT Licence",
                            Url = new Uri("https://opensource.org/licenses/MIT")
                        },
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Pedro Henrique Padilha Portella da Cruz",
                            Email = "pedro.kadjin.sg@gmail.com",
                            Url = new Uri("https://github.com/PedroPadilhaPortella")
                        }
                    });
                }

                var xmlCommentFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentPath = Path.Combine(AppContext.BaseDirectory, xmlCommentFile);
                options.IncludeXmlComments(xmlCommentPath);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider api)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger().UseSwaggerUI(options => {
                foreach (var description in api.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", 
                        description.GroupName.ToUpperInvariant());
                }
                options.RoutePrefix = "";
            });

            // app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers() );
        }
    }
}
