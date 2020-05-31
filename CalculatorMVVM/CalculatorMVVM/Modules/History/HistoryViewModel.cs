﻿using CalculatorMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatorMVVM.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        public HistoryViewModel()
        {
            Items = new ObservableCollection<string>
            {
            "44 + 5 = 49",
            "36 / 9 = 4",
            "21 * 4 = 84"
            };
        }
        public ObservableCollection<string> Items { get; set; }

        public ICommand DeleteCommand
        {
            get => new Command<string>(DeleteItem);
        }

        private void DeleteItem(string item)
        {
            Items.Remove(item);
        }
    }
}