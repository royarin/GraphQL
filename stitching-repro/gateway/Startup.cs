using System;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo.Gateway
{
    public class Startup
    {
        public const string Accounts = "accounts";
        public const string Inventory = "inventory";
        public const string Products = "products";
        public const string Reviews = "reviews";

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient(Products, c => c.BaseAddress = new Uri(this.Configuration["ProductsAPI"]));
            services.AddHttpClient(Inventory, c => c.BaseAddress = new Uri(this.Configuration["InventoryAPI"]));
            services.AddHttpClient(Accounts, c => c.BaseAddress = new Uri(this.Configuration["AccountsAPI"]));
            services.AddHttpClient(Reviews, c => c.BaseAddress = new Uri(this.Configuration["ReviewsAPI"]));

            services
                .AddGraphQLServer()
                .AddRemoteSchema(Accounts)
                .AddRemoteSchema(Inventory)
                .AddRemoteSchema(Products)
                .AddRemoteSchema(Reviews)
                .AddTypeExtensionsFromFile("./Stitching.graphql");
            ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
