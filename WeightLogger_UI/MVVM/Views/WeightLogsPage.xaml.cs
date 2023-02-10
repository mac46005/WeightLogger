using WeightLogger_UI.MVVM.ViewModels;

namespace WeightLogger_UI.MVVM.Views;

public partial class WeightLogsPage : ContentPage
{
	public WeightLogsPage(WeightLogsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}