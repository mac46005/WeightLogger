using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLogger_ClassLib.Interfaces;

namespace WeightLogger_ClassLib.Models
{
    [Table("weight_Log")]
    public class WeightLog : IWeightLog<int>
    {
        [Column("weight"),NotNull]
        public decimal Weight { get; set; }
        [Column("did_Workout")]
        public bool didWorkout { get;set; } = false;
        [Column("did_over_eat")]
        public bool didOverEat { get; set; } = false;
        [Column("memo")]
        public string Memo { get;set; } = string.Empty;
        [Column("date_submitted")]
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
        [Column("id"), PrimaryKey, AutoIncrement]
        public int ID { get;set; }
        [Column("did_drink_alcohol")]
        public bool didDrinkAlcohol { get; set; } = false;
    }
}
