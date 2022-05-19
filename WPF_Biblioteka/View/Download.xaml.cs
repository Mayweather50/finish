using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using TechTalk.SpecFlow.Analytics.UserId;
using WPF_Biblioteka.CustomControl;
using DataFormats = System.Windows.Forms.DataFormats;

namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

     
        private void Rectangle_Drop(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = System.IO.Path.GetFileName(files[0]);
                for (int i = 0; i < files.Length; i++)
                {
                   
                    FileInfo fileInfo = new FileInfo(files[i]);
                    UploadingFilesList.Items.Add(new fileDetail()
                    {
                        FileName = fileName,
                        FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100

                    });

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            if (openFileDialog.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    var path = String.Format("{0}\\{1}\\{2}", AppDomain.CurrentDomain.BaseDirectory, "Files", filename);
                    TextWriter textWriter = new StreamWriter(path);
                    UploadingFilesList.Items.Add(new fileDetail()
                    {
                        FileName = filename,
                        FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"),"Mb"),
                        UploadProgress=100

                    });

                }
            }

            //  OpenFileDialog fileDialog = new OpenFileDialog();
            //  fileDialog.DefaultExt = ".pdf"; // Required file extension 
            ////  fileDialog.Filter = "Text documents (.txt)|*.txt"; // Optional file extensions

            //  fileDialog.ShowDialog();
        }
    }
}
