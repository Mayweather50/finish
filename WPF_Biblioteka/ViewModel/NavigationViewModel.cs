using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using WPF_Biblioteka;
using WPF_Biblioteka.Model;
using WPF_Biblioteka.View;

namespace WPF_Biblioteka.ViewModel
{
    class NavigationViewModel : INotifyPropertyChanged
    {
     
        private CollectionViewSource MenuItemsCollection;

        public ICollectionView SourceCollection => MenuItemsCollection.View;

        public NavigationViewModel()
        {
        
            ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems { MenuName = "Services", MenuImage = @"Assets/ba.png" },
                new MenuItems { MenuName = "Desktop", MenuImage = @"Assets/Desktop_Icon.png" },
                new MenuItems { MenuName = "Home", MenuImage = @"Assets/Home_Icon.png" },
                new MenuItems { MenuName = "Downloads", MenuImage = @"Assets/Download_Icon.png" },
                new MenuItems { MenuName = "Pictures", MenuImage = @"Assets/Images_Icon.png" },
                new MenuItems { MenuName = "Music", MenuImage = @"Assets/Music_Icon.png" },
                new MenuItems { MenuName = "Movies", MenuImage = @"Assets/Movies_Icon.png" },
                new MenuItems { MenuName = "Report", MenuImage = @"Assets/Document_Icon.png" }
            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };
            MenuItemsCollection.Filter += MenuItems_Filter;

            SelectedViewModel = new StartupViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                MenuItemsCollection.View.Refresh();
                OnPropertyChanged("FilterText");
            }
        }
       
        private void MenuItems_Filter(object sender, FilterEventArgs e)
        {
            if(string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            MenuItems _item = e.Item as MenuItems;
            if(_item.MenuName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public void SwitchViews(object parameter)
        {
         
            switch(parameter)
            {
                //case "Home":
                //    SelectedViewModel = new HomeViewModel();
                //    break;
                case "Desktop":
                    SelectedViewModel = new DesktopViewModel();
                    break;
                case "Home":
                    SelectedViewModel = new DocumentViewModel();
                    break;
                case "Downloads":
                    SelectedViewModel = new DownloadViewModel();
                    break;
                case "Pictures":
                    SelectedViewModel = new PictureViewModel();
                    break;
                case "Music":
                    SelectedViewModel = new MusicViewModel();
                    break;
                case "Movies":
                    SelectedViewModel = new MovieViewModel();
                    break;
                case "Report":
                    SelectedViewModel = new TrashViewModel();
                    break;
                default:
                    SelectedViewModel = new HomeViewModel();
                    break;
            }
        }

        private ICommand _menucommand;
        public ICommand MenuCommand
        {
            get
            {
                if (_menucommand == null)
                {
                    _menucommand = new RelayCommand(param => SwitchViews(param));
                }
                return _menucommand;
            }
        }

        public void PCView()
        {
            SelectedViewModel = new PCViewModel();
        }

        private ICommand _pccommand;
        public ICommand ThisPCCommand
        {
            get
            {
                if (_pccommand == null)
                {
                    _pccommand = new RelayCommand(param => PCView());
                }
                return _pccommand;
            }
        }


        public void Cursor()
        {
            SelectedViewModel = new CursorViewModel();
        }

        private ICommand _curcommand;
        public ICommand CursorCommand
        {
            get
            {
                if (_curcommand == null)
                {
                    _curcommand = new RelayCommand(param => Cursor());
                }
                return _curcommand;
            }
        }




        private void ShowHome()
        {
            SelectedViewModel = new HomeViewModel();
        }

        private ICommand _backHomeCommand;
        public ICommand BackHomeCommand
        {
            get
            {
                if (_backHomeCommand == null)
                {
                    _backHomeCommand = new RelayCommand(p => ShowHome());
                }
                return _backHomeCommand;
            }
        }

   
        public void CloseApp(object obj)
        {
            if (obj != null)
            {
                MainWindow win = obj as MainWindow;
                win.Close();
            }
        }

      
        private ICommand _closeCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }
       
    }
}
