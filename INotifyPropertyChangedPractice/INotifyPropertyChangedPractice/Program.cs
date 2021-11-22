using System;
using System.ComponentModel;

namespace INotifyPropertyChangedPractice
{
    internal class Program : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
