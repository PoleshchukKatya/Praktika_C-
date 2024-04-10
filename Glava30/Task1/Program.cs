using System;
using System.Data;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Практика С#\Glava30\DBTur_firm.accdb;Persist Security Info=False;";

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Туры";
            using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Название"]} - {reader["Цена"]}");
                    }
                }
            }

            string deleteQuery = "DELETE FROM Туры WHERE [Код тура] = @TourCode";
            using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@TourCode", 2); 
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Удалено туров: {rowsAffected}");
            }

            string insertQuery = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@LastName, @FirstName, @MiddleName)";
            using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@LastName", "Иванов");
                command.Parameters.AddWithValue("@FirstName", "Петр");
                command.Parameters.AddWithValue("@MiddleName", "Сергеевич");
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Добавлено туристов: {rowsAffected}");
            }


            string updateQuery = "UPDATE Туристы SET Фамилия = @NewLastName WHERE [Код туриста] = @TouristCode";
            using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@NewLastName", "Пупкин"); 
                command.Parameters.AddWithValue("@TouristCode", 2); 
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Изменено туристов: {rowsAffected}");
            }
        }
    }
}

