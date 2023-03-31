﻿using CantinaIBJ.Data.Contracts;
using CantinaIBJ.Data.Contracts.Customer;
using CantinaIBJ.Data.Repositories;
using CantinaIBJ.Data.Repositories.Customer;
using CantinaIBJ.WebApi.Models;

namespace CantinaIBJ.WebApi.Configurations;

public static class ServicesConfiguration
{
    public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<MapperProfile>();
        services.AddScoped<ICustomerPersonRepository, CustomerPersonRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}