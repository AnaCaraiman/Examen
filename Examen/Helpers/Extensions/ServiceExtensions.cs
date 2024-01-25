using Examen.Repositories.EvenimenteRepository;
using Examen.Repositories.ParticipantiRepository;
using Examen.Service.EvenimenteService;
using Examen.Service.ParticipantiService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IParticipantiRepository, ParticipantiRepository>();
            services.AddTransient<IEvenimenteRepository, EvenimenteRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<IParticipantiService, ParticipantiService>();
            services.AddTransient<IEvenimenteService, EvenimenteService>();
            return services;
        }
    }
}
