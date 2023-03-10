using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface IUpdateAsync<T,U> where T : IModel<U>
    {
        Task<int> UpdateAsync(T model);
    }
}
