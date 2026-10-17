using Microsoft.Extensions.DependencyInjection;

namespace Octopus.Execution;

public static class DependencyInjection
{
    public static IServiceCollection AddExecutionModule(this IServiceCollection services)
    {
        return services;
    }
}
