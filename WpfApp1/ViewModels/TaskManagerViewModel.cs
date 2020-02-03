using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;

namespace WpfTaskmanager
{
    public class TaskManagerViewModel : BaseViewModel
    {
        static Reader reader = new Reader();



        #region MainProperties
        Note selectedNote;
        Reminder selectedReminder;
        ToDoList selectedList;

        public Note SelectedNote
        {
            get { return selectedNote; }
            set
            {
                selectedNote = value;
                OnPropertyChanged("SelectedNote");
            }
        }

        public Reminder SelectedReminder
        {
            get { return selectedReminder; }
            set
            {
                selectedReminder = value;
                OnPropertyChanged("SelectedReminder");
            }
        }

        public ToDoList SelectedList
        {
            get { return selectedList; }
            set
            {
                selectedList = value;
                OnPropertyChanged("SelectedList");
            }
        }

        public ObservableCollection<Note> Notes { get; set; }
        public ObservableCollection<Reminder> Reminders { get; set; }
        public ObservableCollection<ToDoList> Lists { get; set; }
        #endregion

        #region NewTask

        Note newNote = new Note();
        Reminder newReminder = new Reminder();
        ToDoList newList = new ToDoList();
        Goal newGoal = new Goal();
        bool saveNew_ButtonVisibility;

        public Note NewNote
        {
            get { return newNote; }
            set
            {
                newNote = value;
                OnPropertyChanged("NewNote");
            }
        }

        public Reminder NewReminder
        {
            get { return newReminder; }
            set
            {
                newReminder= value;
                OnPropertyChanged("NewReminder");
            }
        }

        public ToDoList NewList
        {
            get { return newList; }
            set
            {
                newList= value;
                OnPropertyChanged("NewList");
            }
        }


        public Goal NewGoal
        {
            get { return newGoal; }
            set
            {
                newGoal = value;
                OnPropertyChanged("NewGoal");
            }
        }


        #endregion

        #region ForOpenedTask

        //Note openedNote;
        //Reminder openedReminder;
        //ToDoList openedList;

        Goal selectedGoal;

        public Goal SelectedGoal
        {
            get { return selectedGoal; }
            set
            {
                selectedGoal = value;
                OnPropertyChanged("SelectedGoal");
            }
        }

        //public Note OpenedNote
        //{
        //    get { return SelectedNote; }
        //    set
        //    {
        //        openedNote = value;
        //        OnPropertyChanged("OpenedNote");
        //    }
        //}

        //public Reminder OpenedReminder
        //{
        //    get { return SelectedReminder; }
        //    set
        //    {
        //        openedReminder = value;
        //        OnPropertyChanged("OpenedReminder");
        //    }
        //}

        //public ToDoList OpenedList
        //{
        //    get { return SelectedList; }
        //    set
        //    {
        //        openedList = value;
        //        OnPropertyChanged("OpenedList");
        //    }
        //}*/

        #endregion

        #region Visibilities
        bool textBox_IsReadOnly;
        bool element_IsEnabled;
        bool editButton_visibility;
        bool saveButton_visibility;

        bool addButton_visibility;
        bool editGoal_ButtonVisibility;
        bool textBox_visibility;
        bool saveList_ButtonVisibility;

        public bool TextBox_IsReadOnly
        {
            get { return textBox_IsReadOnly; }
            set
            {
                textBox_IsReadOnly = value;
                OnPropertyChanged("TextBox_IsReadOnly");
            }
        }

        public bool Element_IsEnabled
        {
            get { return element_IsEnabled; }
            set
            {
                element_IsEnabled = value;
                OnPropertyChanged("Element_IsEnabled");
            }
        }

        public bool EditButton_visibility
        {
            get { return editButton_visibility; }
            set
            {
                editButton_visibility = value;
                OnPropertyChanged("EditButton_visibility");
            }
        }

        public bool SaveButton_visibility
        {
            get { return saveButton_visibility; }
            set
            {
                saveButton_visibility = value;
                OnPropertyChanged("SaveButton_visibility");
            }
        }

        public bool TextBox_visibility
        {
            get { return textBox_visibility; }
            set
            {
                textBox_visibility = value;
                OnPropertyChanged("TextBox_visibility");
            }
        }


