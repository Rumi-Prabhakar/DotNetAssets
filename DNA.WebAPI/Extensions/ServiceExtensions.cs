using System;
using System.Runtime.CompilerServices;
using System.Text;
using DNA.Logger;
using DNA.Repository;
using DNA.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace DNA.WebAPI
{
	public static class ServiceExtensions
	{
		public static void ConfigureCors(this IServiceCollection services) =>
		services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", 
			 builder =>
			 builder.AllowAnyOrigin()
			 .AllowAnyMethod());
		});

		public static void ConfigureIISIntegration(this IServiceCollection services) =>
			services.Configure<IISOptions>(options =>
		 {
		 });


		public static void ConfigureAuthentication(this IServiceCollection services, ConfigurationManager config)
		{ 
			
			services.AddAuthentication( x =>
			{
				x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;	
			})
			.AddJwtBearer(x =>
			{
				x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidIssuer = config["JwtSettings:Issuer"],
					ValidAudience = config["JwtSettings:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(config["JwtSettings:Key"])),
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateIssuerSigningKey = true
				};
			});
		}
		
		
		public static void ConfigureLoggingService(this IServiceCollection services) =>
			services.AddSingleton<INLogManager, NLogManager>();
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
			services.AddScoped<IRepositoryManager, RepositoryManager>();        

		public static void ConfigureServiceManager(this IServiceCollection services) =>
			services.AddScoped<IServiceManager, ServiceManager>();

		public static void ConfigureBusinessServices(this IServiceCollection services)
		{
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IIssueAttachmentTypeService, IssueAttachmentTypeService>();
			services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
		}


    }
}
