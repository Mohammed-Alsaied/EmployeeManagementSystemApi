﻿//using Common.AssemplyScanning;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;

//namespace Common.Configurations
//{
//    public class AuthenticationServiceInstaller : IInstaller
//    {
//        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
//        {
//            services.AddAuthentication(options =>
//            {
//                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//            })
//           .AddJwtBearer(options =>
//           {
//               options.SaveToken = true;
//               options.RequireHttpsMetadata = false;
//               options.TokenValidationParameters = new TokenValidationParameters()
//               {
//                   ValidateIssuer = true,
//                   ValidateAudience = true,
//                   ValidAudience = configuration["JWT:ValidAudience"],
//                   ValidIssuer = configuration["JWT:ValidIssuer"],
//                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
//               };
//           });
//        }
//    }
//}
