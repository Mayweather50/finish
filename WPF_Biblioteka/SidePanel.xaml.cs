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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для SidePanel.xaml
    /// </summary>
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        private void mail_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("SubmenuOne_Enter") as Storyboard;
            sb.Begin();


         

        }

        private void mail_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

          
        }

       
        

        private void settings_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            Audio audio = new Audio();
            audio.Show();
        }

        private void analytics_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void customer_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void dashboard_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("SubmenuOne_Enter") as Storyboard;
            sb.Begin();

        }

        private void dashboard_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

        }
    }
}
