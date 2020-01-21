using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dimitrios.Maoursi;
using R5T.Egaleo.Standard;
using R5T.Lombardy.Standard;
using R5T.Maoursi.Dropbox;
using R5T.Oxford.Rivet.Standard;


namespace R5T.Dimitrios.DropboxRivet
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDropboxRivetOrganizationDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<IOrganizationDirectoryPathProvider, OrganizationDirectoryPathProvider>()
                .AddOrganizationDirectoryNameConvention()
                .AddStringlyTypedPathOperator()
                .AddDropboxOrganizationsDirectoryPathProvider()
                .AddRivetOrganizationProvider()
                ;

            return services;
        }
    }
}
