
using FlowNest.Data;
using FlowNest.Endpoint.Helpers;
using FlowNest.Logic.Helpres;
using FlowNest.Logic.Logic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

namespace FlowNest
{
    public class Program
    {
        public static void Main(string[] args)
        {

           

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient(typeof(Repository<>));
            builder.Services.AddTransient<DtoProvider>();
            builder.Services.AddTransient<MovieLogic>();
            builder.Services.AddTransient<RatingLogic>();
            builder.Services.AddTransient<ActorLogic>();

            builder.Services.AddIdentity<AppUser, IdentityRole>(
                 option =>
                 {
                     option.Password.RequireDigit = false;
                     option.Password.RequiredLength = 6;
                     option.Password.RequireNonAlphanumeric = false;
                     option.Password.RequireUppercase = false;
                     option.Password.RequireLowercase = false;
                 }
)
             .AddEntityFrameworkStores<FlowNestDBContext>()
             .AddDefaultTokenProviders();


            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = "flownest.com",
                    ValidIssuer = "flownest.com",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!Almafa1234!!!"))
                };
            });
            //to-do frontend
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAngularApp", policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            builder.Services.AddControllers(opt =>
            {

                opt.Filters.Add<ExceptionFilter>();
                opt.Filters.Add<ValidationFilterAttribute>();

            });
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

            });




            builder.Services.AddDbContext<FlowNestDBContext>(options =>
            {
                //ez a connection kell az adatbázis szerverhez
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FlowNestDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
                options.UseLazyLoadingProxies();
            });

            // Add services to the container.
            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

           

           
            
            
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "FlowNest API", Version = "v1" });
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                            new string[]{}
                    }
                });
            });

            var app = builder.Build();

            app.UseCors("AllowAngularApp");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
