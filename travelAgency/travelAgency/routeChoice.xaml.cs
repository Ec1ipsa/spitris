using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для routeChoice.xaml
    /// </summary>
    /// 
    public partial class routeChoice : Window
    {
        private readonly Clients clientsWindow;
        private routeChoice routesWindow;
        private int clientId;
        private string clientName;
        private bool isBack = false;

        /* класс объект ListViewItem (климат, страна, отель) для заполнения ListBoxes */
        public class Obj
        {
            public bool IsChecked { get; set; }
            public string Title { get; set; }

            public Obj(bool isChecked, string title)
            {
                IsChecked = isChecked;
                Title = title;
            }
        }

        /* класс маршрут */
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

        /* инициализация */
        public routeChoice(int clientId, string clientName, Clients clientsWindow)
        {
            InitializeComponent();

            this.clientsWindow = clientsWindow;
            routesWindow = this;
            this.clientId = clientId;
            this.clientName = clientName;

            personName.Content += clientName;
            updateClimateList();
            updateCountryList();
            updateHotelList();
        }

        /* обновление ListBox климат */
        private void updateClimateList()
        {
            var climateList = new List<Obj>();
            SQLite connection = new SQLite();

            var reader = connection.ReadData("SELECT Climat FROM Scopes GROUP BY Climat ORDER BY Climat");
            while (reader.Read())
                climateList.Add(new Obj(false, reader.GetString(0)));

            ClimateListBox.ItemsSource = climateList;
        }

        /* обновление ListBox страны */
        private void updateCountryList()
        {
            var countryList = new List<Obj>();
            SQLite connection = new SQLite();

            var climateArr = getItemsArr(ClimateListBox);
            var query = string.Format("SELECT Country FROM Scopes WHERE Climat IN {0} GROUP BY Country ORDER BY Country", climateArr);

            var reader = connection.ReadData(query);
            while (reader.Read())
                countryList.Add(new Obj(false, reader.GetString(0)));

            CountryListBox.ItemsSource = countryList;
        }

        /* обновление ListBox отели */
        private void updateHotelList()
        {
            var hotelList = new List<Obj>();
            SQLite connection = new SQLite();

            var climateArr = getItemsArr(ClimateListBox);
            var countriesArr = getItemsArr(CountryListBox);
            var query = string.Format("SELECT Hotel FROM Scopes WHERE Climat IN {0} AND Country IN {1} GROUP BY Hotel ORDER BY Hotel", climateArr, countriesArr);

            var reader = connection.ReadData(query);
            while (reader.Read())
                hotelList.Add(new Obj(false, reader.GetString(0)));

            HotelListBox.ItemsSource = hotelList;
        }

        /* обновление списка маршрутов */
        private void updateRoutesList()
        {
            routesList.Items.Clear();

            // считываем идентификаторы отмеченных элементов листбоксов
            var climateArr = " AND Climat IN " + getItemsArr(ClimateListBox);
            var countriesArr = " AND Country IN " + getItemsArr(CountryListBox);
            var hotelsArr = " AND Hotel IN " + getItemsArr(HotelListBox);

            // считываем диапазон длительности
            var duration = "";
            if (checkNumber(minDurationBox.Text)) { duration += string.Format(" AND duration >= '{0}'", minDurationBox.Text); }
            if (checkNumber(maxDurationBox.Text)) { duration += string.Format(" AND duration <= '{0}'", maxDurationBox.Text); }

            // считываем диапазон цен
            var cost = "";
            if (checkNumber(minCostBox.Text)) { cost += string.Format(" AND cost >= '{0}'", minCostBox.Text); }
            if (checkNumber(maxCostBox.Text)) { cost += string.Format(" AND cost <= '{0}'", maxCostBox.Text); }

            var query = string.Format("SELECT ID, Country, Climat, Hotel, Duration, Cost FROM Scopes WHERE 1 {0} {1} {2} {3} {4}",
                climateArr, countriesArr, hotelsArr, duration, cost);

            SQLite connection = new SQLite();
            var reader = connection.ReadData(query);
            while (reader.Read())
                routesList.Items.Add(new Route(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetFloat(5)));
        }

        /* изменение ListBox климат */
        private void ClimateCheckBox_Click(object sender, RoutedEventArgs e)
        {
            updateCountryList();
            updateHotelList();
        }

        /* изменение ListBox страна */
        private void CountryCheckBox_Click(object sender, RoutedEventArgs e)
        {
            updateHotelList();
        }

        /* выбрать маршрут и перейти на форму оплаты */
        private void selectRouteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                var routeId = (routesList.SelectedItem as Route).Id;
                var tourForm = new tourPurchase(routeId, routesWindow, clientId);
                tourForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Маршрут не выбран!", "Предупреждение", MessageBoxButton.OK);
            }
        }

        /* подобрать маршрут по заданным параметрам поиска */
        private void findRouteBtn_Click(object sender, RoutedEventArgs e)
        {
            updateRoutesList();
        }

        /* вернуться назад к выбору клиентов */
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            isBack = true;
            Close();
            clientsWindow.Show();
        }

        /* вернуться в главное меню */
        private void routes_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isBack)
                clientsWindow.Close();
        }

        /* получить список id выбранных элементов listBox */
        private string getItemsArr(ListBox curListBox)
        {
            var arr = "(";
            foreach (Obj listBoxItem in curListBox.Items)
                if (listBoxItem.IsChecked)
                {
                    if (arr.Length != 1)
                        arr += ",";
                    arr += "'" + listBoxItem.Title + "'";
                }
            return arr += ")";
        }

        /* проверка на целое положительное число */
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