        public bool AddButton_visibility
        {
            get { return addButton_visibility; }
            set
            {
                addButton_visibility = value;
                OnPropertyChanged("AddButton_visibility");
            }
        }

        public bool EditGoal_ButtonVisibility
        {
            get { return editGoal_ButtonVisibility; }
            set
            {
                editGoal_ButtonVisibility = value;
                OnPropertyChanged("EditGoal_ButtonVisibility");
            }
        }

        public bool SaveNew_ButtonVisibility
        {
            get
            {
                return saveNew_ButtonVisibility;
            }
            set
            {
                saveNew_ButtonVisibility = value;
                OnPropertyChanged("SaveNew_ButtonVisibility");
            }
        }

        public bool SaveList_ButtonVisibility
        {
            get { return saveList_ButtonVisibility; }
            set
            {
                saveList_ButtonVisibility = value;
                OnPropertyChanged("SaveList_ButtonVisibility");
            }
        }

        #endregion

        #region ForSearching

        string filter;
        public string Filter
        {
            get { return filter; }
            set
            {
                filter = value.ToLower();
                
                SelectedNote = (TaskManager.Search(Notes, Filter)).FirstOrDefault();
                SelectedReminder = (TaskManager.Search(Reminders, Filter)).FirstOrDefault();
                SelectedList = (TaskManager.Search(Lists, Filter)).FirstOrDefault();

                OnPropertyChanged("Filter");
            }
        }

        #endregion

        #region Commands
        RelayCommand edit_Command;

        RelayCommand saveEditedNote_Command;
        RelayCommand saveEditedReminder_Command;
        RelayCommand saveEditedList_Command;

        RelayCommand saveNewNote_Command;
        RelayCommand saveNewReminder_Command;
        RelayCommand saveNewList_Command;

        RelayCommand deleteNote_Command;
        RelayCommand deleteReminder_Command;
        RelayCommand deleteList_Command;

        RelayCommand add_ListItem;
        RelayCommand edit_List;
        RelayCommand editGoal;
        RelayCommand saveEditedGoal_Command;
        RelayCommand deleteGoal;


        public RelayCommand Edit_Command
        {
            get
            {
                return edit_Command ??
                    (edit_Command = new RelayCommand(() =>
                    {
                        TextBox_IsReadOnly = false;
                        Element_IsEnabled = true;
                        EditButton_visibility = false;
                        SaveButton_visibility = true;
                        TextBox_visibility = true;
                        AddButton_visibility = true;
                    }));
            }

        }

        public RelayCommand SaveEditedNote_Command
        {
            get
            {
                return saveEditedNote_Command ??
                    (saveEditedNote_Command = new RelayCommand(() =>
                    {
                        TextBox_IsReadOnly = true;
                        EditButton_visibility = true;
                        SaveButton_visibility = false;
                        reader.RefreshFile(Notes);
                    }));
            }
        }

        public RelayCommand SaveEditedReminder_Command
        {
            get
            {
                return saveEditedReminder_Command ??
                    (saveEditedReminder_Command = new RelayCommand(() =>
                    {
                        TextBox_IsReadOnly = true;
                        Element_IsEnabled = false;
                        EditButton_visibility = true;
                        SaveButton_visibility = false;
                        reader.RefreshFile(Reminders);
                    }));
            }
        }

        public RelayCommand SaveEditedList_Command
        {
            get
            {
                return saveEditedList_Command ??
                    (saveEditedList_Command = new RelayCommand(() =>
                    {
                        TextBox_IsReadOnly = true;
                        EditButton_visibility = true;
                        SaveButton_visibility = false;
                        TextBox_visibility = false;
                        AddButton_visibility = false;
                        reader.RefreshFile(Lists);
                    }));
            }
        }

        public RelayCommand SaveNewNote_Command
        {
            get
            {
                return saveNewNote_Command ??
                    (saveNewNote_Command = new RelayCommand(() =>
                    {
                        NewNote.CreationDate = DateTime.Today.ToShortDateString();
                        Notes.Insert(0, newNote);
                        reader.RefreshFile(Notes);
                        SaveNew_ButtonVisibility = false;
                    }));
            }
        }

