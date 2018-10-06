using BaseUIUtility.ConfigPackAhead.StringUtilsAhead;
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
using WpfBasics.View.Part_1_View;

namespace WpfBasics.TabManager
{
    /// <summary>
    /// Interaction logic for Part1_TabManager.xaml
    /// </summary>
    public partial class Part1_TabManager : UserControl
    {
        public Part1_TabManager()
        {
            InitializeComponent();
            InitializeTabs();
            //Part1TabControl
        }

        private static Part1_TabManager SingletonObj;

        public static Part1_TabManager GetSingletonObj()
            => SingletonObj ?? (SingletonObj = new Part1_TabManager());


        private void InitializeTabs()
        {
            try
            {
                List<TabItemTemplate> ListTabItemTemplate = new List<TabItemTemplate>()
                {
                    new TabItemTemplate()
                    {
                       Header = "DependencyPropertyDemoTimerView".GetResourceString()==null?"DependencyPropertyDemoTimerView":ResourceStringParser.GetResourceString("DependencyPropertyDemoTimerView"),
                       LazyUserControl = new Lazy<UserControl>(()=>DependencyPropertyDemoTimerView.GetSingletonObj()),
                    },
                    new TabItemTemplate()
                    {
                       Header = "StyleTriggersView".GetResourceString()??"StyleTriggersView",
                       LazyUserControl = new Lazy<UserControl>(()=>StyleTriggersView.GetSingletonObj()),
                    },
                    new TabItemTemplate()
                    {
                       Header = "TreeViewAndConvertors".GetResourceString()??"TreeViewAndConvertors",
                       LazyUserControl = new Lazy<UserControl>(()=>TreeViewAndConvertors.GetSingletonObj()),
                    }
                };
                Part1TabControl.ItemsSource = ListTabItemTemplate;

                string check = App.Current.FindResource("TreeViewAndConvertors").ToString(); 
            }
            catch(Exception ex)
            {

            }
        }
    }
}
