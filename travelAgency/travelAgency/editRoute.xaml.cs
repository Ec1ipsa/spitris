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

            /* заполнение комбобокса с отелями */

            if (id != null)
            {
                /* заполнение полей из БД */
            }
        }

        /* сохранение маршрута */
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            /* запись в БД */
            SQLite connection = new SQLite();
            //SQLiteDataReader reader = connection.ReadData(string.Format("INSERT INTO Clients (ID, Surname, Name, Secname, Address, Phone) VALUES ({}, {}, {}, {}, {}, {})", 2, surnameBox.));
        }

        /* отмена редактирования маршрута */
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
