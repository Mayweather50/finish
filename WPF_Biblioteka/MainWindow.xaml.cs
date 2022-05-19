using WPF_Biblioteka.View;
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
using WPF_Biblioteka.ViewModel;
using System.Diagnostics;
using System.Windows.Media.Animation;
using System.IO;
using LiveCharts.Wpf;
using LiveCharts;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cursor Fiery, FieryHand;

        public object Track_One { get; internal set; }
        public object SubmenuOne_UC { get; internal set; }

        public MainWindow()
        {

            HomeView home = new HomeView();

          



            InitializeComponent();
            //Main.Content = new Book();
            if (home.Fire == true) 
            {
                string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
                Fiery = new Cursor($"{cursorDirectory}\\cursor-fire.cur");
                FieryHand = new Cursor($"{cursorDirectory}\\cursores.cur");
                this.Cursor = Fiery;

            }



        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();



        }

        private void ChangeWindowState()
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                Window_Edge.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (WindowState == WindowState.Maximized) 
                {
                    this.WindowState = WindowState.Normal;
                    Window_Edge.Visibility = Visibility.Visible;

                }
            }
        }

        private void Main_Window_Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                ChangeWindowState();
            }

            //// Close All Open Menu Panels on Mouse Button Click
            //if (e.ChangedButton == MouseButton.Left && e.ClickCount == 1)
            //{
            //    //// Access the SubmenuOne UserControl Account Btn and Unselect it. 
            //    //if (Application.Current.MainWindow is MainWindow MW)
            //    //{
            //    //    MW.SubmenuOne_UC.account_btn.IsSelected = false;
            //    //}

            //    //// Access the MainMenu UserControl Menu Toggle Btn and Uncheck it. 
            //    //if (Application.Current.MainWindow is MainWindow MW1)
            //    //{
            //    //    MW1.MainMenu_UC.Menu_ToggleButton.IsChecked = false;
            //    //}

            //    //// Access the SidePanel UserControl Mail Btn and Unselect it. 
            //    //if (Application.Current.MainWindow is MainWindow MW2)
            //    //{
            //    //    MW2.MainMenu_UC.SidePanel_UC.mail_sidepanel_listboxitem.IsSelected = false;
            //    //}

            //}
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
          

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Autorize autorize = new Autorize();
            autorize.Show();

            //Window1 window1 = new Window1();
            //window1.Show();

        }  

        
        
        private void Button_Click_Books(object sender, RoutedEventArgs e)
        {
            Main.Content = new Book();
         
        }

        private void Button_Click_Audio(object sender, RoutedEventArgs e)
        {
          

        }
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Main.Content = new CursorViewModel();

        }

        private void minimizeButton_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Button_Sapiens(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");
 

        }
        private void Button_Fahrenheit(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");
         

        }  
        
        private void Button_Beda(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");
            

        }
    }
}
