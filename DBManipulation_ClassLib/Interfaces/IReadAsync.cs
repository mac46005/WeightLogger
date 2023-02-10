using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface IReadAsync<T,U> where T: IModel<U> 
    {
        Task<T> ReadAsync(U id);
        Task<List<T>> ReadAllAsync();
    }
}
