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
    /// Логика взаимодействия для editClient.xaml
    /// </summary>
    public partial class editClient : Window
    {
        private readonly Clients clientsWindow;
        private int? clientId;

        /* инициализация */
        public editClient(int? id, Clients clientsWindow)
        {
            InitializeComponent();

            this.clientsWindow = clientsWindow;
            clientId = id;

            if (id != null)
            {
                SQLite connection = new SQLite();
                SQLiteDataReader reader = connection.ReadData(string.Format("SELECT Surname, Name, Secname, Address, Phone FROM Clients WHERE ID = '{0}'", clientId));
                while (reader.Read())
                {
                    surnameBox.Text = reader.GetString(0);
                    nameBox.Text = reader.GetString(1);
                    if (reader.GetString(2) != "")
                        secnameBox.Text = reader.GetString(2);
                    if (reader.GetString(3) != "")
                        adressBox.Text = reader.GetString(3);
                    if (reader.GetString(4) != "")
                        phoneBox.Text = reader.GetString(4); 
                }
            }
        }

        /* сохранение клиента */
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLite connection = new SQLite();

            if (clientId == null)
            {
                connection.WriteData(string.Format("INSERT INTO Clients (Surname, Name, Secname, Address, Phone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", 
                    surnameBox.Text, nameBox.Text, secnameBox.Text, adressBox.Text, phoneBox.Text));
                MessageBox.Show("Клиент успешно добавлен!");                
            }
            else
            {
                connection.WriteData(string.Format("UPDATE Clients SET Surname = '{0}', Name = '{1}', Secname = '{2}', Address = '{3}', Phone = '{4}' WHERE ID = '{5}'", 
                    surnameBox.Text, nameBox.Text, secnameBox.Text, adressBox.Text, phoneBox.Text, clientId));
                MessageBox.Show("Изменения успешно внесены!");
            }

            Close();
            clientsWindow.UpdateClientsList(null);            
        }

        /* отмена редактирования клиента */
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
