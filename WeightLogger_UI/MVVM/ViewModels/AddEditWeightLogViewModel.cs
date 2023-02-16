using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DBManipulation_ClassLib.Enums;
using DBManipulation_ClassLib.Interfaces;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLogger_ClassLib.Models;

namespace WeightLogger_UI.MVVM.ViewModels
{
    [QueryProperty(nameof(Options), "crud_options")]
    public partial class AddEditWeightLogViewModel : BaseViewModel
    {

        ICreateAsync<WeightLog> _create;
        IUpdateAsync<WeightLog, int> _update;


        [ObservableProperty]
        private CRUD_Options _options;
        [ObservableProperty]
        private IModel<int> _model;
        public AddEditWeightLogViewModel(ICreateAsync<WeightLog> create, IUpdateAsync<WeightLog,int> update)
        {
            _create = create;
            _update = update;
        }
        [RelayCommand]
        void Submit()
        {
            Shell.Current.GoToAsync("..");
        }
    }
}
