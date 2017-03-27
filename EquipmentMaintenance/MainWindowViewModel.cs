using Prism.Mvvm;
using System.Collections.Generic;
using System;

namespace EquipmentMaintenance
{
    public class MainWindowViewModel : BindableBase
    {
        public EquipmentDetailViewModel EquipmentDetail { get; private set; }
        public EquipmentViewModel Equipment { get; private set; }

        public MainWindowViewModel(
            EquipmentDetailViewModel equipmentDetail,
            EquipmentViewModel equipment)
        {
            Equipment = equipment;
            Equipment.DetailClick += GoToDetail;

            EquipmentDetail = equipmentDetail;
            EquipmentDetail.CloseEvent += DetailClose;

            this.IsEquipmentVisible = true;
        }

        private bool _isEquipmentVisible;
        public bool IsEquipmentVisible
        {
            get { return _isEquipmentVisible; }
            set
            {
                SetProperty(ref _isEquipmentVisible, value);
                this.IsEquipmentDetailVisible = !value;
            }
        }

        private bool _isEquipmentDetailVisible = true;
        public bool IsEquipmentDetailVisible
        {
            get { return _isEquipmentDetailVisible; }
            set { SetProperty(ref _isEquipmentDetailVisible, value); }
        }

        private void DetailClose(object sender, EventArgs e)
        {
            var equipmentDetail = (sender as EquipmentDetailViewModel);
            this.IsEquipmentVisible = true;
        }

        private void GoToDetail(object sender, EventArgs e)
        {
            var equipment = (sender as EquipmentViewModel);
            this.IsEquipmentVisible = false;
        }

        public List<MaintenanceCheckItem> CheckList { get { return _checkList; } }

        private List<MaintenanceCheckItem> _checkList = new List<MaintenanceCheckItem> {
            new MaintenanceCheckItem {
                No = 1,
                Pro1 = "電源電圧",
                Pro2 = "通電時の電圧を確認して下さい。",
                Pro3 = true,
                Pro4 = false,
            },
            new MaintenanceCheckItem {
                No = 2,
                Pro1 = "電源ランプ",
                Pro2 = "通電による電源ランプの点灯切替を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            },
            new MaintenanceCheckItem {
                No = 3,
                Pro1 = "扉センサ1",
                Pro2 = "前面右扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = true,
                Pro4 = false
            },
            new MaintenanceCheckItem {
                No = 4,
                Pro1 = "扉センサ2",
                Pro2 = "前面左扉の開放によるランプ点灯を確認して下さい。",
                Pro3 = false,
                Pro4 = true
            },
            new MaintenanceCheckItem { No = 5, Pro1 = ":", Pro2 = ":", Pro3 = false, Pro4 = false }
        };
    }
}
