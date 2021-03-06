﻿using AutoMapper;
using Kf.CANetCore31.Core.Application.Behaviors;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Kf.CANetCore31.Core.Application
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddAndConfigureApplication(
            this IServiceCollection serviceCollection,
            IConfiguration configuration = default)
            => serviceCollection
                .AddAndConfigureAutoMapper()
                .AddAndConfigureMediatR();

        private static IServiceCollection AddAndConfigureAutoMapper(
            this IServiceCollection serviceCollection)
            => serviceCollection
                .AddAutoMapper(Assembly.GetExecutingAssembly());

        private static IServiceCollection AddAndConfigureMediatR(
            this IServiceCollection serviceCollection)
            => serviceCollection
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(LogRequestProcessingTimeBehavior<,>));
    }
}
