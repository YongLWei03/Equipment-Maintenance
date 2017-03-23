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
        }

        private ICommand _graph1Command;
        public ICommand Graph1Command
        {
            get
            {
                if (_graph1Command == null)
                {
                    _graph1Command = new DelegateCommand(() => {
                        //_navigationService.GoBack();
                    });
                }
                return _graph1Command;
            }
        }

        private ICommand _graph2Command;
        public ICommand Graph2Command
        {
            get
            {
                if (_graph2Command == null)
                {
                    _graph2Command = new DelegateCommand(() => {
                        //_navigationService.GoBack();
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
                        //_navigationService.GoBack();
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
                Pro2 = "通電時の電圧を確認して下さい。"
            },
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "通電による電源ランプの点灯切替を確認して下さい。"
            },
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "前面右扉の開放によるランプ点灯を確認して下さい。"
            },
            new EquipmentNote {
                Pro1 = DateTime.Now,
                Pro2 = "前面左扉の開放によるランプ点灯を確認して下さい。"
            },
            new EquipmentNote { Pro2 = ":" }
        };
    }
}
