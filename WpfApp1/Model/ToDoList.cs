using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfTaskmanager
{
    public class ToDoList : Task
    {
        ObservableCollection<Goal> goals = new ObservableCollection<Goal>();

        public ObservableCollection<Goal> Goals { get => goals; set => goals = value; }

        public ToDoList() { }

        public ToDoList(string text)
        {
            this.Text = text;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(Topic);
            foreach(var g in Goals)
            {
                result.AppendFormat(g.GoalText);
            }
            return result.ToString();
        }

    }
}
