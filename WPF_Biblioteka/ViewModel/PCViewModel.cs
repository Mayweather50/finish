
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WPF_Biblioteka.Model;

namespace WPF_Biblioteka.ViewModel
{
    public class PCViewModel : INotifyPropertyChanged
    {
        private readonly CollectionViewSource PCItemsCollection;
        public ICollectionView PCSourceCollection => PCItemsCollection.View;

        public PCViewModel()
        {
            ObservableCollection<PCItems> pcItems = new ObservableCollection<PCItems>
            {
                new PCItems { PCName = "Carnage", PCImage = @"Assets/marvel-carnage.png" },
                //new PCItems { PCName = "Iron Man", PCImage = @"Assets/iron_man.png" },
                //new PCItems { PCName = "Space", PCImage = @"Assets/cursors.png" },
                //new PCItems { PCName = "Slime", PCImage = @"Assets/sliz.png" }

            };

            PCItemsCollection = new CollectionViewSource { Source = pcItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
