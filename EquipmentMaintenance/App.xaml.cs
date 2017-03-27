using MedEngage.App;
using System.Windows;

namespace EquipmentMaintenance.App
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
            new Bootstrapper().Run();
        }
    }
}
    