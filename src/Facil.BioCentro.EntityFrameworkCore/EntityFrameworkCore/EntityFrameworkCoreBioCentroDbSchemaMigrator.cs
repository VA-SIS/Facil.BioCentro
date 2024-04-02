using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Facil.BioCentro.Data;
using Volo.Abp.DependencyInjection;

namespace Facil.BioCentro.EntityFrameworkCore;

public class EntityFrameworkCoreBioCentroDbSchemaMigrator
    : IBioCentroDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBioCentroDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BioCentroDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BioCentroDbContext>()
            .Database
            .MigrateAsync();
    }
}
