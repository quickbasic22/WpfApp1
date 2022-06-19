using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public ObservableCollection<string> Items { get; set; }

        public App()
        {
            //Items = new ObservableCollection<string>
            //{
            //    "Dell Latitude",
            //    "Dell Inspiron",
            //    "IBM",
            //    "HP",
            //    "Asus"
            //};

            //Application.Current.Properties.Add("MyCollection", Items);
        }
    }
}
