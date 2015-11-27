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
using travelAgency.HelpClasses;

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

        /* класс маршрут */
        //private class Route
        //{
        //    public int Id { get; set; }
        //    public string Climate { get; set; }
        //    public string Country { get; set; }
        //    public string Hotel { get; set; }
        //    public int Duration { get; set; }
        //    public float Cost { get; set; }

        //    public Route(int id, string climate, string country, string hotel, int duration, float cost)
        //    {
        //        Id = id;
        //        Climate = climate;
        //        Country = country;
        //        Hotel = hotel;
        //        Duration = duration;
        //        Cost = cost;
        //    }
        //}

        public tourPurchase(int routeId, routeChoice routesWindow, int clientId)
        {
            InitializeComponent();

            this.routesWindow = routesWindow;
            this.routeId = routeId;
            this.clientId = clientId;

            SQLite connection = new SQLite();
            var reader = connection.ReadData(string.Format("SELECT Surname, Name, Secname FROM Clients WHERE ID ='{0}'", clientId));
            while (reader.Read())
            {
                personName.Content = string.Format("Продажа тура клиенту: {0} {1} {2}", reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }

            reader = connection.ReadData(string.Format("SELECT Climat, Country, Hotel, Duration, Cost FROM Scopes WHERE ID = '{0}'", routeId));
            while (reader.Read())
            {
                Route route = new Route(
                    routeId, 
                    reader.GetString(0), 
                    reader.GetString(1), 
                    reader.GetString(2), 
                    reader.GetInt32(3), 
                    reader.GetFloat(4));
                routesList.Items.Add(route);
           
            }
            connection.Close();
        }

        private void sellTourBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLite connection = new SQLite();
            connection.WriteData(string.Format("INSERT INTO Tours (SID, CID, Date, Count, Discount, Price) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", routeId, clientId, dateBox.Text, countBox.Text, discountBox.Text, priceBox.Text));
            MessageBox.Show("Путевка успешно добавлена!");
        }

        private void countBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (checkNumber(countBox.Text))
            {
                int number;
                var result = int.TryParse(countBox.Text, out number);
                Route route = (Route)routesList.Items[0];
                priceBox.Text = (number * route.Cost).ToString();
            }
        }

        /* проверка на целое положительное число */
        //сперла из маршрутов
        private bool checkNumber(string text)
        {
            int number;
            bool result = Int32.TryParse(text, out number);

            if (result)
                if (number >= 0) return true;
            return false;
        }
    }
}
