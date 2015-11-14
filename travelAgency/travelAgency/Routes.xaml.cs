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
        private Routes routesWindow;

        public class Route
        {
            public int Id { get; set; }
            public string Country { get; set; }
            public string Climate { get; set; }
            public int Duration { get; set; }
            public string Hotel { get; set; }
            public int Cost { get; set; }
        }

        public Routes(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            routesWindow = this;

            loadRoutes();
        }

        /* вывод маршрутов из БД в таблицу */
        private void loadRoutes()
        {
            // пример добавления маршрута в таблицу
            var route = new Route() { Id = 1, Country = "Россия", Climate = "Умеренный", Duration = 14, Hotel = "Урал", Cost = 25000 };
            routesList.Items.Add(route);

            /* загрузка маршрутов из БД */
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
                MessageBox.Show("Маршрут не выбран!");
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

                    /* удаление из БД и таблицы */
                }
            }
            else
            {
                MessageBox.Show("Маршрут не выбран!");
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
    }
}
