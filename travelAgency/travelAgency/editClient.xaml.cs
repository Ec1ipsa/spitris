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
    /// Логика взаимодействия для editClient.xaml
    /// </summary>
    public partial class editClient : Window
    {
        private readonly Clients clientsWindow;
        private int? routeId;

        public editClient(int? id, Clients clientsWindow)
        {
            InitializeComponent();

            this.clientsWindow = clientsWindow;
            routeId = id;

            if (id != null)
            {
                /* заполнение полей из БД */
            }
        }

        /* сохранение клиента */
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            /* запись в БД */
        }

        /* отмена редактирования клиента */
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
