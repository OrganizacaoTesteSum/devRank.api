﻿using devRank.Infra.Auth.Handlers;
using devRank.Infra.Auth.Providers;
using devRank.Presentation.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace devRank.Presentation.Configurations;

public static class AuthConfiguration
{
    public static IServiceCollection AdicionarAutentificacao(this IServiceCollection services)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer();

        services.AddScoped<IAuthorizationHandler, AuthPermissaoHandler>();
        services.AddSingleton<IAuthorizationPolicyProvider, PermissaoAuthPoliceProvider>();
        services.ConfigureOptions<JwtSetupOptions>();
        services.ConfigureOptions<JwtBearerSetupOptions>();

        return services;
    }
}