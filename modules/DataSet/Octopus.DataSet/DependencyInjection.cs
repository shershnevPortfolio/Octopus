using Microsoft.Extensions.DependencyInjection;

namespace Octopus.DataSet;

public static class DependencyInjection
{
    public static IServiceCollection AddDataSetModule(this IServiceCollection services)
    {
        return services;
    }
}
