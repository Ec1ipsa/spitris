using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace travelAgency
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
            
        }
        //чтение данных
        public SQLiteDataReader ReadData(string query)
        {
            connection.Open();
            this.query = new SQLiteCommand(query, connection);
            reader = this.query.ExecuteReader();
            //connection.Close();
            return reader;
            
        }
    }
    
}
