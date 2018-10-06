using BaseLib.ConfigPack.GeneralConfig;
using BaseUIUtility.ViewModels.GeneralViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBasics.TabManager;

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel MainWindowViewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            InitailizeTabComponent(); ;
            this.DataContext = MainWindowViewModel;
        }

        private void InitailizeTabComponent()
        {
            try
            {
                MainWindowViewModel.ListTabItemTemplate.Add(new TabItemTemplate()
                {
                    Header ="Part-1",
                    LazyUserControl = new Lazy<UserControl>(()=> Part1_TabManager.GetSingletonObj()),
                });
            }
            catch(Exception ex)
            {
                ex.ErrorLog();
            }
        }
    }
}
