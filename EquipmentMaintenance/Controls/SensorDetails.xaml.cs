using LiveCharts;
using LiveCharts.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EquipmentMaintenance
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SensorDetails : Page
    {
        public SensorDetails()
        {
            this.InitializeComponent();

            YFormatter = value => value.ToString("C");
            SeriesCollection = CarManager.GetCharts();
            //this.DataContext = this;
        }

        private static List<string> _labels;
        public static List<string> Labels
        {
            get
            {
                if (_labels == null)
                {
                    _labels = new List<string> { "温度高", "振動大", ":" };
                }
                return _labels;
            }
        }

        private static ChartValues<CarDetail> _carDetails;
        public static ChartValues<CarDetail> CarDetails
        {
            get
            {
                if (_carDetails == null)
                {
                    _carDetails = CarManager.GetCarDetails();
                }
                return _carDetails;
            }
            set { _carDetails = value; }
        }

        public SeriesCollection SeriesCollection { get; set; }

        public Func<double, string> YFormatter { get; set; }
    }

    public class CarDetail
    {
        public DateTime? Pro1 { get; set; }
        public string Pro1Text
        {
            get
            {
                return Pro1.HasValue ? Pro1.Value.ToString("yyyy/MM/dd HH:mm") : ":";
            }
        }
        public string Pro2 { get; set; }
        public int Val { get; set; }
    }
}

