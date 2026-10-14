using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo_App_Financeiro
{
    public class AppSettings
    {
        private static string DatabaseName = "database.db";
        private static string DatabaseDirectory= FileSystem.AppDataDirectory;
        public static string DatabasePath = Path.Combine(DatabaseDirectory, DatabaseName);
    }
}
