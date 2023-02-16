using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DBManipulation_ClassLib.Enums;
using DBManipulation_ClassLib.Interfaces;
using WeightLogger_ClassLib.Models;

namespace WeightLogger_UI.MVVM.ViewModels
{
    [QueryProperty(nameof(Options), "crud_options")]
    public partial class AddEditWeightLogViewModel : ObservableObject
    {

        ICreateAsync<WeightLog> _create;
        IUpdateAsync<WeightLog, int> _update;


        [ObservableProperty]
        private CRUD_Options options;

        [ObservableProperty]
        private decimal weight;
        [ObservableProperty]
        private bool didWorkOut = false;
        [ObservableProperty]
        private bool didOvereat = false;
        [ObservableProperty]
        private bool didDrink = false ;
        [ObservableProperty]
        private string memo;

        public AddEditWeightLogViewModel(ICreateAsync<WeightLog> create, IUpdateAsync<WeightLog,int> update)
        {
            _create = create;
            _update = update;
        }
        [RelayCommand]
        void Submit()
        {
            WeightLog wl = new WeightLog();
            wl.Weight = weight;
            wl.didWorkout = didWorkOut;
            wl.didOverEat = didOvereat;
            wl.didDrinkAlcohol= didDrink;
            Shell.Current.GoToAsync("..");
        }
    }
}
