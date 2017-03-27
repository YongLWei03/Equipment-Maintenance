using EquipmentMaintenance;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity;
using System.Windows;

namespace MedEngage.App
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        //Internal
        public void BindViewModelToView<TViewModel, TView>()
        {
            ViewModelLocationProvider.Register(typeof(TView).ToString(), () => this.Container.Resolve<TViewModel>());
        }
    }
}
