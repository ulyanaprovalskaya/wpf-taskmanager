using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfTaskmanager
{
    public abstract class Task : INotifyPropertyChanged
    {
        string text;
        string topic;
        string creationDate;

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public string Topic
        {
            get { return topic; }
            set
            {
                topic = value;
                OnPropertyChanged("Topic");
            }
        }

        public string CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
