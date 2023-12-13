using Metrices_psql.datalayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Prometheus;

namespace Metrices_psql
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







            // Add CORS policy if needed
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });











            services.AddScoped<IEmployesRepository, EmployesRepository>();
            services.AddScoped<IPrometheusQueryServices, PrometheusQueryService>();
            services.AddHttpClient<PrometheusQueryService>();





            // Register database context
            services.AddDbContext<ApplicationDbContext>(options =>
            {





                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                       .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));





            });











            // Configure JSON serialization
            services.AddControllers()
                    .AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    });



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger", Version = "v1" });
            });





            //services.AddMetrics();



            services.AddControllers();
        }



        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();



                // Enable Swagger for API documentation (optional)
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }



            // Enable CORS (optional)
            //app.UseCors("AllowOrigin");



            app.UseHttpsRedirection();



            app.UseRouting();
            app.UseCors("AllowOrigin");
            app.UseAuthorization();



            app.UseMetricServer();
            app.UseHttpMetrics();
            // app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
