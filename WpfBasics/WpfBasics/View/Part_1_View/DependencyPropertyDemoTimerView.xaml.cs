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
using System.Windows.Threading;

namespace WpfBasics.View.Part_1_View
{
    /// <summary>
    /// Interaction logic for DependencyPropertyDemoTimerView.xaml
    /// </summary>
    public partial class DependencyPropertyDemoTimerView : UserControl
    {
        public DependencyPropertyDemoTimerView()
        {
            InitializeComponent();
           // StartTimer();
        }

        private static DependencyPropertyDemoTimerView SingletonObj;

        public static DependencyPropertyDemoTimerView GetSingletonObj()
            => SingletonObj ?? (SingletonObj = new DependencyPropertyDemoTimerView());


        private void StartTimer()
        {
            try
            {
                int newValue = 0;
                DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal, delegate
                {
                    if (newValue == 100)
                        return;
                    else
                        newValue += 1;
                    SetValue(CounterProperty, newValue);
                },Dispatcher);
            }catch(Exception ex)
            {

            }
        }

        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TimerProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter", typeof(int), typeof(DependencyPropertyDemoTimerView), new PropertyMetadata(0));
    

    }
}
