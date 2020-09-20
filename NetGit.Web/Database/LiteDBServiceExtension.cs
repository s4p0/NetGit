using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Database
{
    public static class LiteDBServiceExtension
    {
        public static IServiceCollection AddLiteDb(this IServiceCollection services)
        {
            services.AddTransient<LiteDBContext, LiteDBContext>();
            return services;
        }
    }
}
