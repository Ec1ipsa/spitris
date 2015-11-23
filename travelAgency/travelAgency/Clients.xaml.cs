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
    public partial class Clients : Window
    {
        private readonly MainWindow mainWindow;
        private Clients clientsWindow;

        private class Client
        {
            public int Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Secname { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
        }

        public Clients(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            clientsWindow = this;

            UpdateClientsList(null);
        }

        /* вывод клиентов из БД в таблицу */
        public void UpdateClientsList(string surname)
        {
            clientsList.Items.Clear();

            // surname - поиск по фамилии
            if (surname == null) { surname = "WHERE 1"; } else { surname = string.Format("WHERE `Surname` LIKE '{0}'", surname); }

            // пример добавления клиента в таблицу
            //var client = new Client() { Id = 1, Surname = "Качулин", Name = "Сергей", Secname = "Геннадьевич"};
            //clientsList.Items.Add(client);
            //client = new Client() { Id = 2, Surname = "Гилязева", Name = "Софья", Secname = "Аликовна" };
            //clientsList.Items.Add(client);

            /* загрузка клиентов из БД */
            SQLite connection = new SQLite();
            SQLiteDataReader reader = connection.ReadData(string.Format("SELECT * FROM 'Clients' {0}", surname));
            while (reader.Read())
            {
                var client = new Client()
                {
                    Id = reader.GetInt32(0),
                    Surname = reader.GetString(1),
                    Name = reader.GetString(2),
                    Secname = reader.GetString(3)
                };
                clientsList.Items.Add(client);
            }
        }        

        /* поиск по фамилии клиента */
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string surname = searchBox.Text;
            UpdateClientsList(surname);
        }

        /* добавление клиента */
        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            var editClientForm = new editClient(null, clientsWindow);
            editClientForm.Owner = this;
            editClientForm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editClientForm.ShowDialog();
        }

        /* редактирование клиента */
        private void EditClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (clientsList.SelectedItem != null)
            {
                var id = (clientsList.SelectedItem as Client).Id;

                var editClientForm = new editClient(id, clientsWindow);
                editClientForm.Owner = this;
                editClientForm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                editClientForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Клиент не выбран!");
            }
        }

        /* удаление клиента */
        private void DeleteClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (clientsList.SelectedItem != null)
            {
                if (Confirm("Удалить выбранного клиента?"))
                {
                    var id = (clientsList.SelectedItem as Client).Id;

                    /* удаление из БД и таблицы */
                    SQLite connection = new SQLite();
                    connection.WriteData(string.Format("DELETE FROM Clients WHERE `ID` = '{0}'", id));
                    UpdateClientsList(null);
                }
            }
            else
            {
                MessageBox.Show("Клиент не выбран!");
            }
        }

        /* вывод вопроса подтверждения */
        private bool Confirm(string text)
        {
            var messageBoxResult = MessageBox.Show(text, "Подтверждение действия", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes) { return true; } else { return false; }
        }

        /* закрытие окна */
        private void clients_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void clientsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        
    }
}
