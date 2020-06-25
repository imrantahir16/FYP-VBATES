using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Speech_Recognition
{
    public partial class Administrator : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
        String showform;
        public Administrator()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM employee";
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user_info";
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO database.employee (fullname, cnic,phone,address) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            connection.Open();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM schedule";
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }
    }
}
