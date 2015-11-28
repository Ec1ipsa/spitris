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

namespace travelAgency
{
    /// <summary>
    /// Логика взаимодействия для Routes.xaml
    /// </summary>
    public partial class Routes : Window
    {
        private readonly MainWindow mainWindow;
        private Routes routesWindow;

        private class Route
        {
            public int Id { get; set; }
            public string Climate { get; set; }
            public string Country { get; set; }
            public string Hotel { get; set; }
            public int Duration { get; set; }
            public float Cost { get; set; }

            public Route(int id, string climate, string country, string hotel, int duration, float cost)
            {
                Id = id;
                Climate = climate;
                Country = country;
                Hotel = hotel;
                Duration = duration;
                Cost = cost;
            }
        }

        public Routes(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            routesWindow = this;

            loadRoutes();
        }

        /* вывод маршрутов из БД в таблицу */
        public void loadRoutes()
        {
            routesList.Items.Clear();

            SQLite connection = new SQLite();
            SQLiteDataReader reader = connection.ReadData("SELECT ID, Climat, Country, Hotel, Duration, Cost FROM Scopes ORDER BY Climat, Country, Hotel, Duration, Cost");
            while (reader.Read())
            {
                routesList.Items.Add(new Route(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetFloat(5)));
            }
        }

        /* добавление маршрута */
        private void AddRouteBtn_Click(object sender, RoutedEventArgs e)
        {
            var editRouteForm = new editRoute(null, routesWindow);
            editRouteForm.Owner = this;
            editRouteForm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editRouteForm.ShowDialog();
        }

        /* редактирование маршрута */
        private void EditRouteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                var id = (routesList.SelectedItem as Route).Id;

                var editRouteForm = new editRoute(id, routesWindow);
                editRouteForm.Owner = this;
                editRouteForm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                editRouteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Маршрут не выбран!", "Предупреждение", MessageBoxButton.OK);
            }
        }

        /* удаление маршрута */
        private void DeleteRouteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                if (Confirm("Удалить выбранный маршрут?"))
                {
                    var id = (routesList.SelectedItem as Route).Id;

                    SQLite connection = new SQLite();
                    connection.WriteData(string.Format("DELETE FROM Scopes WHERE ID = '{0}'", id));
                    loadRoutes();
                }
            }
            else
            {
                MessageBox.Show("Маршрут не выбран!", "Предупреждение", MessageBoxButton.OK);
            }
        }

        /* вывод вопроса подтверждения */
        private bool Confirm(string text)
        {
            var messageBoxResult = MessageBox.Show(text, "Подтверждение действия", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes) { return true; } else { return false; }
        }

        /* закрытие окна */
        private void routes_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
