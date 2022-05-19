using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Data;
using System.Collections.ObjectModel;
using WPF_Biblioteka.Model;

namespace WPF_Biblioteka.ViewModel
{
    public class CursorViewModel: INotifyPropertyChanged
    {
        private readonly CollectionViewSource CursortemsCollection;
        public ICollectionView CursorSourceCollections => CursortemsCollection.View;

        public CursorViewModel()
        {
            ObservableCollection<CursorItems> pcItems = new ObservableCollection<CursorItems>
            {
                new CursorItems { CursorName = "Local Disk (C:)", CursorImage = @"Assets/drive_icon.png" },
                new CursorItems { CursorName = "Local Disk (D:)", CursorImage = @"Assets/drive_icon.png" },
                new CursorItems { CursorName = "Local Disk (E:)", CursorImage = @"Assets/alarm_icon.png" },
                new CursorItems { CursorName = "Local Disk (F:)", CursorImage = @"Assets/angular_icon.png" }

            };

            CursortemsCollection = new CollectionViewSource { Source = pcItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }










        //static void Maindd(string[] args)
        //{
        //    string exeDirectory = Path.GetDirectoryName(
        //        System.Reflection.Assembly.GetEntryAssembly().Location);
        //    string remoteUri = @"C:\Users\myrta\Downloads\Язык программирования C# 7 и платформы .NET и .NET Core, 8-е изд. Эндрю Троелсен, Филипп Джепикс.pdf";
        //    string fileName = "ms-banner.gif", myStringWebResource = null;
        //    // Create a new WebClient instance.
        //    WebClient myWebClient = new WebClient();
        //    // Concatenate the domain with the Web resource filename.
        //    myStringWebResource = remoteUri + fileName;
        //    Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
        //    // Download the Web resource and save it into the current filesystem folder.
        //    myWebClient.DownloadFile(myStringWebResource, fileName);
        //    Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
        //   // Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.Pdf);

        //}


    }
}
