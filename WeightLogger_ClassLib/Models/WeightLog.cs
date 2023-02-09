using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLogger_ClassLib.Interfaces;

namespace WeightLogger_ClassLib.Models
{
    public class WeightLog : IWeightLog<int>
    {
        public decimal Weight { get; set; }
        public bool didWorkout { get;set; }
        public bool didOverEat { get;set; }
        public string Memo { get;set; }
        public DateTime DateSubmitted { get;set; }
        public int ID { get;set; }
    }
}
