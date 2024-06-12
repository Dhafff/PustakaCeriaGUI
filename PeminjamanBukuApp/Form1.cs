using System;
using System.Windows.Forms;

namespace PeminjamanBukuApp
{
    public partial class Form1 : Form
    {
        private RiwayatPeminjaman riwayatPeminjaman;

        public Form1()
        {
            InitializeComponent();
            riwayatPeminjaman = new RiwayatPeminjaman();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = riwayatPeminjaman.GetRiwayat();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string namaPeminjam = txtNamaPeminjam.Text;
            string judulBuku = txtJudulBuku.Text;
            DateTime tanggalPeminjaman = dateTimePicker1.Value;

            riwayatPeminjaman.TambahPeminjaman(namaPeminjam, judulBuku, tanggalPeminjaman);
            LoadData();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
