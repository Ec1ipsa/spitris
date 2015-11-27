using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Логика взаимодействия для editRoute.xaml
    /// </summary>
    public partial class editRoute : Window
    {
        private readonly Routes routesWindow;
        private int? routeId;

        public editRoute(int? id, Routes routesWindow)
        {
            InitializeComponent();

            this.routesWindow = routesWindow;
            routeId = id;

            if (id != null)
            {
                SQLite connection = new SQLite();
                var reader = connection.ReadData(string.Format("SELECT Country, Climat, Duration, Cost, Hotel FROM Scopes WHERE ID = '{0}'", id));
                while (reader.Read())
                {
                    countryBox.Text = reader.GetString(0);
                    climateBox.Text = reader.GetString(1);
                    durationBox.Text = reader.GetInt32(2).ToString();
                    costBox.Text = reader.GetFloat(3).ToString();
                    hotelBox.Text = reader.GetString(4);
                }
            }
        }

        /* сохранение маршрута */
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLite connection = new SQLite();
            
            if (routeId == null)
            {
                connection.WriteData(string.Format("INSERT INTO Scopes (Country, Climat, Duration, Cost, Hotel) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", 
                    countryBox.Text, climateBox.Text, durationBox.Text, costBox.Text, hotelBox.Text));
                MessageBox.Show("Маршрут успешно добавлен!");
            }
            else
            {
                connection.WriteData(string.Format("UPDATE Scopes SET Country = '{0}', Climat = '{1}', Duration = '{2}', Cost = '{3}', Hotel = '{4}' WHERE ID = '{5}'", 
                    countryBox.Text, climateBox.Text, durationBox.Text, costBox.Text, hotelBox.Text, routeId));
                MessageBox.Show("Изменения успешно внесены!");
            }

            Close();
            routesWindow.loadRoutes();
        }

        /* отмена редактирования маршрута */
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
