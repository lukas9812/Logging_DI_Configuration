//DI, Serilog, Settings
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
BuildConfig(builder);


static void BuildConfig(IConfigurationBuilder builder)
{
    //This talking to application configuration source.
    builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",
            optional: true)
        .AddEnvironmentVariables();
}