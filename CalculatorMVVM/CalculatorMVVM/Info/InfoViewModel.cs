using CalculatorMVVM.Services;
using CalculatorMVVM.View;
using CalculatorMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVVM.Info
{
    public class InfoViewModel : BaseViewModel
    {
        public HistoryViewModel HistoryViewModel { get; set; }

        public InfoViewModel(HistoryViewModel historyViewModel)
        {
            HistoryViewModel = historyViewModel;
        }

        public override Task InitializeAsync(object param)
        {
            return HistoryViewModel.InitializeAsync(param);
        }
    }
}
