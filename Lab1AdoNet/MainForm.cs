using Npgsql;
using Npgsql.Internal;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1AdoNet
{
    public partial class MainForm : Form
    {
        #region Строка подключения к БД

        private string connectionString;

        #endregion

        #region Объекты NpgsqlDataAdapter

        private NpgsqlDataAdapter agentAdapter;
        private NpgsqlDataAdapter dealAdapter;
        private NpgsqlDataAdapter clientAdapter;
        private NpgsqlDataAdapter estateAdapter;

        #endregion

        #region Объекты NpgsqlCommandBuilder

        private NpgsqlCommandBuilder agentBuilder;
        private NpgsqlCommandBuilder dealBuilder;

        #endregion

        #region Объект DataSet

        private DataSet dataSet = new DataSet();

        #endregion

        public MainForm()
        {
            InitializeComponent();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            agentAdapter = new NpgsqlDataAdapter("SELECT agent_id, deal_count, bonus_count FROM agents;", connectionString);
            dealAdapter = new NpgsqlDataAdapter("SELECT deal_id, estate_id, deal_pay, deal_date, deal_payment_type, rassrochka, client_id, agent_id FROM deals;", connectionString);
            clientAdapter = new NpgsqlDataAdapter("SELECT client_id, client_name, client_phone, client_type FROM clients;", connectionString);
            estateAdapter = new NpgsqlDataAdapter("SELECT estate_id, estate_type, estate_address FROM estate;", connectionString);

            // Автоматическая генерация команд SQL.
            agentBuilder = new NpgsqlCommandBuilder(agentAdapter);
            dealBuilder = new NpgsqlCommandBuilder(dealAdapter);

            // Заполнение таблиц в DataSet.
            agentAdapter.Fill(dataSet, "agents");
            dealAdapter.Fill(dataSet, "deals");
            clientAdapter.Fill(dataSet, "clients");
            estateAdapter.Fill(dataSet, "estate");

            // Связывание элементов управления с данными.
            dataGridViewAgents.DataSource = dataSet.Tables["agents"];
            dataGridViewDeals.DataSource = dataSet.Tables["deals"];

            // Заполнение комбобоксов.
            
            FillReport1Combobox(); 
        
    }

        private void FillReport1Combobox()
        {
            using (var sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("SELECT * FROM estate", sqlConnection);

                // Заполнение dataSet данными из sqlAdapter.
                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "estate");

                // Связывание комбобокса cbSupplier с таблицей suppliers из dataSet.
                comboBoxReport1.DataSource = dataSet.Tables["estate"];
                comboBoxReport1.DisplayMember = "estate_address";
                comboBoxReport1.ValueMember = "estate_id";
            }
        }
      


        /// <summary>
        /// Сохранить изменения в таблице material.
        /// </summary>
        private void buttonSavePhone_Click(object sender, EventArgs e)
        {
            agentAdapter.Update(dataSet, "agents");
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                sqlConnection.Open();
                NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT d.deal_date, d.deal_pay, c.client_name, e.estate_address " +
                                                              "FROM deals d " +
                                                              "JOIN clients c ON d.client_id = c.client_id " +
                                                              "JOIN estate e ON d.estate_id = e.estate_id " +
                                                              "WHERE c.client_id = @ClientId", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ClientId", comboBoxReport1.SelectedValue);

                NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("report");
                dataTable.Columns.Add("deal_date");
                dataTable.Columns.Add("deal_pay");
                dataTable.Columns.Add("client_name");
                dataTable.Columns.Add("estate_address");

                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["deal_date"] = sqlDataReader["deal_date"];
                    row["deal_pay"] = sqlDataReader["deal_pay"];
                    row["client_name"] = sqlDataReader["client_name"];
                    row["estate_address"] = sqlDataReader["estate_address"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
                dataGridViewReport1.DataSource = dataTable;
            }
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT * FROM get_deals_by_date(@Month, @Year)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Month", (int)numericUpDown1.Value);
                sqlCommand.Parameters.AddWithValue("@Year", (int)numericUpDown2.Value);

                sqlConnection.Open();
                sqlCommand.Prepare();
                DataTable dataTable = new DataTable("reportByDate");
                NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataTable);

                dataGridViewReport2.DataSource = dataTable;
            }

        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            dealAdapter.Update(dataSet, "deals");
        }
    }
}
