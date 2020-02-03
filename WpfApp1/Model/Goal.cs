using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace WpfTaskmanager
{
    public class Goal : INotifyPropertyChanged
    {
        string goalText;
        bool isChecked;

        public string GoalText
        {
            get { return goalText; }
            set
            {
                goalText = value;
                OnPropertyChanged("GoalText");
            }
        }
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        public Goal() { }

        public Goal(string text, bool isChecked)
        {
            this.goalText = text;
            this.isChecked = isChecked;
        }

        public override string ToString()
        {
            return $"{GoalText}\n{IsChecked}";
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
