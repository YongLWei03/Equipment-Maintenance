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
    public sealed partial class SensorDevices : Page
    {
        public SensorDevices()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public List<Car> Cars { get { return _cars; } }

        private List<Car> _cars = new List<Car> {
            new Car { No = 1, Pro1 = "電源電圧",
                Pro2 = "通電時の電圧を確認して下さい。",
                Pro3 = true,
                Pro4 = false,
            },
            new Car { No = 2, Pro1 = "電源ランプ",
                Pro2 = "通電による電源ランプの点灯切替を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            },
            new Car { No = 3, Pro1 = "扉センサ1",
                Pro2 = "前面右扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            },
            new Car { No = 4, Pro1 = "扉センサ2",
                Pro2 = "前面左扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = false,
                Pro4 = true
            },
            new Car { No = 5, Pro1 = ":", Pro2 = ":", Pro3 = false, Pro4 = false }
        };
    }

    public class Car
    {
        public int No { get; set; }
        public string Pro1 { get; set; }
        public string Pro2 { get; set; }
        public bool Pro3 { get; set; }
        public bool Pro4 { get; set; }
    }
}
