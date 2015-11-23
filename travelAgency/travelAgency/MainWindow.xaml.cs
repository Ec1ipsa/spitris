using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace travelAgency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindow mainWindow;

        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
        }

        private void ClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            var clients = new Clients(mainWindow);
            clients.Show();
            Hide();
        }

        private void RoutesBtn_Click(object sender, RoutedEventArgs e)
        {
            var routes = new Routes(mainWindow);
            routes.Show();
            Hide();
        }

        private void TicketsBtn_Click(object sender, RoutedEventArgs e)
        {
            var tours = new Tours(mainWindow);
            tours.Show();
            Hide();
        }
    }
}
