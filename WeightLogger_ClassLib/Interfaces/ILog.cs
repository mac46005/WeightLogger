using DBManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLogger_ClassLib.Interfaces
{
    public interface ILog<T> : IModel<T>
    {
        string memo { get; set; }
        DateTime DateSubmitted { get; set; }
    }
}
