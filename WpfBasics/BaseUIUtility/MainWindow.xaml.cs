using BaseLib.ConfigPack.GeneralConfig;
using ConfigPack.BaseLib.LogConfig;
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

namespace BaseUIUtility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public InfoLogger InfoLogger { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeValues();
            
        }

        private void InitializeValues()
        {
            try
            {
                InfoLogger += AddToUILogger;
            }
            catch(Exception ex)
            {
                ex.ErrorLog();
            }
        }

        public void AddToUILogger(string message)
        {
            try
            {
                string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss \t");
                ListViewLogger.Dispatcher.Invoke(new Action(delegate 
                {
                    ListViewLogger.Items.Insert(0, $"{message}");
                }));
            }catch(Exception ex)
            {
                ex.ErrorLog();
            }
        }
    }

}
