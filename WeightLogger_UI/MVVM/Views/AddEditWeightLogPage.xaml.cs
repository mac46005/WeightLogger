using WeightLogger_UI.MVVM.ViewModels;

namespace WeightLogger_UI.MVVM.Views;

public partial class AddEditWeightLogPage : ContentPage
{
	public AddEditWeightLogPage(AddEditWeightLogViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}