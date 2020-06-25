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
    public partial class Info : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
     
        public Info()
        {
            InitializeComponent();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Jarvis jarvis = new Jarvis();
            this.Visible = false;
            jarvis.ShowDialog();
        }

        private void SelectPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Info_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM schedule";
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            Seat_reservation sr = new Seat_reservation();
            this.Visible = false;
            sr.ShowDialog();
        }
    }
}
