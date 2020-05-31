using CalculatorMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatorMVVM.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        public HistoryViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        public override Task InitializeAsync(object param)
        {
            Items = new ObservableCollection<string>(param as List<string>);
            OnPropertyChanged("Items");
            return base.InitializeAsync(param);
        }
        public ObservableCollection<string> Items { get; set; }

        public ICommand DeleteCommand
        {
            get => new Command<string>(DeleteItem);
        }

        private void DeleteItem(string item)
        {
            Items.Remove(item);
            MessagingCenter.Send(this, "Items", new List<string>(Items));
        }
    }
}