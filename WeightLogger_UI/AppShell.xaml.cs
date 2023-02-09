using WeightLogger_UI.MVVM.Views;

namespace WeightLogger_UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("/addeditweightlog", typeof(AddEditWeightLogPage));
        }
    }
}