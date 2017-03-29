using System;
using System.Windows;

namespace EquipmentMaintenance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            InkInputHelper.DisableWPFTabletSupport();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Windows 8 API to enable touch keyboard to monitor for focus tracking in this WPF application
            InputPanelConfiguration cp = new InputPanelConfiguration();
            IInputPanelConfiguration icp = cp as IInputPanelConfiguration;
            if (icp != null)
                icp.EnableFocusTracking();
        }
    }
}
