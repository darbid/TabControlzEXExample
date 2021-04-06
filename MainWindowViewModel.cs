using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TabControlzEXExample
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        
        private ObservableCollection<BaseViewModel> _TabCollection;
        public ObservableCollection<BaseViewModel> TabCollection
        {
            get { return _TabCollection ??= new ObservableCollection<BaseViewModel>(); }

            set
            {
                _TabCollection = value;
                NotifyPropertyChanged();
            }
        }

        private int _BrowserTabControlSelectedIndex = 0;
        public int BrowserTabControlSelectedIndex
        {
            get { return _BrowserTabControlSelectedIndex; }
            set
            {
                _BrowserTabControlSelectedIndex = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            BrowserTabItemViewModel btivm = new();
            btivm.BrowserTabType = BaseViewModel.BrowserTabTypes.MainWPFTabBrowser;
            
            TabCollection.Add(btivm);

            this.BrowserTabControlSelectedIndex = 0;


        }

        #region "Notify Property Changed"
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion //"Notify Property Changed"
    }
}
