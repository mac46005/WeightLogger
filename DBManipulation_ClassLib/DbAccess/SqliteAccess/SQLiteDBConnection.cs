using DBManipulation_ClassLib.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.DbAccess.SqliteAccess
{
    public class SQLiteDBConnection : ISQLiteDbConnection
    {
        public SQLiteDBConnection(string databaseFileName, string databaseFilePath, SQLiteOpenFlags flags)
        {
            DatabaseFileName = databaseFileName;
            DatabaseFilePath = databaseFilePath;
            Flags = flags;
        }
        public SQLiteOpenFlags Flags { get; set; }
        public string DatabaseFilePath { get; set; } = string.Empty;
        public string DatabaseFileName { get; set; } = string.Empty;

        public string DataBasePath => Path.Combine(DatabaseFilePath, DatabaseFileName);
    }