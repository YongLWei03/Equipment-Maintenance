using LiveCharts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace EquipmentMaintenance.ViewModels
{
    public class EquipmentDetailPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public TemperatureTrendChartViewModel TemperatureChart { get; private set; }
        public VibrationTrendChartViewModel VibrationChart { get; private set; }

        public EquipmentDetailPageViewModel(
            INavigationService navigationService,
            TemperatureTrendChartViewModel temperatureChart,
            VibrationTrendChartViewModel vibrationChart)
        {
            _navigationService = navigationService;

            TemperatureChart = temperatureChart;
            VibrationChart = vibrationChart;

            BuildVibrationChart();
        }

        private  Func<double, string> _yFormatter;
        public  Func<double, string> YFormatter
        {
            get { return _yFormatter; }
            set { SetProperty(ref _yFormatter, value); }
        }

        private  Func<double, string> _xFormatter;
        public  Func<double, string> XFormatter
        {
            get { return _xFormatter; }
            set { SetProperty(ref _xFormatter, value); }
        }

        private bool _isTemperChart;
        public bool IsTemperChart
        {
            get { return _isTemperChart; }
            set { SetProperty(ref _isTemperChart, value); }
        }

        private ICommand _graph1Command;
        public ICommand Graph1Command
        {
            get
            {
                if (_graph1Command == null)
                {
                    _graph1Command = new DelegateCommand(() =>
                    {
                        BuildVibrationChart();
                    });
                }
                return _graph1Command;
            }
        }

        private void BuildVibrationChart()
        {
            this.AxisXStep = VibrationChart.AxisXStep;
            this.AxisYStep = VibrationChart.AxisYStep;
            this.Series = VibrationChart.Series;
            this.YFormatter = VibrationChart.NumberFormatter;
            this.XFormatter = VibrationChart.DateTimeFormatter;
        }

        private ICommand _graph2Command;
        public ICommand Graph2Command
        {
            get
            {
                if (_graph2Command == null)
                {
                    _graph2Command = new DelegateCommand(() => {
                        this.AxisXStep = TemperatureChart.AxisXStep;
                        this.AxisYStep = TemperatureChart.AxisYStep;
                        this.MaxY = TemperatureChart.MaxY;
                        this.MinY = TemperatureChart.MinY;
                        this.Series = TemperatureChart.Series;
                        this.XFormatter = TemperatureChart.DateTimeFormatter;
                        this.YFormatter = TemperatureChart.TempurFormatter;
                    });
                }
                return _graph2Command;
            }
        }

        private ICommand _graph3Command;
        public ICommand Graph3Command
        {
            get
            {
                if (_graph3Command == null)
                {
                    _graph3Command = new DelegateCommand(() => {
                        this.AxisXStep = VibrationChart.AxisXStep;
                        this.AxisYStep = VibrationChart.AxisYStep;
                        this.MaxY = VibrationChart.MaxY;
                        this.MinY = VibrationChart.MinY;
                        this.Series = VibrationChart.Series;
                        this.YFormatter = VibrationChart.NumberFormatter;
                        this.XFormatter = VibrationChart.DateTimeFormatter;
                    });
                }
                return _graph3Command;
            }
        }

        private ICommand _backToListCommand;
        public ICommand BackToListCommand
        {
            get
            {
                if (_backToListCommand == null)
                {
                    _backToListCommand = new DelegateCommand(() => {
                        _navigationService.GoBack();
                    });
                }
                return _backToListCommand;
            }
        }

        private ICommand _closeCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new DelegateCommand(() => {
                        _navigationService.GoBack();
                    });
                }
                return _closeCommand;
            }
        }

        public List<EquipmentNote> Notes { get { return _notes; } }

        private List<EquipmentNote> _notes = new List<EquipmentNote> {
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "温度高"
            },
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "温度高"
            },
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "振動大"
            },
            //new EquipmentNote {
            //    Pro1 = DateTime.Now,
            //    Pro2 = "前面左扉の開放によるランプ点灯を確認して下さい。"
            //},
            //new EquipmentNote { Pro2 = ":" }
        };


        private double _axisYStep;
        public double AxisYStep
        {
            get { return _axisYStep; }
            set { SetProperty(ref _axisYStep, value); }
        }

        private double _maxY;
        public double MaxY
        {
            get { return _maxY; }
            set { SetProperty(ref _maxY, value); }
        }

        private double _minY;
        public double MinY
        {
            get { return _minY; }
            set { SetProperty(ref _minY, value); }
        }

        private double _axisXStep;
        public double AxisXStep
        {
            get { return _axisXStep; }
            set { SetProperty(ref _axisXStep, value); }
        }

        //the values property will store our values array
        private SeriesCollection _series;
        public SeriesCollection Series
        {
            get { return _series; }
            set { SetProperty(ref _series, value); }
        }
    }
}
