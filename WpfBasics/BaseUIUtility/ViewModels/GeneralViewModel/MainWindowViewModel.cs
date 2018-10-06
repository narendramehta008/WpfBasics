using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUIUtility.ViewModels.GeneralViewModel
{
    
    public class MainWindowViewModel : BindingObject
    {
        private ObservableCollection<TabItemTemplate> _ListTabItemTemplate = new ObservableCollection<TabItemTemplate>();

        public ObservableCollection<TabItemTemplate> ListTabItemTemplate
        {
            get { return _ListTabItemTemplate; }
            set { SetProperty(ref _ListTabItemTemplate, value); }
        }

    }
}
