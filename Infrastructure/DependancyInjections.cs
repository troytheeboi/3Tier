using Domain.Repo_Interfaces;
using Infrastructure.DB_Contexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependancyInjections
{
    public static IServiceCollection AddPresistance(this IServiceCollection services)
    {
        IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
        IConfigurationRoot root = builder.Build();
        services.AddDbContext<MyDbContext>(options =>
        {
            options.UseNpgsql(root.GetConnectionString("PostgreConnectionString"));
        });

        services.AddScoped(typeof(IBrnachRepository),typeof(BranchRepository));

        return services;
    }

}