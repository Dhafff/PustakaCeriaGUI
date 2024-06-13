using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManajemenBukuLibrary;

namespace PustakaCeriaGUI
{
    public partial class FormTambahBuku : Form
    {
        public Buku BukuBaru { get; private set; }

        public FormTambahBuku()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BukuBaru = new Buku
            {
                Judul = textBox1.Text,
                Penulis = textBox2.Text,
                Genre = textBox3.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
