using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Configuration;
using WpfTaskmanager.View;


namespace WpfTaskmanager.View
{
    public partial class MainWindow : Page
    { 
        static Reader reader = new Reader();

        static TaskManager taskManag = new TaskManager
            (reader.ReadNotesFromFile(),
            reader.ReadRemindersFromFile(),
            reader.ReadListsFromFile());
        

        TaskManagerViewModel taskManager = new TaskManagerViewModel(taskManag);

        public MainWindow()
        { 
            InitializeComponent();

            DataContext = taskManager;
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNote_page(taskManager));
        }

        private void AddReminder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddReminder_page(taskManager));
        }

        private void AddToDoList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToDoList_page(taskManager));
        }

        private void Notes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new OpenNote_page(taskManager));
        }

        private void Reminders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new OpenReminder_page(taskManager));
        }

        private void Lists_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new OpenList_page((taskManager)));
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = ""; 
        }
    }
}
