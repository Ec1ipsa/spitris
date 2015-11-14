using System;
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
    /// Логика взаимодействия для Routes.xaml
    /// </summary>
    public partial class Routes : Window
    {
        private readonly MainWindow mainWindow;

        public Routes(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void routes_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void AddRouteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
