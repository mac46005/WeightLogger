using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface ITableAccess<T,U>
    {
        Task<int> Create(T obj);
        Task<int> Delete(U id);
        Task<List<T>> Read();
        Task<T> Read(U id);
        Task<int> Update(T obj);
    }
}
