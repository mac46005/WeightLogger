using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLogger_ClassLib.Interfaces
{
    public interface IWeightLog<T> : ILog<T>
    {
        decimal Weight { get; set; }
        bool didWorkout { get; set; }
        bool didOverEat { get; set; }
    }
}
