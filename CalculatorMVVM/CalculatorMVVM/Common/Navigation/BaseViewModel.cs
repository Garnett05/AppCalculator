using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorMVVM.Services
{
    public abstract class BaseViewModel : BindableObject
    {
        public virtual Task InitializeAsync(object param)
        {
            return Task.CompletedTask;
        }
    }
}