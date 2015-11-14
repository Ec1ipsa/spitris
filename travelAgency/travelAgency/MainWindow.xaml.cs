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
        private MainWindow mainForm;

        public MainWindow()
        {
            InitializeComponent();
            mainForm = this;
        }

        private void ClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            var clients = new Clients(mainForm);
            clients.Show();
            Hide();
        }

        private void RoutesBtn_Click(object sender, RoutedEventArgs e)
        {
            var routes = new Routes(mainForm);
            routes.Show();
            Hide();
        }

        private void TicketsBtn_Click(object sender, RoutedEventArgs e)
        {
            var tickets = new Tickets(mainForm);
            tickets.Show();
            Hide();
        }
    }
}
