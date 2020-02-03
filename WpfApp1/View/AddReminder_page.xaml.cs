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

namespace WpfTaskmanager.View
{
    /// <summary>
    /// Interaction logic for AddReminder_page.xaml
    /// </summary>
    public partial class AddReminder_page : Page
    {
        public AddReminder_page(TaskManagerViewModel taskManager)
        {
            InitializeComponent();
            DataContext = taskManager;
        }
    }
}
