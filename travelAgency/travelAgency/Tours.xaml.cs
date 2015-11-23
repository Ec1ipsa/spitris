﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace travelAgency
{
    /// <summary>
    /// Логика взаимодействия для Tours.xaml
    /// </summary>
    public partial class Tours : Window
    {
        private readonly MainWindow mainWindow;
        private Tours toursWindow;

        public Tours(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            toursWindow = this;
        }

        private void tours_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }
    }
}
