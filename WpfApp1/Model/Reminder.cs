using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTaskmanager
{
    public class Reminder : Task
    {
        string date;

        public string Date { get { return date; } set { date = value; } }

        public Reminder() { }

        public Reminder(string text)
        {
            this.Text = text;
        }

        public override string ToString()
        {
            return $"{Topic}\n{Text}";
        }
    }
}
