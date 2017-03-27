using Microsoft.Practices.ServiceLocation;

namespace EquipmentMaintenance
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }
    }
}