        public RelayCommand SaveNewReminder_Command
        {
            get
            {
                return saveNewReminder_Command ??
                    (saveNewReminder_Command = new RelayCommand(() =>
                    {
                        NewReminder.CreationDate = DateTime.Today.ToShortDateString();
                        Reminders.Insert(0, newReminder);
                        reader.RefreshFile(Reminders);
                        SaveNew_ButtonVisibility = false;
                    }));
            }
        }

        public RelayCommand SaveNewList_Command
        {
            get
            {
                return saveNewList_Command ??
                    (saveNewList_Command = new RelayCommand(() =>
                    {
                        NewList.CreationDate = DateTime.Today.ToShortDateString();
                        Lists.Insert(0, newList);
                        reader.RefreshFile(Lists);
                        SaveNew_ButtonVisibility = false;
                        TextBox_visibility = false;
                        AddButton_visibility = false;
                    }));
            }
        }

        public RelayCommand DeleteNote_Command
        {
            get
            {
                return deleteNote_Command ??
                    (deleteNote_Command = new RelayCommand(() =>
                    {
                        Notes.Remove(selectedNote);
                        reader.RefreshFile(Notes);
                    }));
            }
        }

        public RelayCommand DeleteReminder_Command
        {
            get
            {
                return deleteReminder_Command ??
                    (deleteReminder_Command = new RelayCommand(() =>
                    {
                        Reminders.Remove(selectedReminder);
                        reader.RefreshFile(Reminders);
                    }));
            }
        }

        public RelayCommand DeleteList_Command
        {
            get
            {
                return deleteList_Command ??
                    (deleteList_Command = new RelayCommand(() =>
                    {
                        Lists.Remove(selectedList);
                        reader.RefreshFile(Lists);
                    }));
            }
        }

        public RelayCommand Add_ListItem
        {
            get
            {
                return add_ListItem ??
                    (add_ListItem= new RelayCommand(() =>
                    {
                        newList.Goals.Add(NewGoal);
                        NewGoal = new Goal();
                    }));
            }
        }

        public RelayCommand Edit_List
        {
            get
            {
                return edit_List ??
                    (edit_List = new RelayCommand(() =>
                    {
                        selectedList.Goals.Add(NewGoal);
                        NewGoal = new Goal();
                    }));
            }
        }

        public RelayCommand EditGoal
        {
            get
            {
                return editGoal??
                    (editGoal= new RelayCommand(() =>
                    {
                        SaveList_ButtonVisibility = false;
                        TextBox_visibility = true;
                        EditButton_visibility = false;
                        EditGoal_ButtonVisibility = true;
                        NewGoal.GoalText = SelectedGoal.GoalText;
                    }));
            }
        }

        public RelayCommand SaveEdited_Goal
        {
            get
            {
                return saveEditedGoal_Command??
                    (saveEditedGoal_Command = new RelayCommand(() =>
                    {
                        SaveList_ButtonVisibility = true;
                        TextBox_visibility = false;
                        EditButton_visibility = true;
                        EditGoal_ButtonVisibility = false;
                        SelectedGoal.GoalText = NewGoal.GoalText;
                        reader.RefreshFile(Lists);
                        NewGoal = new Goal();
                    }));
            }
        }

        public RelayCommand DeleteGoal
        {
            get
            {
                return deleteGoal ??
                    (deleteGoal = new RelayCommand(() =>
                    {
                        SelectedList.Goals.Remove(SelectedGoal);
                        reader.RefreshFile(Lists);
                    }));
            }
        }

        #endregion

        #region Costructor


        public TaskManagerViewModel(TaskManager taskManager)
        {
            Notes = taskManager.Notes;
            Reminders = taskManager.Reminders;
            Lists = taskManager.Lists;

            textBox_IsReadOnly = true;
            element_IsEnabled = false;
            editButton_visibility = true;
            saveButton_visibility = false;
            saveNew_ButtonVisibility = true;
            addButton_visibility = false;
            editGoal_ButtonVisibility = false;
            saveList_ButtonVisibility = true;

            filter = "Search...";

        }
        #endregion
    }
}
