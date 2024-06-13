using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PustakaCeriaGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Membuat instansiasi dari form StatistikaBuku
            StastikaBuku statistikBukuForm = new StastikaBuku();
            statistikBukuForm.TopLevel = false;
            statistikBukuForm.FormBorderStyle = FormBorderStyle.None;
            statistikBukuForm.Dock = DockStyle.Fill;

            // Membersihkan kontrol sebelumnya di Panel2
            splitContainer1.Panel2.Controls.Clear();

            // Menambahkan form StatistikaBuku ke Panel2
            splitContainer1.Panel2.Controls.Add(statistikBukuForm);
            statistikBukuForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
