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
            if (checkFull())
            {
                if (Check.checkFloatNumber(priceBox.Text))
                {

                    connection.WriteData(string.Format("INSERT INTO Tours (SID, CID, Date, Count, Discount, Price) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", routeId, clientId, dateBox.Text, int.Parse(countBox.Text), discountBox.Text, float.Parse(priceBox.Text)));
                    MessageBox.Show("Путевка успешно добавлена!", "Предупреждение", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("В поле \"Стоимость\" должно быть введено число!", "Предупреждение", MessageBoxButton.OK);
                } 
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButton.OK);
            }
        }

        private bool checkFull()
        {
            if (Check.checkFullItem(dateBox) && Check.checkFullItem(countBox) && Check.checkFullItem(discountBox) && Check.checkFullItem(priceBox))
                return true;
            return false;
        }

        private void countBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Check.checkNumber(countBox.Text))
            {
                int number = int.Parse(countBox.Text);
                //var result = int.TryParse(countBox.Text, out number);
                Route route = (Route)routesList.Items[0];
                priceBox.Text = (number * route.Cost).ToString();
            }
            else
            {
                MessageBox.Show("В поле \"Количество\" должно быть введено целое число!", "Предупреждение", MessageBoxButton.OK);
            }
        }

       

        private void tours_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            routesWindow.Close();
        }
    }
}
