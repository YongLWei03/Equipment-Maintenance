using LiveCharts;
using LiveCharts.Configurations;
using Prism.Mvvm;
using System;

namespace EquipmentMaintenance.ViewModels
{
    public class TemperatureTrendChartViewModel : BindableBase
    {
        public TemperatureTrendChartViewModel()
        {

        }

        public void ChartMapper()
        {
            var mapper = Mappers.Xy<MeasureModel>()
                   .X(model => model.DateTime.ToString())   //use DateTime.Ticks as X
                   .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);
        }

        //the values property will store our values array
        private ChartValues<MeasureModel> _chartValues;
        public ChartValues<MeasureModel> ChartValues
        {
            get
            {
                if (_chartValues == null)
                {
                    _chartValues = new ChartValues<MeasureModel>();
                }
                return _chartValues;
            }
            set { SetProperty(ref _chartValues, value); }
        }

        //lets set how to display the X Labels
        public Func<double, string> DateTimeFormatter { get; set; } = value => new DateTime((long)(value)).ToString("mm:ss");

        private double _axisStep;
        public double AxisStep
        {
            get { return _axisStep; }
            set { SetProperty(ref _axisStep, value); }
        }

        private double _axisMax = 100;
        public double AxisMax
        {
            get { return _axisMax; }
            set { SetProperty(ref _axisMax, value); }
        }

        private double _axisMin = 60;
        public double AxisMin
        {
            get { return _axisMin; }
            set { SetProperty(ref _axisMin, value); }
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
