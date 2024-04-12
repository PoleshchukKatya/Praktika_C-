using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Колледж\C#\Glava32\DBTur_firm.accdb";
        public Form1()
        {
            InitializeComponent();
            InitializeDataSet();
        }
        private void InitializeDataSet()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    DataSet databaseDataSet = new DataSet();

                    DataTable touristsDataTable = new DataTable("Туристы");
                    DataTable touristInfoDataTable = new DataTable("Информация о туристах");
                    DataTable toursDataTable = new DataTable("Туры");
                    DataTable seasonsDataTable = new DataTable("Сезоны");
                    DataTable vouchersDataTable = new DataTable("Путевки");
                    DataTable paymentsDataTable = new DataTable("Оплата");

                    FillDataTable("SELECT * FROM Туристы;", touristsDataTable, connection);
                    FillDataTable("SELECT * FROM [Информация о туристах];", touristInfoDataTable, connection);
                    FillDataTable("SELECT * FROM Туры;", toursDataTable, connection);
                    FillDataTable("SELECT * FROM Сезоны;", seasonsDataTable, connection);
                    FillDataTable("SELECT * FROM Путевки;", vouchersDataTable, connection);
                    FillDataTable("SELECT * FROM Оплата;", paymentsDataTable, connection);

                    databaseDataSet.Tables.Add(touristsDataTable);
                    databaseDataSet.Tables.Add(touristInfoDataTable);
                    databaseDataSet.Tables.Add(toursDataTable);
                    databaseDataSet.Tables.Add(seasonsDataTable);
                    databaseDataSet.Tables.Add(vouchersDataTable);
                    databaseDataSet.Tables.Add(paymentsDataTable);

                    dataGridViewTourists.DataSource = touristsDataTable;
                    dataGridViewTouristInfo.DataSource = touristInfoDataTable;
                    dataGridViewTours.DataSource = toursDataTable;
                    dataGridViewSeasons.DataSource = seasonsDataTable;
                    dataGridViewVouchers.DataSource = vouchersDataTable;
                    dataGridViewPayments.DataSource = paymentsDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при инициализации DataSet: {ex.Message}");
            }
        }
        private void FillDataTable(string query, DataTable table, OleDbConnection connection)
        {
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнении DataTable: {ex.Message}");
            }
        }

    }
}
