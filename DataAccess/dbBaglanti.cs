using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace HotelReservationandManagementSystem.DAL
{
    public class dbBaglanti
    {
        private MySqlConnection baglanti;

        public MySqlConnection BaglantiGetir()
        {
            string connectionString = "Server=172.21.54.253;Database=25_132330036;User=25_132330036;Password=!nif.ogr36CA;";
            baglanti = new MySqlConnection(connectionString);
            return baglanti;
        }
    }
}
