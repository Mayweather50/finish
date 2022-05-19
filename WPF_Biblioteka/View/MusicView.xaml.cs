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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для MusicView.xaml
    /// </summary>
    public partial class MusicView : System.Windows.Controls.UserControl
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MusicView()
        {
            InitializeComponent();
        }

        private void Button_Open(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/David Guetta feat. Akon - Sexy Bitch (feat. Akon).mp3");


            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            //if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    mediaPlayer.Open(new Uri(openFileDialog.FileName));
            //    mediaPlayer.Play();
            //}

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/David Guetta feat. Akon - Sexy Bitch (feat. Akon).mp3");


        }
    }
}
