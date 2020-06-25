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
    public partial class Seat_reservation : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
        public Seat_reservation()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            this.Visible = false;
            info.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO database.user_info (Name, departure, Destenation, Seat,Phone_Number) VALUES ('" + U_name.Text + "','" + U_departure.Text + "','" + U_destenation.Text + "','" + no_seats.Text + "','"+ phone.Text +"')";
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
    }
}
