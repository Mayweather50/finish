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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    /// 

    public partial class HomeView : UserControl
    {
        Cursor Fiery, FieryHand;

        public bool Fire;
        public HomeView()
        {
            InitializeComponent();

            if (Fire)
            {
                string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
                Fiery = new Cursor($"{cursorDirectory}\\cursor-fire.cur");
                FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
                this.Cursor = Fiery;
            }
            
      



        }

        private void Cursor_Click(object sender, RoutedEventArgs e)
        {
            Fire = true;
            string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
            Fiery = new Cursor($"{cursorDirectory}\\cursor_2.cur");
            FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
            this.Cursor = Fiery;

        }

        private void Fire_Click(object sender, RoutedEventArgs e)
        {
            Fire = true;

            string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
            Fiery = new Cursor($"{cursorDirectory}\\cursor-fire.cur");
            FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
            this.Cursor = Fiery;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Fire = true;

            string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
            Fiery = new Cursor($"{cursorDirectory}\\cursor.cur");
            FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
            this.Cursor = Fiery;
        }
    }
}
