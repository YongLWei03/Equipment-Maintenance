using Prism.Mvvm;
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
    }
}
