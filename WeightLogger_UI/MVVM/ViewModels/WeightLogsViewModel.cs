using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DBManipulation_ClassLib.Enums;
using DBManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLogger_ClassLib.Models;

namespace WeightLogger_UI.MVVM.ViewModels
{
    public partial class WeightLogsViewModel : BaseViewModel
    {

        IReadAsync<WeightLog, int> _readAsync;
        /// <summary>
        /// list of weight log items
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<string> _logs = new ObservableCollection<string>();
        public WeightLogsViewModel(IReadAsync<WeightLog,int> readAsync)
        {
            _readAsync = readAsync;
        }

        /// <summary>
        /// Sends user to add weight log page
        /// </summary>
        [RelayCommand]
        void GoToAddNewLog()
        {
            ///TODO
            ///Create add/edit page for weight log
            ///add page to routing in appshell
            ///test
            ///
            Shell.Current.GoToAsync("addeditweightlog", new Dictionary<string,object>()
            {
                {"crud_option",CRUD_Options.CREATE }
            });

        }
    }
}
