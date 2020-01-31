using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Dimitrios.Maoursi;
using R5T.Egaleo.Standard;
using R5T.Lombardy.Standard;
using R5T.Maoursi.Dropbox;
using R5T.Oxford.Rivet.Standard;


namespace R5T.Dimitrios.DropboxRivet
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddDropboxRivetOrganizationDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddMaoursiOrganizationDirectoryPathProviderAction(
                services.AddOrganizationsDirectoryPathProviderAction(),
                services.AddRivetOrganizationProviderAction(),
                services.AddOrganizationDirectoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationDirectoryPathProvider> AddDropboxRivetOrganizationDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationDirectoryPathProvider>(() => services.AddDropboxRivetOrganizationDirectoryPathProvider());
            return serviceAction;
        }
    }
}
