using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace WinFormsApp1 
{
    public static class DatabaseHelper
    {
      
        private static string connectionString = "Data Source=ritual.db";

        // 1. СОЗДАНИЕ ТАБЛИЦ И АДМИНА
        public static void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // таблица заказов
                var cmdOrders = connection.CreateCommand();
                cmdOrders.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Orders (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CustomerName TEXT NOT NULL,
                        Phone TEXT,
                        DeceasedName TEXT NOT NULL,
                        Services TEXT,
                        TotalSum REAL,
                        Date TEXT
                    );";
                cmdOrders.ExecuteNonQuery();

                // таблица пользователей
                var cmdUsers = connection.CreateCommand();
                cmdUsers.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Login TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    );";
                cmdUsers.ExecuteNonQuery();

                // Проверка
                var checkUser = connection.CreateCommand();
                checkUser.CommandText = "SELECT COUNT(*) FROM Users";
                long count = (long)checkUser.ExecuteScalar();

                if (count == 0)
                {
                    var insertAdmin = connection.CreateCommand();
                    insertAdmin.CommandText = "INSERT INTO Users (Login, Password) VALUES ('admin', '123')";
                    insertAdmin.ExecuteNonQuery();
                }
            }
        }

        // 2. ПРОВЕРКА ЛОГИНА И ПАРОЛЯ
        public static bool CheckLogin(string login, string password)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Users WHERE Login = $login AND Password = $password";
                command.Parameters.AddWithValue("$login", login);
                command.Parameters.AddWithValue("$password", password);

                long count = (long)command.ExecuteScalar();
                return count > 0; 
            }
        }

        // 3. СОХРАНЕНИЕ НОВОГО ЗАКАЗА
        public static bool SaveOrder(string customer, string phone, string deceased, string services, decimal sum)
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                        INSERT INTO Orders (CustomerName, Phone, DeceasedName, Services, TotalSum, Date) 
                        VALUES ($customer, $phone, $deceased, $services, $sum, $date)";

                    command.Parameters.AddWithValue("$customer", customer);
                    command.Parameters.AddWithValue("$phone", phone);
                    command.Parameters.AddWithValue("$deceased", deceased);
                    command.Parameters.AddWithValue("$services", services);
                    command.Parameters.AddWithValue("$sum", sum);
                    command.Parameters.AddWithValue("$date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения в БД: " + ex.Message);
                return false;
            }
        }

        // 4. ПОЛУЧЕНИЕ ВСЕХ ЗАКАЗОВ ДЛЯ ТАБЛИЦЫ
        public static DataTable GetOrders()
        {
            DataTable table = new DataTable();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Orders ORDER BY Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }
    }
}