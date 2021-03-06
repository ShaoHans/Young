﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Young.Application;
using Young.Application.Impl;
using Young.Domain.Models;
using Young.Domain.Repositories;
using Young.Infrastructure;
using Young.Infrastructure.Repositories;

namespace Young.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IUnitOfWork, EfCoreUnitOfWork>();
            services.AddTransient(typeof(IRepository<>), typeof(EfCoreRepositoryBase<>));
            services.AddMediatR(typeof(Young.Command.Commands.Book.AddBookCommandHandler).GetTypeInfo().Assembly);
            services.AddTransient(typeof(IBookQuery), sp => { return new BookQuery(Configuration.GetConnectionString("Default")); });
            // Add Autofac
            //var containerBuilder = new ContainerBuilder();
            //containerBuilder.Populate(services);
            //containerBuilder.RegisterGeneric(typeof(EfCoreRepositoryBase<>)).As(typeof(IRepository<>)).InstancePerDependency();
            //var container = containerBuilder.Build();
            //return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
