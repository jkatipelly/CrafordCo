using CrafordCo.Biz;
using CrafordCo.Biz.Interfaces;
using CrafordCo.Data.Interfaces;
using CrafordCo.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrafordCo
{
    public static class DependencyRegistry
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            //Biz
            services.AddScoped<ILossType, LossTypeBiz>();
            services.AddScoped<IUser, UserBiz>();


            //Data.Repositories
            services.AddScoped<ILossTypeRepo, LossTypeRepo>();
            services.AddScoped<IUserRepo, UserRepo>();


            return services;
        }
    }
}
