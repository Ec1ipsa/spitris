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
    /// Логика взаимодействия для tourPurchase.xaml
    /// </summary>
    public partial class tourPurchase : Window
    {
        private readonly routeChoice routesWindow;
        private readonly int routeId;
        private readonly int clientId;

        public tourPurchase(int routeId, routeChoice routesWindow, int clientId)
        {
            InitializeComponent();

            this.routesWindow = routesWindow;
            this.routeId = routeId;
            this.clientId = clientId;
        }

        private void sellTourBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tours_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            routesWindow.Close();
        }
    }
}
