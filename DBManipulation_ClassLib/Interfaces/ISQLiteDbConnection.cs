using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface ISQLiteDbConnection
    {
        SQLiteOpenFlags Flags { get; set; }
        string DatabaseFilePath { get; set; }
        string DatabaseFileName { get; set; }
        string DataBasePath { get; }
    }
}
