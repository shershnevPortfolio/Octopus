using Microsoft.Extensions.DependencyInjection;

namespace Octopus.Source;

public static class DependencyInjection
{
    public static IServiceCollection AddSourceModule(this IServiceCollection services)
    {
        return services;
    }
}
