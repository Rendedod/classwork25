using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classwork25._1
{
    class Purchase: INotifyPropertyChanged
    {
        private string _name;
        private string _price;
        private string _count;

        public string Name
        {
            get { return _name; }
            set {
                if (_name == value)
                    return;
                _name = value;
                IsPropertyChanged("..");
            }
        }

        public string Price
        {
            get { return _price; }
            set {
                if (_price == value)
                    return;
                _price = value;
                IsPropertyChanged("..");
            }
        }

        public string Count
        {
            get { return _count; }
            set 
            {
                if (_count == value)
                    return;
                _count = value;
                IsPropertyChanged("..");

            }


        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void IsPropertyChanged(string obj = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(obj));
        }
    }
}
