using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client
{
    public class ViewModelApp : INotifyPropertyChanged
    {
        private string currentPage;

        public string CurrentPage
        {
            get { return this.currentPage; }
            set
            {
                this.currentPage = value;
                OnNotifyPropertyChange("currentPage");
            }
        }

        

        public ViewModelApp()
        {
            this.CurrentPage = "/Client;component/Views/Vols.xaml";
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChange(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, args);
        }

        protected void OnNotifyPropertyChange(string propertyName)
        {
            this.OnNotifyPropertyChange(new PropertyChangedEventArgs(propertyName));
        }
    }

}
