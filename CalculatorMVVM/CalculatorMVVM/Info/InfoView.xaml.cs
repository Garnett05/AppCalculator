using CalculatorMVVM.Modules.AppInformation;
using CalculatorMVVM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorMVVM.Info
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoView : TabbedPage
    {
        public InfoView(InfoViewModel viewModel, 
            HistoryView historyView, 
            AppInformationView appInformationView)
        {
            InitializeComponent();
            BindingContext = viewModel;
            historyView.BindingContext = viewModel.HistoryViewModel;
            Children.Add(historyView);
            Children.Add(appInformationView);
        }
    }
}