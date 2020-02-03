using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfTaskmanager
{
    public class TaskManager
    {
        ObservableCollection<Note> notes;
        ObservableCollection<ToDoList> lists;
        ObservableCollection<Reminder> reminders;

        public ObservableCollection<Note> Notes { get => notes; set => notes = value; }
        public ObservableCollection<ToDoList> Lists { get => lists; set => lists = value; }
        public ObservableCollection<Reminder> Reminders { get => reminders; set => reminders = value; }


        public static ObservableCollection<Note> Search(ObservableCollection<Note> notes, string strToSearch)
        {
            ObservableCollection<Note> suitableNotes = new ObservableCollection<Note>();
            foreach (var n in notes)
            {
                string text = n.ToString().ToLower();
                if (text.IndexOf(strToSearch) != -1) suitableNotes.Add(n);
            }
            if (strToSearch == "") suitableNotes.Clear();
            return suitableNotes;
        }

        public static ObservableCollection<Reminder> Search(ObservableCollection<Reminder> reminders, string strToSearch)
        {
            ObservableCollection<Reminder> suitableReminders = new ObservableCollection<Reminder>();
            foreach (var r in reminders)
            {
                string text = r.ToString().ToLower();
                if (text.IndexOf(strToSearch) != -1) suitableReminders.Add(r);
            }
            if (strToSearch == "") suitableReminders.Clear();
            return suitableReminders;
        }

        public static ObservableCollection<ToDoList> Search(ObservableCollection<ToDoList> lists, string strToSearch)
        {
            ObservableCollection<ToDoList> suitableLists = new ObservableCollection<ToDoList>();
            foreach (var l in lists)
            {
                string text = l.ToString().ToLower();
                if (text.IndexOf(strToSearch) != -1) suitableLists.Add(l);
            }
            if (strToSearch == "") suitableLists.Clear();
            return suitableLists;
        }

        public TaskManager(ObservableCollection<Note> notes)
        {
            this.Notes = notes;
        }

        public TaskManager(ObservableCollection<Note> notes, ObservableCollection<Reminder> reminders, ObservableCollection<ToDoList> lists)
        {
            this.Notes = notes;
            this.Reminders = reminders;
            this.Lists = lists;
        }

        public override string ToString()
        {
            StringBuilder result = null;
            foreach (var n in Notes)
            {
                result.AppendFormat(n.ToString() + "\n");
            }
            result.AppendFormat("\n");
            foreach (var r in Reminders)
            {
                result.AppendFormat(r.ToString() + "\n");
            }
            result.AppendFormat("\n");
            foreach (var l in Lists)
            {
                result.AppendFormat(l.ToString() + "\n");
            }
            return result.ToString();
        }
    }
}
