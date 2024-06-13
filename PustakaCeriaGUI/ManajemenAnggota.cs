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
    public partial class ManajemenAnggota : Form
    {
        public class Anggota
        {
            public string Id { get; set; }
            public string Nama { get; set; }
            public string Nohp { get; set; }
            public string Alamat { get; set; }
            public string Email { get; set; }
        }

        public ManajemenAnggota()
        {
            InitializeComponent();
            this.Load += new EventHandler(ManajemenAnggota_Load);
        }

        private void ManajemenAnggota_Load(object sender, EventArgs e)
        {
            // Isi data ke dalam DataGridView saat form dimuat
            dataGridView1.Rows.Clear();
            List<Anggota> anggotaList = new List<Anggota>()
            {
                new Anggota { Id = "1", Nama = "Ali", Nohp = "08123456789", Alamat = "Jl. Merdeka No.1", Email = "ali@example.com" },
                new Anggota { Id = "2", Nama = "Budi", Nohp = "08123456780", Alamat = "Jl. Merdeka No.2", Email = "budi@example.com" },
                new Anggota { Id = "3", Nama = "Cici", Nohp = "08123456781", Alamat = "Jl. Merdeka No.3", Email = "cici@example.com" },
                new Anggota { Id = "4", Nama = "Dodi", Nohp = "08123456782", Alamat = "Jl. Merdeka No.4", Email = "dodi@example.com" },
                new Anggota { Id = "5", Nama = "Eka", Nohp = "08123456783", Alamat = "Jl. Merdeka No.5", Email = "eka@example.com" },
            };

            foreach (var anggota in anggotaList)
            {
                dataGridView1.Rows.Add(anggota.Id, anggota.Nama, anggota.Nohp, anggota.Alamat, anggota.Email);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string namaAnggota = textBox1.Text.ToLower();
            dataGridView1.Rows.Clear();

            List<Anggota> anggotaList = new List<Anggota>()
            {
                new Anggota { Id = "1", Nama = "Ali", Nohp = "08123456789", Alamat = "Jl. Merdeka No.1", Email = "ali@example.com" },
                new Anggota { Id = "2", Nama = "Budi", Nohp = "08123456780", Alamat = "Jl. Merdeka No.2", Email = "budi@example.com" },
                new Anggota { Id = "3", Nama = "Cici", Nohp = "08123456781", Alamat = "Jl. Merdeka No.3", Email = "cici@example.com" },
                new Anggota { Id = "4", Nama = "Dodi", Nohp = "08123456782", Alamat = "Jl. Merdeka No.4", Email = "dodi@example.com" },
                new Anggota { Id = "5", Nama = "Eka", Nohp = "08123456783", Alamat = "Jl. Merdeka No.5", Email = "eka@example.com" },
                new Anggota { Id = "6", Nama = "iki", Nohp = "08123456789", Alamat = "Jl. Merdeka No.6", Email = "iki@example.com" },
                new Anggota { Id = "7", Nama = "daus", Nohp = "08123456780", Alamat = "Jl. Merdeka No.7", Email = "daus@example.com" },
                new Anggota { Id = "8", Nama = "rifky", Nohp = "08123456781", Alamat = "Jl. Merdeka No.8", Email = "rifky@example.com" },
                new Anggota { Id = "9", Nama = "firdaus", Nohp = "08123456782", Alamat = "Jl. Merdeka No.9", Email = "firdaus@example.com" },
                new Anggota { Id = "10", Nama = "ara", Nohp = "08123456783", Alamat = "Jl. Merdeka No.10", Email = "ara@example.com" },
            };

            var filteredAnggota = anggotaList.Where(a => a.Nama.ToLower().Contains(namaAnggota));

            if (filteredAnggota.Any())
            {
                foreach (var anggota in filteredAnggota)
                {
                    dataGridView1.Rows.Add(anggota.Id, anggota.Nama, anggota.Nohp, anggota.Alamat, anggota.Email);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada Nama Anggota yang sesuai dengan yang Anda masukkan.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tambah_anggota_Click(object sender, EventArgs e)
        {
            
        }
    }
}
