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
using System.Data.SqlClient;
using System.Configuration;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Autorize.xaml
    /// </summary>
    public partial class Autorize : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Autorize()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.Write("some action...");


        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
               
                
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                    if (VerifyUser(txtUsername.Text, txtPassword.Password))
                    {
                        MessageBox.Show("Login Successfully", "Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
                        Profile profile = new Profile();
                        profile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный Логин или Пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


                    }



            
          

         
         

      


        }
        private bool VerifyUser(string username, string password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from Users where username='" + username + "' and password='" + password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        private void btnExit_Click(object sender, RoutedEventArgs e) => Close();
        
            //Application.Current.Shutdown();

        

    }
}
