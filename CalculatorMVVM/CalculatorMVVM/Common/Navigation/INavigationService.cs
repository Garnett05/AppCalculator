using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVVM.Services
{
    public interface INavigationService
    {
        Task PushAsync<TViewModel>(object param = null) where TViewModel : BaseViewModel;
        Task PopAsync();
    }
}
