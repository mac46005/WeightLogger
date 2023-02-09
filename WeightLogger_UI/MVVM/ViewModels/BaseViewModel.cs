using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLogger_UI.MVVM.ViewModels
{
    public abstract class BaseViewModel : ObservableObject
    {
        public string Title { get; set; }
    }
}
