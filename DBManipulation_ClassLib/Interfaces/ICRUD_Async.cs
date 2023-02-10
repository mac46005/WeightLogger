using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    public interface ICRUD_Async<T,U> : ICreateAsync<T>, IReadAsync<T,U>, IUpdateAsync<T,U>, IDeleteAsync<T,U> where T : IModel<U>
    {

    }
}
