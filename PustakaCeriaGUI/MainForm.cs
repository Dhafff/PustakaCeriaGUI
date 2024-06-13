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
        private readonly IBookFactory bookFactory;
        private readonly UserValidatorFactory _userValidatorFactory;

        public MainForm(UserValidatorFactory userValidatorFactory, IBookFactory bookFactory)
        {
            InitializeComponent();
            this.bookFactory = bookFactory;
            _userValidatorFactory = userValidatorFactory;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonPeminjamanBuku_Click(object sender, EventArgs e)
        {

        }

        private void buttonPencarianBuku_Click(object sender, EventArgs e)
        {

        }

        private void buttonManajemenBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formManejemenBuku = new FormManajemenBuku(bookFactory);
            formManejemenBuku.FormClosing += FormManajemenBuku_FormClosing;
            formManejemenBuku.Show();
        }

        private void FormManajemenBuku_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show(); // Tampilkan kembali MainForm saat FormManajemenBuku ditutup
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatistikBuku_Click(object sender, EventArgs e)
        {

        }

        private void buttonManajemenAnggota_Click(object sender, EventArgs e)
        {

        }

        private void buttonNotifikasi_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formLogin = new FormLogin(_userValidatorFactory, bookFactory);
        }
    }
}
