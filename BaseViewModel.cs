using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TabControlzEXExample
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public BrowserTabTypes BrowserTabType { get; set; }

        public enum BrowserTabTypes
        {
            MainWPFTabBrowser,
            OtherBrowser
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
