using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions
{
    public static class ConsoleHostBuilder
    {
        /// <summary>
        /// Creates and runs an application of type <typeparamref name="TApplication"/>.
        /// </summary>
        /// <typeparam name="TApplication">The type of the application. Make sure it has a public method Run with return type <see cref="Task"/>.</typeparam>
        /// <param name="arguments">The command line arguments.</param>
        /// <param name="configureLoggingDelegate">Configures how the application will be logging.</param>
        /// <param name="configureConfigurationDelegate">Configures the application's settings, the <see cref="IConfiguration"/>.</param>
        /// <param name="configureServicesDelegate">Configures services to be injected into the application.</param>
        /// /// <param name="configureServiceProviderOptionsDelegate">Configures the <see cref="IServiceProvider"/>.</param>
        public static void CreateAndRunApplication<TApplication>(
            string[] arguments = null,
            Action<ILoggingBuilder> configureLoggingDelegate = null,
            Action<HostBuilderContext, IConfigurationBuilder> configureConfigurationDelegate = null,
            Action<HostBuilderContext, IServiceCollection> configureServicesDelegate = null,
            Action<ServiceProviderOptions> configureServiceProviderOptionsDelegate = null)
            where TApplication : class
        {
            var errorMessage = $"Could not construct console host for application '{typeof(TApplication).Name}'";
            var errorSeeInnerException = $"see innerException for details";

            try
            {
                var runMethod = typeof(TApplication).GetMethod("Run", BindingFlags.Instance | BindingFlags.Public);
                if (runMethod.ReturnType != typeof(Task))
                    throw new ConsoleHostBuilderException(
                        message: $"{errorMessage} because the 'Run' method's return type is not of type 'Task'.");

                var host = CreateHost<TApplication>(
                    arguments,
                    configureLoggingDelegate,
                    configureConfigurationDelegate,
                    configureServicesDelegate,
                    configureServiceProviderOptionsDelegate);

                dynamic application = host.Services.GetService<TApplication>();

                ((Task)application.Run()).Wait();
            }
            catch (Exception exception)
            {
                throw new ConsoleHostBuilderException(
                    message: $"{errorMessage}, {errorSeeInnerException}.",
                    innerException: exception
                );
            }
        }

        /// <summary>
        /// Creates a host for the application to run.
        /// </summary>
        /// <typeparam name="TApplication">The type of the application. Make sure it has a public method Run with return type <see cref="Task"/>.</typeparam>
        /// <param name="arguments">The command line arguments.</param>
        /// <param name="configureLoggingDelegate">Configures how the application will be logging.</param>
        /// <param name="configureConfigurationDelegate">Configures the application's settings, the <see cref="IConfiguration"/>.</param>
        /// <param name="configureServicesDelegate">Configures services to be injected into the application.</param>
        /// /// <param name="configureServiceProviderOptionsDelegate">Configures the <see cref="IServiceProvider"/>.</param>
        public static IHost CreateHost<TApplication>(
            string[] arguments,
            Action<ILoggingBuilder> configureLoggingDelegate = null,
            Action<HostBuilderContext, IConfigurationBuilder> configureConfigurationDelegate = null,
            Action<HostBuilderContext, IServiceCollection> configureServicesDelegate = null,
            Action<ServiceProviderOptions> configureServiceProviderOptionsDelegate = null)
            where TApplication : class
            => Host.CreateDefaultBuilder(arguments)
                .AddAndConfigureLogging(configureLoggingDelegate)
                .AddAndConfigureAppConfiguration(configureConfigurationDelegate)
                .AddAndConfigureServices<TApplication>(configureServicesDelegate)
                .AddAndConfigureDefaultServiceProvider(configureServiceProviderOptionsDelegate)
                .Build();

        /// <summary>
        /// Configures logging, either via a provided delegate or the baked in logic.
        /// </summary>
        private static IHostBuilder AddAndConfigureLogging(
            this IHostBuilder hostBuilder,
            Action<ILoggingBuilder> configureLoggingDelegate)
        {
            if (configureLoggingDelegate != null)
                return hostBuilder.ConfigureLogging(configureLoggingDelegate);

            return hostBuilder
                .ConfigureLogging(logBuilder => logBuilder.AddAndConfigureSerilog());
        }

        /// <summary>
        /// Configures application settings, either via a provided delegate or the baked in logic.
        /// </summary>
        private static IHostBuilder AddAndConfigureAppConfiguration(
            this IHostBuilder hostBuilder,
            Action<HostBuilderContext, IConfigurationBuilder> configureConfigurationDelegate)
        {
            if (configureConfigurationDelegate != null)
                return hostBuilder.ConfigureAppConfiguration(configureConfigurationDelegate);

            return hostBuilder.ConfigureAppConfiguration((hostContext, configBuilder) =>
                configBuilder
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddEnvironmentVariables()
                    .AddJsonFile(
                        path: $"appsettings.json",
                        optional: true,
                        reloadOnChange: true)
                    .AddJsonFile(
                        path: $"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json",
                        optional: true,
                        reloadOnChange: true)
                );
        }

        /// <summary>
        /// Configures services to be injected into the application.
        /// </summary>
        private static IHostBuilder AddAndConfigureServices<TApplication>(
            this IHostBuilder hostBuilder,
            Action<HostBuilderContext, IServiceCollection> configureServicesDelegate)
            where TApplication : class
        {
            hostBuilder.ConfigureServices(services => services.AddSingleton(typeof(TApplication)));

            if (configureServicesDelegate != null)
                return hostBuilder.ConfigureServices(configureServicesDelegate);

            return hostBuilder;
        }

        /// <summary>
        /// Configures the <see cref="IServiceProvider"/>'s options.
        /// </summary>
        private static IHostBuilder AddAndConfigureDefaultServiceProvider(
            this IHostBuilder hostBuilder,
            Action<ServiceProviderOptions> configureServiceProviderOptionsDelegate)
        {
            if (configureServiceProviderOptionsDelegate != null)
                return hostBuilder.UseDefaultServiceProvider(configureServiceProviderOptionsDelegate);

            return hostBuilder
                .UseDefaultServiceProvider(serviceProviderOptions => serviceProviderOptions.ValidateScopes = false);
        }
    }
}
