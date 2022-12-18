using MySql.Data.MySqlClient;
using P9_1214074.controller;
using P9_1214074.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9_1214074
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        string koneksi = "datasource=127.0.0.1;port=3306;username=root;password=;database=ulbi;";

        public void login()
        {
            string query = "SELECT * FROM user WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'";

            // Connecting MySql
            MySqlConnection databaseConnection = new MySqlConnection(koneksi);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                   MessageBox.Show("Login Berhasil");
                   ParentForm pf = new ParentForm();
                   pf.Show();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / Password salah, silahkan ulangi kembali");
                }
                databaseConnection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Silahkan coba kembali");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
