using Characters.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(IServiceCollection services)
        {
            services.AddScoped<ICharacterService, CharacterService>();
            return services;
        }
    }
}
