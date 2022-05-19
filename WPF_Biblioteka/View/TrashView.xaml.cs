using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для TrashView.xaml
    /// </summary>
    public partial class TrashView : UserControl
    {
        public TrashView()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/OneDrive/Рабочий стол/TImer.txt");
        }
    }
}
