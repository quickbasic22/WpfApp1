using Caliburn.Micro;
using System.Windows;

namespace WpfApp1
{
    public class ShellViewModel : PropertyChangedBase
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyOfPropertyChange(() => Age);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}! you are {1} years old", Name, Age)); //Don't do this in real life :)
        }

        public void SubtractAge()
        {
            Age -= 10;
            MessageBox.Show(string.Format("{0} is now {1} years old", Name, Age));
        }
    }
}