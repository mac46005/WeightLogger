using DBManipulation_ClassLib.DbAccess.SqliteAccess;
using DBManipulation_ClassLib.Interfaces;
using WeightLogger_ClassLib.DbAccess;
using WeightLogger_ClassLib.Models;
using WeightLogger_UI.MVVM.ViewModels;
using WeightLogger_UI.MVVM.Views;

namespace WeightLogger_UI
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
                });
            builder.Services.AddTransient<ISQLiteDbConnection>(services =>
            {
                return new SQLiteDBConnection("weightlogger_app.db", FileSystem.AppDataDirectory, SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.SharedCache);
            });
            builder.Services.AddTransient<SQLiteAsyncTableAccess<WeightLog,int>, WeightLogsTableAccess>();
            builder.Services.AddTransient<WeightLogsViewModel>(services =>
            {
                return new WeightLogsViewModel(services.GetService<SQLiteAsyncTableAccess<WeightLog,int>>());
            });
            builder.Services.AddTransient<WeightLogsPage>();
            builder.Services.AddTransient<AddEditWeightLogViewModel>(services =>
            {
                SQLiteAsyncTableAccess<WeightLog, int> weightLogs = services.GetService<SQLiteAsyncTableAccess<WeightLog, int>>();
                return new AddEditWeightLogViewModel(weightLogs,weightLogs);
            });
            builder.Services.AddTransient<AddEditWeightLogPage>();
            return builder.Build();
        }
    }
}