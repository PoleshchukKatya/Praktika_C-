using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Практика С#\Glava31\DBTur_firm.accdb;";
        public Form1()
        {
            InitializeComponent();
        }


        private void SelectAllTours()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Туры;";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    DataTable toursTable = dataSet.Tables[0];
                    dataGridViewTours.DataSource = toursTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void DeleteTour()
        {
            int tourId = Convert.ToInt32(txtTourId.Text);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Туры WHERE [Код тура] = @TourId;";
                    OleDbCommand command = new OleDbCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@TourId", tourId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Тур успешно удалён.");
                        SelectAllTours(); 
                    }
                    else
                    {
                        MessageBox.Show("Тур с указанным идентификатором не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void AddTourist()
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@LastName, @FirstName, @MiddleName);";
                    OleDbCommand command = new OleDbCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Турист успешно добавлен.");
                        SelectAllTourists(); 
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении туриста.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void UpdateTourist()
        {
            int touristId = Convert.ToInt32(txtTouristId.Text);
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE Туристы SET Фамилия = @LastName, Имя = @FirstName, Отчество = @MiddleName WHERE [Код туриста] = @TouristId;";
                    OleDbCommand command = new OleDbCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@TouristId", touristId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Информация о туристе успешно обновлена.");
                        SelectAllTourists(); 
                    }
                    else
                    {
                        MessageBox.Show("Турист с указанным идентификатором не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void SelectAllTourists()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Туристы;";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    DataTable touristsTable = dataSet.Tables[0];
                    dataGridViewTourists.DataSource = touristsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void btnSelectAllTours_Click(object sender, EventArgs e)
        {
            SelectAllTours();
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            DeleteTour();
        }

        private void btnAddTourist_Click(object sender, EventArgs e)
        {
            AddTourist();
        }

        private void btnUpdateTourist_Click(object sender, EventArgs e)
        {
            UpdateTourist();
        }

        private void btnSelectAllTourists_Click(object sender, EventArgs e)
        {
            SelectAllTourists();

        }
    }
}
