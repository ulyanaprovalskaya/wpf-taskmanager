using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Configuration;

namespace WpfTaskmanager
{
    class Reader
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        static ClientSettingsSection userSection = (ClientSettingsSection)config.GetSection("userSettings/WpfTaskmanager.Properties.Settings");

        static string notesPath = userSection.Settings.Get("NotesFilePath").Value.ValueXml.InnerText;
        static string remindersPath = userSection.Settings.Get("RemindersFilePath").Value.ValueXml.InnerText;
        static string listsPath = userSection.Settings.Get("ListsFilePath").Value.ValueXml.InnerText;

        public ObservableCollection<Note> ReadNotesFromFile()
        {
            ObservableCollection<Note> notes = new ObservableCollection<Note>();
            Note n = new Note(null);

            using (StreamReader reader = new StreamReader(notesPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == "topic:")
                    {
                        n.Topic = reader.ReadLine();
                        notes.Add(n);
                        n = new Note(null);
                    }

                    else if (line == "creation date:") n.CreationDate = reader.ReadLine();

                    else n.Text += line;
                }
            }

            return notes;
        }

        public ObservableCollection<Reminder> ReadRemindersFromFile()
        {
            ObservableCollection<Reminder> reminders = new ObservableCollection<Reminder>();
            Reminder r = new Reminder(null);

            using (StreamReader reader = new StreamReader(remindersPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == "topic:")
                    {
                        r.Topic = reader.ReadLine();
                        reminders.Add(r);
                        r = new Reminder(null);
                    }

                    else if (line == "creation date:") r.CreationDate = reader.ReadLine();

                    else if (line == "date:") r.Date = reader.ReadLine();

                    else r.Text += line;
                }
            }

            return reminders;
        }

        public ObservableCollection<ToDoList> ReadListsFromFile()
        {
            ObservableCollection<ToDoList> lists = new ObservableCollection<ToDoList>();
            ToDoList l = new ToDoList(null);

            using (StreamReader reader = new StreamReader(listsPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == "topic:")
                    {
                        l.Topic = reader.ReadLine();
                        lists.Add(l);
                        l = new ToDoList(null);
                    }

                    else if (line == "creation date:") l.CreationDate = reader.ReadLine();

                    else l.Goals.Add(new Goal(line, Convert.ToBoolean(reader.ReadLine())));
                }
            }

            return lists;
        }

        //public static void RefreshFile(ObservableCollection<Note> notes)
        //{
        //    Reader.Write(notes, notesPath);
        //}

        //public static void RefreshFile(ObservableCollection<Reminder> reminders)
        //{
        //    Reader.Write(reminders, remindersPath);
        //}

        //public static void RefreshFile(ObservableCollection<ToDoList> lists)
        //{
        //    Reader.Write(lists, listsPath);
        //}

        public void RefreshFile(ObservableCollection<Note> notes)
        {
            using (StreamWriter writer = new StreamWriter(notesPath))
            {
                foreach(var note in notes)
                {
                    writer.WriteLine($"creation date:\n{note.CreationDate}");
                    writer.WriteLine(note.Text);
                    writer.WriteLine($"topic:\n{note.Topic}");
                }
            }
        }

        public void RefreshFile(ObservableCollection<Reminder> reminders)
        {
            using (StreamWriter writer = new StreamWriter(remindersPath))
            {
                foreach (var reminder in reminders)
                {
                    writer.WriteLine($"creation date:\n{reminder.CreationDate}");
                    writer.WriteLine($"date:\n{reminder.Date}");
                    writer.WriteLine(reminder.Text);
                    writer.WriteLine($"topic:\n{reminder.Topic}");
                }
            }
        }

        public void RefreshFile(ObservableCollection<ToDoList> lists)
        {
            using (StreamWriter writer = new StreamWriter(listsPath))
            {
                foreach (var list in lists)
                {
                    writer.WriteLine($"creation date:\n{list.CreationDate}");
                    foreach(var goal in list.Goals)
                    {
                        writer.WriteLine(goal.ToString());
                    }
                    writer.WriteLine($"topic:\n{list.Topic}");
                }
            }
        }
    }
}