using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WPF_Biblioteka.Model;

namespace WPF_Biblioteka.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource HomeItemsCollection;
        public ICollectionView HomeSourceCollection => HomeItemsCollection.View;

        public HomeViewModel()
        {           
            ObservableCollection<HomeItems> homeItems = new ObservableCollection<HomeItems>
            {
                new HomeItems { HomeName = "Выберете курсор", HomeImage = @"Assets/marvel-carnage.png" },               
            };

            HomeItemsCollection = new CollectionViewSource { Source = homeItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

}