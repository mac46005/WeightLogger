
namespace WeightLogger_ClassLib.Interfaces
{
    public interface IWeightLog<T> : ILog<T>
    {
        decimal Weight { get; set; }
        bool didWorkout { get; set; }
        bool didOverEat { get; set; }
        bool didDrinkAlcohol { get; set; }
    }
}
