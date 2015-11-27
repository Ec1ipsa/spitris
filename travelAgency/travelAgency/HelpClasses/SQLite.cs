using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace travelAgency.HelpClasses
{
    class SQLite
    {
        string database;
        SQLiteCommand query;
        SQLiteConnection connection;
        SQLiteDataReader reader;
        //КОНСТРУКТОР
        public SQLite()
        {
            database = Environment.CurrentDirectory + "\\TourFirma.sqlite";
            connection = new SQLiteConnection(string.Format("Data Source={0}", database));
            connection.Open();

        }
        //чтение данных
        public SQLiteDataReader ReadData(string query)
        {
            
            this.query = new SQLiteCommand(query, connection);
            reader = this.query.ExecuteReader();
            //connection.Close();
            return reader;
            
        }
        //запись данных
        public void WriteData(string query)
        {
            //connection.Open();
            this.query = new SQLiteCommand(query, connection);
            this.query.ExecuteNonQuery();
            Close();
        }
        //закрытие подключения
        public void Close()
        {
            connection.Close();
        }
        //получение объекта для изменения
        //public SQLiteDataReader GetItem(int id, string table)
        //{
        //    connection.Open();
        //    if (table == "Clients")
        //    {
        //        reader = ReadData(string.Format("SELECT Surname, Name, Secname, Address, Phone FROM Clients WHERE ID = '{0}'", id));
        //    }
        //    else if (table == "Routes")
        //    {
        //        reader = ReadData(string.Format("SELECT Surname, Name, Secname, Address, Phone FROM Clients WHERE ID = '{0}'", id));
        //    }
        //    return reader;
        //}
    }
    
}
