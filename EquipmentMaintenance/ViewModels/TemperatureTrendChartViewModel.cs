using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Uwp;
using Prism.Mvvm;
using System;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace EquipmentMaintenance.ViewModels
{
    public class TemperatureTrendChartViewModel : BindableBase
    {
        public TemperatureTrendChartViewModel()
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

        public Func<double, string> TempurFormatter { get; set; }
            = value => string.Format("{0}\u00B0C", value);

        public double AxisXStep = TimeSpan.FromSeconds(60 * 10).Ticks;

        public double AxisYStep = 5;

        public double MaxY = 0;

        public double MinY = 0;

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
                            Title = "温度センサ",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 000, Value = 40.2 },
                                new MeasureModel { Minutes = 010, Value = 38.8 },
                                new MeasureModel { Minutes = 020, Value = 38.9 },
                                new MeasureModel { Minutes = 030, Value = 37.2 },
                                new MeasureModel { Minutes = 040, Value = 38.9 },
                                new MeasureModel { Minutes = 050, Value = 40.3 },
                                new MeasureModel { Minutes = 060, Value = 40.0 },
                                new MeasureModel { Minutes = 070, Value = 40.0 },
                                new MeasureModel { Minutes = 080, Value = 40.0 },
                                new MeasureModel { Minutes = 090, Value = 40.0 },
                                new MeasureModel { Minutes = 100, Value = 40.3 },
                                new MeasureModel { Minutes = 110, Value = 41.0 },
                                new MeasureModel { Minutes = 120, Value = 40.1 },
                                new MeasureModel { Minutes = 130, Value = 39.2 },
                                new MeasureModel { Minutes = 140, Value = 40.0 },
                                new MeasureModel { Minutes = 150, Value = 40.3 },
                                new MeasureModel { Minutes = 160, Value = 40.0 },
                                new MeasureModel { Minutes = 170, Value = 40.0 },
                                new MeasureModel { Minutes = 180, Value = 40.0 }
                            }, Fill = new SolidColorBrush(Colors.Transparent)
                        },
                        new LineSeries {
                            Title = "モータ1温度",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 000, Value = 55.0 },
                                new MeasureModel { Minutes = 010, Value = 55.0 },
                                new MeasureModel { Minutes = 020, Value = 54.8 },
                                new MeasureModel { Minutes = 030, Value = 54.7 },
                                new MeasureModel { Minutes = 040, Value = 54.7 },
                                new MeasureModel { Minutes = 050, Value = 54.7 },
                                new MeasureModel { Minutes = 060, Value = 55.0 },
                                new MeasureModel { Minutes = 070, Value = 55.0 },
                                new MeasureModel { Minutes = 080, Value = 55.1 },
                                new MeasureModel { Minutes = 090, Value = 55.2 },
                                new MeasureModel { Minutes = 100, Value = 55.0 },
                                new MeasureModel { Minutes = 110, Value = 55.0 },
                                new MeasureModel { Minutes = 120, Value = 55.0 },
                                new MeasureModel { Minutes = 130, Value = 55.0 },
                                new MeasureModel { Minutes = 140, Value = 55.0 },
                                new MeasureModel { Minutes = 150, Value = 55.0 },
                                new MeasureModel { Minutes = 160, Value = 55.0 },
                                new MeasureModel { Minutes = 170, Value = 55.0 },
                                new MeasureModel { Minutes = 180, Value = 55.0 }
                            }, Fill = new SolidColorBrush(Colors.Transparent)
                        },
                        new LineSeries {
                            Title = "モータ2温度",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 000, Value = 57.0 },
                                new MeasureModel { Minutes = 010, Value = 57.0 },
                                new MeasureModel { Minutes = 020, Value = 57.0 },
                                new MeasureModel { Minutes = 030, Value = 57.0 },
                                new MeasureModel { Minutes = 040, Value = 57.0 },
                                new MeasureModel { Minutes = 050, Value = 57.0 },
                                new MeasureModel { Minutes = 060, Value = 57.0 },
                                new MeasureModel { Minutes = 070, Value = 57.0 },
                                new MeasureModel { Minutes = 080, Value = 57.0 },
                                new MeasureModel { Minutes = 090, Value = 57.0 },
                                new MeasureModel { Minutes = 100, Value = 57.0 },
                                new MeasureModel { Minutes = 110, Value = 58.0 },
                                new MeasureModel { Minutes = 120, Value = 58.0 },
                                new MeasureModel { Minutes = 130, Value = 58.0 },
                                new MeasureModel { Minutes = 140, Value = 63.8 },
                                new MeasureModel { Minutes = 150, Value = 64.0 },
                                new MeasureModel { Minutes = 160, Value = 64.1 },
                                new MeasureModel { Minutes = 170, Value = 62.4 },
                                new MeasureModel { Minutes = 180, Value = 63.0 }
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
