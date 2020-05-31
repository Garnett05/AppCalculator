using CalculatorMVVM.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace CalculatorMVVM.Modules.AppInformation
{
    public class AppInformationViewModel : BaseViewModel
    {
        public string AppName => $"App Name: {AppInfo.Name}";
        public string AppVersion => $"App Version: {AppInfo.VersionString}";
        public string Author => "Author: Charlles Lima";
    }
}
