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
    /// Логика взаимодействия для Tours.xaml
    /// </summary>
    public partial class Tours : Window
    {
        private readonly MainWindow mainWindow;
        private Tours toursWindow;

        private class Tour
        {
            public int Id { get; set; }
            public string Client { get; set; }
            public string Country { get; set; }
            public string Hotel { get; set; }
            public int Duration { get; set; }
            public string Date { get; set; }
            public int Count { get; set; }
            public string Discount { get; set; }
            public float Price { get; set; }

            public Tour(int id, string client, string country, string hotel, int duration, string date, int count, string discount, float price)
            {
                Id = id;
                Client = client;
                Country = country;
                Hotel = hotel;
                Duration = duration;
                Date = date;
                Count = count;
                Discount = discount;
                Price = price;
            }
        }

        public Tours(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            toursWindow = this;
            loadTours();
        }

        public void loadTours()
        {
            toursList.Items.Clear();

            SQLite connection = new SQLite();
            SQLiteDataReader reader = connection.ReadData("SELECT ID, SID, CID, Date, Count, Discount, Price FROM Tours ORDER BY Date");
            while (reader.Read())
            {
                var readclient = connection.ReadData(string.Format("SELECT Surname, Name, Secname FROM Clients WHERE ID = '{0}'", reader.GetInt32(2)));
                readclient.Read();
                var readroute = connection.ReadData(string.Format("SELECT Country, Hotel, Duration FROM Scopes WHERE ID = '{0}'", reader.GetInt32(1)));
                readroute.Read();

                toursList.Items.Add(new Tour
                    (reader.GetInt32(0), 
                    string.Format("{0} {1} {2}", readclient.GetString(0), readclient.GetString(1), readclient.GetString(2)),
                    readroute.GetString(0),
                    readroute.GetString(1),
                    readroute.GetInt32(2),
                    reader.GetString(3), 
                    reader.GetInt32(4), 
                    reader.GetString(5),
                    reader.GetFloat(6)));

            }
            connection.Close();
        }

        private void tours_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
