using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Argumentos.Default;


namespace R5T.Argumentos.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ICommandLineArgumentsProvider"/> service.
        /// </summary>
        public static IServiceCollection AddCommandLineArgumentsProvider(this IServiceCollection services)
        {
            services.AddDefaultCommandLineArgumentsProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ICommandLineArgumentsProvider"/> service.
        /// </summary>
        public static IServiceCollection AddCommandLineArgumentsProvider<TCommandLineArgumentsProvider>(this IServiceCollection services)
            where TCommandLineArgumentsProvider: ICommandLineArgumentsProvider
        {
            services.AddCommandLineArgumentsProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ICommandLineArgumentsProvider"/> service.
        /// </summary>
        public static ServiceAction<ICommandLineArgumentsProvider> AddCommandLineArgumentsProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICommandLineArgumentsProvider>(() => services.AddCommandLineArgumentsProvider());
            return serviceAction;
        }
    }
}
