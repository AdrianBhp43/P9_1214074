using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214074
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataMahasiswaItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); 
            f1.Show();
            this.Close();
        }

        private void AboutMeItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama : Adrian Bimo Hernawan Pratama" + 
                "\n NPM : 1214074" + "\n Prodi : D4 Teknik Informatika" + "\n Kelas : 2C");
        }
    }
}
