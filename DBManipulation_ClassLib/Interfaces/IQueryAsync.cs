using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface IQueryAsync
    {
        Task<T> QueryAsync<T>(string sql, params object[] args);
    }
}
