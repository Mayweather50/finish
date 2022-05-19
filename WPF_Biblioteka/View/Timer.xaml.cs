using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPF_Biblioteka.ViewModel;


namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
      public System.Timers.Timer timer;
        int h, m, s, ms;
        public Timer()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;

           

        }

      

        private void  OnTimeEvent(object sender, ElapsedEventArgs e)
        {


            Dispatcher.Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }

                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }


                var text = Label.Content = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));

                try
                {
                    StreamWriter sw = new StreamWriter("C:/Users/myrta/OneDrive/Рабочий стол/TImer.txt");
                    sw.WriteLine("Ваше проведеное время:" + text);
                    sw.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }));


           




        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            Label.Content = "00:00:00:00";
        
        
        }

        private void Button_Start(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            timer.Stop();

        }
    }
}
