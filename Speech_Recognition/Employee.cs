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
    public partial class Employee : Form
    {
        MySqlConnection connection=new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
        public Employee()
        {
            InitializeComponent();
           
        }
        
        private void Save_Changes_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO database.schedule (busID, trevalingclass, departure, arrival,total_seats,date) VALUES ('" + bus_id.Text + "','" + trevaling_class.Text + "','" + departure.Text + "','" + arrival.Text + "','"+ textBox1.Text +"','"+dateTimePicker1.Value.ToString()+"')";
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM schedule";
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Visible = false;
            log.ShowDialog();
        }
    }
}
