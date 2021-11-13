using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfAppInterfacenotifychanged
{
    internal class Sum : INotifyPropertyChanged
    {

        private string num1;
        private string num2;
        private string result;

        public int Num1 
        { get 
            {
                return Num1;
            }
            set 
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                OnPropertyChanged("Num1");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;


        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
               PropertyChanged(this, new PropertyChangedEventArgs(property));        
            }
        }
    }
}
