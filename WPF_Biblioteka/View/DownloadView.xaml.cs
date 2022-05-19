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

namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для DownloadView.xaml
    /// </summary>
    public partial class DownloadView : UserControl
    {
        public DownloadView()
        {
            InitializeComponent();
        }

        private void Button_Download(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();

        }
    }
}
