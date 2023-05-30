using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title="iPhone 7", Company="Apple", Price=56000, Year=2012 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000, Year=2012 },
                new Phone {Title="Elite x3", Company="HP", Price=56000, Year=2013 },
                new Phone {Title="Mi5S", Company="Xiaomi", Price=35000, Year=2015 },
                new Phone {Title="Nord 2", Company="OnePlus", Price=26000, Year=2019},
                new Phone {Title="Iphone 12 XS", Company="Apple", Price=96000, Year=2020}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
