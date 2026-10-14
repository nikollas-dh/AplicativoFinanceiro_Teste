using LiteDB;
using Microsoft.Extensions.Logging;
using Prototipo_App_Financeiro.Repositories;

namespace Prototipo_App_Financeiro
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
            .RegisterDatabaseAndRepositories();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterDatabaseAndRepositories(this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<LiteDatabase>(
                o =>
                {

                    return new LiteDatabase($"Filename={AppSettings.DatabasePath}");
                });
            builder.Services.AddTransient<ITransactionRepository,TransactionRepository>();
            return builder;
        }
    }
}
