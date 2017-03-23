using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Uwp;
using Prism.Mvvm;
using System;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace EquipmentMaintenance.ViewModels
{
    public class VibrationTrendChartViewModel : BindableBase
    {
        public VibrationTrendChartViewModel()
        {
            ChartMapper();
        }

        public void ChartMapper()
        {
            var mapper = Mappers.Xy<MeasureModel>()
                   .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                   .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);
        }

        //lets set how to display the X Labels
        public Func<double, string> DateTimeFormatter { get; set; }
            = value => new DateTime((long)value).ToString("HH:mm");
        public Func<double, string> NumberFormatter { get; set; }
            = value => value.ToString();

        public double AxisXStep = TimeSpan.FromSeconds(60 * 10).Ticks;

        public double AxisYStep = 5000;

        //the values property will store our values array
        private SeriesCollection _series;
        public SeriesCollection Series
        {
            get
            {
                if (_series == null)
                {
                    _series = new SeriesCollection {
                        new LineSeries {
                            Title = "モータ１振動",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 000, Value = 15000 },
                                new MeasureModel { Minutes = 010, Value = 15500 },
                                new MeasureModel { Minutes = 020, Value = 15100 },
                                new MeasureModel { Minutes = 030, Value = 15300 },
                                new MeasureModel { Minutes = 040, Value = 15200 },
                                new MeasureModel { Minutes = 050, Value = 14000 },
                                new MeasureModel { Minutes = 060, Value = 14300 },
                                new MeasureModel { Minutes = 070, Value = 15000 },
                                new MeasureModel { Minutes = 080, Value = 15200 },
                                new MeasureModel { Minutes = 090, Value = 14900 },
                                new MeasureModel { Minutes = 100, Value = 15000 },
                                new MeasureModel { Minutes = 110, Value = 15000 },
                                new MeasureModel { Minutes = 120, Value = 14900 },
                                new MeasureModel { Minutes = 130, Value = 15100 },
                                new MeasureModel { Minutes = 140, Value = 15000 },
                                new MeasureModel { Minutes = 150, Value = 26000 },
                                new MeasureModel { Minutes = 160, Value = 18500 },
                                new MeasureModel { Minutes = 170, Value = 15000 },
                                new MeasureModel { Minutes = 180, Value = 15000 }
                            }, Fill = new SolidColorBrush(Colors.Transparent)
                        },
                        new LineSeries {
                            Title = "モータ２振動",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 000, Value = 20000 },
                                new MeasureModel { Minutes = 010, Value = 20010 },
                                new MeasureModel { Minutes = 020, Value = 20100 },
                                new MeasureModel { Minutes = 030, Value = 19832 },
                                new MeasureModel { Minutes = 040, Value = 19820 },
                                new MeasureModel { Minutes = 050, Value = 22000 },
                                new MeasureModel { Minutes = 060, Value = 19300 },
                                new MeasureModel { Minutes = 070, Value = 20000 },
                                new MeasureModel { Minutes = 080, Value = 18300 },
                                new MeasureModel { Minutes = 090, Value = 23030 },
                                new MeasureModel { Minutes = 100, Value = 20000 },
                                new MeasureModel { Minutes = 110, Value = 20000 },
                                new MeasureModel { Minutes = 120, Value = 20000 },
                                new MeasureModel { Minutes = 130, Value = 42400 },
                                new MeasureModel { Minutes = 140, Value = 20000 },
                                new MeasureModel { Minutes = 150, Value = 20000 },
                                new MeasureModel { Minutes = 160, Value = 20000 },
                                new MeasureModel { Minutes = 170, Value = 20000 },
                                new MeasureModel { Minutes = 180, Value = 20000 }
                            }, Fill = new SolidColorBrush(Colors.Transparent)
                        }
                    };
                }
                return _series;
            }
            set { SetProperty(ref _series, value); }
        }
    }
}
