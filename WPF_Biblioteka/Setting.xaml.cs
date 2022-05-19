using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Audio.xaml
    /// </summary>
    public partial class Audio : Window
    {
        Cursor Fiery, FieryHand;

        private void Button_Closed(object sender, RoutedEventArgs e) => Close();
       

        public Audio()
        {
            InitializeComponent();
            string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
            Fiery = new Cursor($"{cursorDirectory}\\cursor_3.cur");
            FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
            this.Cursor = Fiery;
        }
    }
}
