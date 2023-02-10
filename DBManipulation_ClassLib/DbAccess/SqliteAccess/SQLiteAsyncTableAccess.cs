using DBManipulation_ClassLib.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.DbAccess.SqliteAccess
{
    public abstract class SQLiteAsyncTableAccess<T,U> : ICRUD_Async<T,U> where T : IModel<U>
    {
        protected SQLiteAsyncConnection _dbConnection;
        public abstract Task<int> CreateAsync(T model);
        public abstract Task<int> DeleteAsync(T model);
        public abstract Task<List<T>> ReadAllAsync();
        public abstract Task<T> ReadAsync(U id);
        public abstract Task<int> UpdateAsync(T model);
    }
}
