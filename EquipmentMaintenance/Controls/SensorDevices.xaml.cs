using LiveCharts;
using LiveCharts.Uwp;
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
    public sealed partial class SensorDevices : Page
    {
        public SensorDevices()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        private static List<Car> _cars;
        public static List<Car> Cars
        {
            get
            {
                if (_cars == null)
                {
                    _cars = CarManager.GetCars();
                }
                return _cars;
            }
            set { _cars = value; }
        }
    }

    public class Car
    {
        public int No { get; set; }
        public string Pro1 { get; set; }
        public string Pro2 { get; set; }
        public bool Pro3 { get; set; }
        public bool Pro4 { get; set; }
    }
    public class CarManager
    {
        public static SeriesCollection GetCharts()
        {
            return new SeriesCollection
            {
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
        }

        public static List<Car> GetCars()
        {
            var cars = new List<Car>();
            cars.Add(new Car { No = 1, Pro1 = "電源電圧",
                Pro2 = "通電時の電圧を確認して下さい。",
                Pro3 = true,
                Pro4 = false,
            });
            cars.Add(new Car { No = 2, Pro1 = "電源ランプ",
                Pro2 = "通電による電源ランプの点灯切替を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            });
            cars.Add(new Car { No = 3, Pro1 = "扉センサ1",
                Pro2 = "前面右扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            });
            cars.Add(new Car { No = 4, Pro1 = "扉センサ2",
                Pro2 = "前面左扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = false,
                Pro4 = true
            });
            cars.Add(new Car { No = 5, Pro1 = ":", Pro2 = ":", Pro3 = false, Pro4 = false });

            return cars;
        }

        public static ChartValues<CarDetail> GetCarDetails()
        {
            var cars = new ChartValues<CarDetail>();
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 10, 5,5,30,0,0, DateTimeKind.Utc),
                Pro2 = "温度高", Val = 21
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 6, 11, 3, 0, 0, DateTimeKind.Utc),
                Pro2 = "温度高", Val = 2
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大", Val = 3
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 3
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 4
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 5
            });
            cars.Add(new CarDetail
            {
                Pro1 = new DateTime(2016, 6, 13, 23, 30, 0, 0, DateTimeKind.Utc),
                Pro2 = "振動大",
                Val = 7
            });
            cars.Add(new CarDetail { Pro2 = ":"});
            cars.Add(new CarDetail { Pro2 = ":"});
            cars.Add(new CarDetail { Pro2 = ":"});
            cars.Add(new CarDetail { Pro2 = ":"});
            cars.Add(new CarDetail { Pro2 = ":"});

            return cars;
        }
    }
}
