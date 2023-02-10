using DBManipulation_ClassLib.DbAccess.SqliteAccess;
using DBManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLogger_ClassLib.Models;

namespace WeightLogger_ClassLib.DbAccess
{
    public class WeightLogsTableAccess : SQLiteAsyncTableAccess<WeightLog, int>
    {
        public WeightLogsTableAccess(ISQLiteDbConnection connection)
        {
            _connection = connection;
        }
        public override async Task<int> CreateAsync(WeightLog model)
        {
            var result = await _dbConnection.InsertAsync(model);
            return result;
        }

        public override async Task<int> DeleteAsync(WeightLog model)
        {
            var result = await _dbConnection.DeleteAsync(model);
            return result;
        }

        public override async Task<List<WeightLog>> ReadAllAsync()
        {
            var result = await _dbConnection.Table<WeightLog>().ToListAsync();
            return result;
        }

        public override async Task<WeightLog> ReadAsync(int id)
        {
            var result = await _dbConnection.GetAsync<WeightLog>(id);
            return result;
        }

        public override async Task<int> UpdateAsync(WeightLog model)
        {
            var result = await _dbConnection.UpdateAsync(model);
            return result;
        }

        private async Task Open()
        {
            _dbConnection = new SQLite.SQLiteAsyncConnection(_connection.DataBasePath,_connection.Flags);
            var result = await _dbConnection.CreateTableAsync<WeightLog>();
        }
    }
}
