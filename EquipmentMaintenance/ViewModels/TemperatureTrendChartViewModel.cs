using LiveCharts;
using LiveCharts.Configurations;
using Prism.Mvvm;
using System;
using System.Linq;

namespace EquipmentMaintenance.ViewModels
{
    public class TemperatureTrendChartViewModel : BindableBase
    {
        private DateTime _date;
        public TemperatureTrendChartViewModel()
        {
            _date = new DateTime(2017, 1, 1, 11, 0, 0);
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
        

        //the values property will store our values array
        private ChartValues<MeasureModel> _series1;
        public ChartValues<MeasureModel> Series1
        {
            get
            {
                if (_series1 == null)
                {
                    _series1 = new ChartValues<MeasureModel> {
                        new MeasureModel { DateTime = _date.AddMinutes(000), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(010), Value = 20010 },
                        new MeasureModel { DateTime = _date.AddMinutes(020), Value = 20100 },
                        new MeasureModel { DateTime = _date.AddMinutes(030), Value = 19832 },
                        new MeasureModel { DateTime = _date.AddMinutes(040), Value = 19820 },
                        new MeasureModel { DateTime = _date.AddMinutes(050), Value = 22000 },
                        new MeasureModel { DateTime = _date.AddMinutes(060), Value = 19300 },
                        new MeasureModel { DateTime = _date.AddMinutes(070), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(080), Value = 18300 },
                        new MeasureModel { DateTime = _date.AddMinutes(090), Value = 23030 },
                        new MeasureModel { DateTime = _date.AddMinutes(100), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(110), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(120), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(130), Value = 42400 },
                        new MeasureModel { DateTime = _date.AddMinutes(140), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(150), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(160), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(170), Value = 20000 },
                        new MeasureModel { DateTime = _date.AddMinutes(180), Value = 20000 }
                    };
                }
                return _series1;
            }
            set { SetProperty(ref _series1, value); }
        }

        //the values property will store our values array
        private ChartValues<MeasureModel> _series2;
        public ChartValues<MeasureModel> Series2
        {
            get
            {
                if (_series2 == null)
                {
                    _series2 = new ChartValues<MeasureModel> {
                        new MeasureModel { DateTime = _date.AddMinutes(000), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(010), Value = 15500 },
                        new MeasureModel { DateTime = _date.AddMinutes(020), Value = 15100 },
                        new MeasureModel { DateTime = _date.AddMinutes(030), Value = 15300 },
                        new MeasureModel { DateTime = _date.AddMinutes(040), Value = 15200 },
                        new MeasureModel { DateTime = _date.AddMinutes(050), Value = 14000 },
                        new MeasureModel { DateTime = _date.AddMinutes(060), Value = 14300 },
                        new MeasureModel { DateTime = _date.AddMinutes(070), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(080), Value = 15200 },
                        new MeasureModel { DateTime = _date.AddMinutes(090), Value = 14900 },
                        new MeasureModel { DateTime = _date.AddMinutes(100), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(110), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(120), Value = 14900 },
                        new MeasureModel { DateTime = _date.AddMinutes(130), Value = 15100 },
                        new MeasureModel { DateTime = _date.AddMinutes(140), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(150), Value = 26000 },
                        new MeasureModel { DateTime = _date.AddMinutes(160), Value = 18500 },
                        new MeasureModel { DateTime = _date.AddMinutes(170), Value = 15000 },
                        new MeasureModel { DateTime = _date.AddMinutes(180), Value = 15000 }
                    };
                }
                return _series2;
            }
            set { SetProperty(ref _series2, value); }
        }

        //lets set how to display the X Labels
        public Func<double, string> DateTimeFormatter { get; set; } = value => new DateTime((long)(value)).ToString("HH:mm");

        private double _axisXStep = 5000;
        public double AxisXStep
        {
            get
            {
                return _axisXStep;
            }
            set { SetProperty(ref _axisXStep, value); }
        }

        private double _axisXMax = 0;
        public double AxisXMax
        {
            get
            {
                if (_axisXMax == 0)
                {
                    //_axisXMax = this.Series1.Max(t => t.DateTime.TimeOfDay.Ticks);
                }
                return _axisXMax;
            }
            set { SetProperty(ref _axisXMax, value); }
        }

        private double _axisXMin = 0;
        public double AxisXMin
        {
            get
            {
                if (_axisXMin == 0)
                {
                    //_axisXMin = this.Series1.Min(t => t.DateTime.TimeOfDay.Ticks);
                }
                return _axisXMin;
            }
            set { SetProperty(ref _axisXMin, value); }
        }

        private double _axisYStep = 10;
        public double AxisYStep
        {
            get
            {
                return _axisYStep;
            }
            set { SetProperty(ref _axisYStep, value); }
        }

        private double _axisYMax = 0;
        public double AxisYMax
        {
            get
            {
                if (_axisYMax == 0)
                {
                    //_axisYMax = this.Series1.Max(v => v.Value);
                }
                return _axisYMax;
            }
            set { SetProperty(ref _axisYMax, value); }
        }

        private double _axisYMin = 0;
        public double AxisYMin
        {
            get
            {
                if (_axisYMin == 0)
                {
                    //_axisYMin = this.Series1.Min(v => v.Value);
                }
                return _axisYMin;
            }
            set { SetProperty(ref _axisYMin, value); }
        }
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
