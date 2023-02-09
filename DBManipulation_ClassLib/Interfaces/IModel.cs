using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManipulation_ClassLib.Interfaces
{
    /// <summary>
    /// Used for database manipulation. Gives model an attribute of primary key ID
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IModel<T>
    {
        /// <summary>
        /// The primary key used for databases
        /// </summary>
        T ID { get; set; }
    }
}
