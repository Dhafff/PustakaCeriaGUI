﻿using System;
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
    public partial class StastikaBuku : Form
    {

        public class Buku
        {
            public string Id { get; set; }
            public string Judul { get; set; }
            public string Penulis { get; set; }
            public string Genre { get; set; }
            public int JumlahPeminjaman { get; set; }
        }
        public StastikaBuku()
        {
            InitializeComponent();
            this.Load += new EventHandler(StatistikaBuku_Load);

        }

        private void StatistikaBuku_Load(object sender, EventArgs e)
        {
            try
            {
                // Isi data ke dalam DataGridView saat form dimuat
                dataGridView1.Rows.Clear();

                // Buat daftar buku dengan data yang valid
                List<Buku> bukuList = new List<Buku>()
                {
                     new Buku { Id = "1", Judul = "Laskar Pelangi", Penulis = "Andrea Hirata", Genre = "Fiksi", JumlahPeminjaman = 5 },
                     new Buku { Id = "2", Judul = "Bumi Manusia", Penulis = "Pramoedya Ananta Toer", Genre = "Fiksi", JumlahPeminjaman = 6 },
                     new Buku { Id = "3", Judul = "Dilan 1990", Penulis = "Pidi Baiq", Genre = "Fiksi", JumlahPeminjaman = 10 },
                     new Buku { Id = "4", Judul = "Koala Kumal", Penulis = "Raditya Dika", Genre = "Fiksi", JumlahPeminjaman = 12 },
                     new Buku { Id = "5", Judul = "5 Cm", Penulis = "Dhonny Dhirgantoro", Genre = "Fiksi", JumlahPeminjaman = 20 },
                     new Buku { Id = "6", Judul = "Autobiografi Tan Malaka: Dari Penjara Ke Penjara", Penulis = "Tan Malaka", Genre = "Non-Fiksi", JumlahPeminjaman = 15 },
                     new Buku { Id = "7", Judul = "Atomic Habits", Penulis = "James Clear", Genre = "Non-Fiksi", JumlahPeminjaman = 10 },
                     new Buku { Id = "8", Judul = "Soekarno: Biografi Singkat 1901-1970", Penulis = "Taufik Adi Susilo", Genre = "Non-Fiksi", JumlahPeminjaman = 5 },
                     new Buku { Id = "9", Judul = "Rudy: Kisah Masa Muda Sang Visioner", Penulis = "Gina S. Noer", Genre = "Non-Fiksi", JumlahPeminjaman = 20 },
                     new Buku { Id = "10", Judul = "Autobiografi Mahatma Gandhi", Penulis = "Mahatma Gandhi", Genre = "Non-Fiksi", JumlahPeminjaman = 2 },
                };

                // Tambahkan data buku ke dalam DataGridView
                foreach (var buku in bukuList)
                {
                    dataGridView1.Rows.Add(buku.Id, buku.Judul, buku.Penulis, buku.Genre, buku.JumlahPeminjaman);
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan dan tampilkan pesan kesalahan kepada pengguna
                MessageBox.Show("Terjadi kesalahan saat memuat data buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Melakukan Input Judul
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string judulBuku = textBox1.Text.ToLower();
            dataGridView1.Rows.Clear();

            List<Buku> bukuList = new List<Buku>()
            {
                new Buku { Id = "1", Judul = "Laskar Pelangi", Penulis = "Andrea Hirata", Genre = "Fiksi", JumlahPeminjaman = 5 },
                new Buku { Id = "2", Judul = "Bumi Manusia", Penulis = "Pramoedya Ananta Toer", Genre = "Fiksi", JumlahPeminjaman = 6 },
                new Buku { Id = "3", Judul = "Dilan 1990", Penulis = "Pidi Baiq", Genre = "Fiksi", JumlahPeminjaman = 10 },
                new Buku { Id = "4", Judul = "Koala Kumal", Penulis = "Raditya Dika", Genre = "Fiksi", JumlahPeminjaman = 12 },
                new Buku { Id = "5", Judul = "5 Cm", Penulis = "Dhonny Dhirgantoro", Genre = "Fiksi", JumlahPeminjaman = 20 },
                new Buku { Id = "7", Judul = "Atomic Habits", Penulis = "James Clear", Genre = "Non-Fiksi", JumlahPeminjaman = 10 },
                new Buku { Id = "8", Judul = "Soekarno: Biografi Singkat 1901-1945", Penulis = "Taufik Adi Susilo", Genre = "Non-Fiksi", JumlahPeminjaman = 5 },
                new Buku { Id = "9", Judul = "Rudy: Kisah Masa Muda Sang Visioner", Penulis = "Gina S. Noer", Genre = "Non-Fiksi", JumlahPeminjaman = 5 },
                new Buku { Id = "10", Judul = "Autobiografi Mahatma Gandhi", Penulis = "Mahatma Gandhi", Genre = "Non-Fiksi", JumlahPeminjaman = 22 },
            };
            //Melakukan Filter Buku sesuai Judul
            var filteredBuku = bukuList.Where(b => b.Judul.ToLower().Contains(judulBuku));


            if (filteredBuku.Any())
            {
                foreach (var buku in filteredBuku)
                {
                    dataGridView1.Rows.Add(buku.Id, buku.Judul, buku.Penulis, buku.Genre, buku.JumlahPeminjaman);
                }
            }
            //Memberikan Pesan bahwa Judul Buku tidak sesuai dengan yang dicari
            else
            {
                MessageBox.Show("Tidak ada Judul Buku yang sesuai dengan yang Anda masukkan.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tanggal = dateTimePicker1.Value;
            dataGridView1.Rows.Clear();
            if (tanggal.DayOfWeek == DayOfWeek.Monday)
            {
                dataGridView1.Rows.Add("1", "Laskar Pelangi", "Andrea Hirata", "Fiksi", "5");
                dataGridView1.Rows.Add("2", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", "6");
            }
            else if (tanggal.DayOfWeek == DayOfWeek.Tuesday)
            {
                dataGridView1.Rows.Add("3", "Dilan 1990", "Pidi Baiq", "Fiksi", "10");
                dataGridView1.Rows.Add("4", "Koala Kumal", "Raditya Dika", "Fiksi", "12");
            }
            else
            {
                dataGridView1.Rows.Add("5", "5 Cm", "Dhonny Dhirgantoro", "Fiksi", "20");
            }
        }

        private void StastikaBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
