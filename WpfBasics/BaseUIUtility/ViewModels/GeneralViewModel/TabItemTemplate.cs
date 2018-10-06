using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BaseUIUtility.ViewModels.GeneralViewModel
{
   public class TabItemTemplate
    {
        public string Header { get; set; } = string.Empty;
        public Visibility Visibility { get; set; } = Visibility.Visible;
        public Lazy<UserControl> LazyUserControl { get; set; }
    }
}
