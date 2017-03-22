using LiveCharts;
using LiveCharts.Uwp;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

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
            this.DataContext = this;
        }

        private static List<string> _labels = new List<string> { "温度高", "振動大", ":" };
        public static List<string> Labels { get { return _labels; } }

        
        public static ChartValues<CarDetail> CarDetails { get { return _carDetails; } }
        private static ChartValues<CarDetail> _carDetails = new ChartValues<CarDetail> {
            new CarDetail
            {
                Pro1 = new DateTime(2016, 10, 5,5,30,0,0, DateTimeKind.Utc),
                Pro2 = "温度高", Val = 21
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 6, 11, 3, 0, 0, DateTimeKind.Utc),
                Pro2 = "温度高",
                Val = 2
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 3
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 3
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 4
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 5
            },
            new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 7
            },
            new CarDetail { Pro2 = ":" },
            new CarDetail { Pro2 = ":" },
            new CarDetail { Pro2 = ":" },
            new CarDetail { Pro2 = ":" },
            new CarDetail { Pro2 = ":" }
        };

        public SeriesCollection SeriesCollection { get { return _seriiesCollection; } }
        private SeriesCollection _seriiesCollection = new SeriesCollection {
            new LineSeries
            {
                Title = "Series 1",
                Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
            },
            new LineSeries
            {
                Title = "Series 2",
                Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                PointGeometry = DefaultGeometries.None
            },
            new LineSeries
            {
                Title = "Series 3",
                Values = new ChartValues<double> { 4,2,7,2,7 },
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15
            }
        };

        public Func<double, string> YFormatter { get; set; } = value => value.ToString("C");
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

