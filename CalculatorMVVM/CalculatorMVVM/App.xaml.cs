using Autofac;
using CalculatorMVVM.View;
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var builder = new ContainerBuilder();
            var dataAccess = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(dataAccess)
                .AsImplementedInterfaces()
                .AsSelf();
            var container = builder.Build();
            MainPage = container.Resolve<HistoryView>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
