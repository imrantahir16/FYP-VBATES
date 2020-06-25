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
    public partial class LogIn : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
        public static String classify;



        public LogIn()
        {
            InitializeComponent();

            change_text();
        }
        public void change_text()
        {
            if (Jarvis.Classifier == "Sign Up")
            {
                LoginBtn.Text = "Sign Up";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            classify = LoginBtn.Text;
            if (Jarvis.Classifier == "Log In As Employee")
            {
                string query = "Select * from all_users Where user_name ='" + U_name.Text + "' And password ='" + password.Text + "'";
                connection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Employee accountant = new Employee();
                    this.Visible = false;
                    accountant.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please check your User Name and Password");
                }
                connection.Close();

            }
            if (Jarvis.Classifier == "Log In As Admin")
            {
                string query = "Select * from all_users Where user_name ='" + U_name.Text + "' And password ='" + password.Text + "'";
                connection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Administrator administrator = new Administrator();
                    this.Visible = false;
                    administrator.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please check your User Name and Password");
                }

                connection.Close();
            }
                
                if (Jarvis.Classifier == "Sign Up")
                {
                    string insertQuery = "INSERT INTO database.all_users (user_name, password) VALUES ('" + U_name.Text + "','" + password.Text + "')";
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
                if(Jarvis.Classifier== "Log In As User")
                {
                string query = "Select * from all_users Where user_name ='" + U_name.Text + "' And password ='" + password.Text + "'";
                connection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Info info = new Info();
                    this.Visible = false;
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please check your User Name and Password");
                }

                connection.Close();
            }


            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Jarvis jarvis = new Jarvis();
            this.Visible = false;
            jarvis.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
