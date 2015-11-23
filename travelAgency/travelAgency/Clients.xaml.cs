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

        /* класс клиент */
        private class Client
        {
            public int Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Secname { get; set; }

            public Client(int id, string surname, string name, string secname)
            {
                Id = id;
                Surname = surname;
                Name = name;
                Secname = secname;
            }
        }

        /* инициализация */
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

            if (surname == null) { surname = ""; } else { surname = string.Format("WHERE Surname LIKE '%{0}%'", surname); }

            SQLite connection = new SQLite();
            SQLiteDataReader reader = connection.ReadData(string.Format("SELECT ID, Surname, Name, Secname FROM Clients {0} ORDER BY Surname, Name, Secname", surname));
            while (reader.Read())
            {
                clientsList.Items.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
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
                MessageBox.Show("Клиент не выбран!", "Предупреждение", MessageBoxButton.OK);
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

                    SQLite connection = new SQLite();
                    connection.WriteData(string.Format("DELETE FROM Clients WHERE ID = '{0}'", id));
                    UpdateClientsList(null);
                }
            }
            else
            {
                MessageBox.Show("Клиент не выбран!", "Предупреждение", MessageBoxButton.OK);
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

        /* выбрать клиента и перейти на форму выбора маршрута */
        private void clientsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (clientsList.SelectedItem != null)
            {
                var client = clientsList.SelectedItem as Client;
                var clientId = client.Id;
                var clientName = client.Surname + " " + client.Name + " " + client.Secname;

                var editClientForm = new routeChoice(clientId, clientName, clientsWindow);
                editClientForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Клиент не выбран!", "Предупреждение", MessageBoxButton.OK);
            }
        }
    }
}
