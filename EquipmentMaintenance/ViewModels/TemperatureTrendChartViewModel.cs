using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using Prism.Mvvm;
using System;
using System.Windows.Media;

namespace EquipmentMaintenance
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
                                new MeasureModel { Minutes = 660, Value = 40.2 },
                                new MeasureModel { Minutes = 670, Value = 38.8 },
                                new MeasureModel { Minutes = 680, Value = 38.9 },
                                new MeasureModel { Minutes = 690, Value = 37.2 },
                                new MeasureModel { Minutes = 700, Value = 38.9 },
                                new MeasureModel { Minutes = 710, Value = 40.3 },
                                new MeasureModel { Minutes = 720, Value = 40.5 },
                                new MeasureModel { Minutes = 730, Value = 40.7 },
                                new MeasureModel { Minutes = 740, Value = 40.2 },
                                new MeasureModel { Minutes = 750, Value = 40.8 },
                                new MeasureModel { Minutes = 760, Value = 40.1 },
                                new MeasureModel { Minutes = 770, Value = 41.0 },
                                new MeasureModel { Minutes = 780, Value = 40.1 },
                                new MeasureModel { Minutes = 790, Value = 39.2 },
                                new MeasureModel { Minutes = 800, Value = 40.0 },
                                new MeasureModel { Minutes = 810, Value = 40.3 },
                                new MeasureModel { Minutes = 820, Value = 40.0 },
                                new MeasureModel { Minutes = 830, Value = 40.9 },
                                new MeasureModel { Minutes = 840, Value = 40.1 }
                            },
                            Fill = new SolidColorBrush(Colors.Transparent),
                            PointGeometry = DefaultGeometries.Square,
                            LineSmoothness = 0
                        },
                        new LineSeries {
                            Title = "モータ1温度",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 660, Value = 55.7 },
                                new MeasureModel { Minutes = 670, Value = 55.0 },
                                new MeasureModel { Minutes = 680, Value = 54.8 },
                                new MeasureModel { Minutes = 690, Value = 54.7 },
                                new MeasureModel { Minutes = 700, Value = 54.8 },
                                new MeasureModel { Minutes = 710, Value = 54.9 },
                                new MeasureModel { Minutes = 720, Value = 55.0 },
                                new MeasureModel { Minutes = 730, Value = 55.6 },
                                new MeasureModel { Minutes = 740, Value = 55.1 },
                                new MeasureModel { Minutes = 750, Value = 55.2 },
                                new MeasureModel { Minutes = 760, Value = 56.0 },
                                new MeasureModel { Minutes = 770, Value = 57.0 },
                                new MeasureModel { Minutes = 780, Value = 58.0 },
                                new MeasureModel { Minutes = 790, Value = 59.0 },
                                new MeasureModel { Minutes = 800, Value = 60.0 },
                                new MeasureModel { Minutes = 810, Value = 60.1 },
                                new MeasureModel { Minutes = 820, Value = 55.2 },
                                new MeasureModel { Minutes = 830, Value = 55.3 },
                                new MeasureModel { Minutes = 840, Value = 55.4 }
                            },
                            Fill = new SolidColorBrush(Colors.Transparent),
                            PointGeometry = DefaultGeometries.Circle,
                            LineSmoothness = 0
                        },
                        new LineSeries {
                            Title = "モータ2温度",
                            Values =  new ChartValues<MeasureModel> {
                                new MeasureModel { Minutes = 660, Value = 57.0 },
                                new MeasureModel { Minutes = 670, Value = 57.1 },
                                new MeasureModel { Minutes = 680, Value = 57.2 },
                                new MeasureModel { Minutes = 690, Value = 57.3 },
                                new MeasureModel { Minutes = 700, Value = 57.4 },
                                new MeasureModel { Minutes = 710, Value = 57.5 },
                                new MeasureModel { Minutes = 720, Value = 57.6 },
                                new MeasureModel { Minutes = 730, Value = 57.7 },
                                new MeasureModel { Minutes = 740, Value = 57.0 },
                                new MeasureModel { Minutes = 750, Value = 57.2 },
                                new MeasureModel { Minutes = 760, Value = 57.6 },
                                new MeasureModel { Minutes = 770, Value = 58.7 },
                                new MeasureModel { Minutes = 780, Value = 58.9 },
                                new MeasureModel { Minutes = 790, Value = 58.0 },
                                new MeasureModel { Minutes = 800, Value = 63.8 },
                                new MeasureModel { Minutes = 810, Value = 64.0 },
                                new MeasureModel { Minutes = 820, Value = 64.1 },
                                new MeasureModel { Minutes = 830, Value = 62.4 },
                                new MeasureModel { Minutes = 840, Value = 63.0 }
                            },
                            Fill = new SolidColorBrush(Colors.Transparent),
                            PointGeometry = DefaultGeometries.Triangle,
                            LineSmoothness = 0
                        }
                    };
                }
                return _series;
            }
            set { SetProperty(ref _series, value); }
        }
    }
}
