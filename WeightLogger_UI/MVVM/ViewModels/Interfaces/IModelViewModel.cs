using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManipulation_ClassLib.Interfaces;

namespace WeightLogger_UI.MVVM.ViewModels.Interfaces
{
    public interface IModelViewModel<T,U> where T : IModel<U>
    {
        /// <summary>
        /// The model that represents this view model of type IModel
        /// </summary>
        T Model { get; set; }
    }
}
