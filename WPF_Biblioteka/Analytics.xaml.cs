using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
       
        public Users()
        {
            InitializeComponent();
            this.PieChart();
            this.Cartesian();

         

        }

        public void Cartesian()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Ventas",Values=new ChartValues<double>{400,600,500,500},
                    PointGeometry=null

                },
                new LineSeries
                {
                    Title="Production",Values=new ChartValues<double>{400,200,300,600},
                   PointGeometry=null
                    
                },
                new LineSeries
                {
                    Title="Production",Values=new ChartValues<double>{400,200,300,600},
                    PointGeometry=DefaultGeometries.Square,
                    PointGeometrySize=15
                    
                },
            };

            Labels = new[] { "1", "2", "3", "4" };
            yFormatter = value => value.ToString("C");

            SeriesCollection.Add(new LineSeries {

                Title = "Company", Values = new
                ChartValues<double> { 5, 3, 9 },
                LineSmoothness = 0,
                PointGeometry=Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize=20,
                PointForeground=Brushes.Gray

            });
            SeriesCollection[3].Values.Add(5d);
            DataContext = this;
        }


        public Func<double, string> yFormatter { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }



        //private void btnOpen_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();
        //    op.Title = "Select a picture";
        //    op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
        //      "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
        //      "Portable Network Graphic (*.png)|*.png";
        //    //if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    //{
        //    //       imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
        //    //}
        //}


        //SqlConnection sqlConnection;


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    sqlConnection = new SqlConnection("Data Source=DESKTOP-ER355JS;Initial Catalog=Download;Integrated Security=True");
        //    sqlConnection.Open();

        //    byte[] image = null;


        //}


        //private byte[] _imageBytes = null;

        //// Browse for an image on your computer
        //private void BrowseButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    var dialog = new OpenFileDialog
        //    {
        //        CheckFileExists = true,
        //        Multiselect = false,
        //        Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
        //    };

            //    if (dialog.ShowDialog() != true) { return; }

            //    ImagePath.Text = dialog.FileName;
            //    MyImage.Source = new BitmapImage(new Uri(lImagePath.Text));

            //    using (var fs = new FileStream(ImagePath.Text, FileMode.Open, FileAccess.Read))
            //    {
            //        _imageBytes = new byte[fs.Length];
            //        fs.Read(imgBytes, 0, System.Convert.ToInt32(fs.Length));
            //    }
            //}

            // Save the selected image to your database
            //private void SaveButton_OnClick(object sender, RoutedEventArgs e)
            //{
            //    if (!String.IsNullOrEmpty(ImagePath.Text))
            //    {
            //        var db = new MyDataContext();
            //        var uploadedImg = new UploadedImage
            //        {
            //            ImageID = 0,
            //            ImageContent = _imageBytes,
            //            ImageName = ImagePath.Text
            //        };

            //        db.UploadedImages.InsertOnSubmit(uploadedImg);
            //        db.SubmitChanges();
            //    }
            //}

            //// Load an image from the database
            //private void LoadButton_OnClick(object sender, RoutedEventArgs e)
            //{
            //    // Load 1 image from the database and display it
            //    var db = new ImageInDatabaseDataContext();
            //    var img = (from el in db.UploadedImages
            //               select el).FirstOrDefault();


            //    if (img != null)
            //    {
            //        // Display the loaded image
            //        ImageFile.Source = new BitmapImage(new Uri(img.ImageName));
            //    }
            //}
        //}

        public Func<ChartPoint, string> PointLabel { get; set; }
        public void PieChart()
        {
            PointLabel = ChartPoint => string.Format("{0}({1:p})", ChartPoint.Y, ChartPoint.Participation);
            DataContext = this;

           

        }


        private void PieChart_DataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;
            foreach (PieSeries pieSeries in chart.Series)
            {
                pieSeries.PushOut = 0;

                var seleccionarSeries = (PieSeries)chartpoint.SeriesView;
                seleccionarSeries.PushOut = 8;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) => Close();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PieSeries pieSeries = new PieSeries();
            

        }
    }
}
