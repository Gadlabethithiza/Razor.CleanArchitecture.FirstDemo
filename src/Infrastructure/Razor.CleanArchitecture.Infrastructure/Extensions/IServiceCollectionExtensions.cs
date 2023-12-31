﻿using Razor.CleanArchitecture.Application.Interfaces;
using Razor.CleanArchitecture.Domain;
using Razor.CleanArchitecture.Domain.Common.Interfaces;
using Razor.CleanArchitecture.Infrastructure.Services;

using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Razor.CleanArchitecture.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>();
        }
    }
}
