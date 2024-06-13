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
    public partial class FormEditBuku : Form
    {
        private Buku buku;

        public FormEditBuku(Buku buku)
        {
            InitializeComponent();
            this.buku = buku;
            textBox1.Text = buku.Judul;
            textBox2.Text = buku.Penulis;
            textBox3.Text = buku.Genre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buku.Judul = textBox1.Text;
            buku.Penulis = textBox2.Text;
            buku.Genre = textBox3.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
