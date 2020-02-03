﻿using System;
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
    
    public partial class AddToDoList_page : Page
    {
        public AddToDoList_page(TaskManagerViewModel taskManager)
        {
            InitializeComponent();
            DataContext = taskManager;
        }
    }
}
