using Microsoft.Extensions.DependencyInjection;

namespace Octopus.Pipeline;

public static class DependencyInjection
{
    public static IServiceCollection AddPipelineModule(this IServiceCollection services)
    {
        return services;
    }
}
