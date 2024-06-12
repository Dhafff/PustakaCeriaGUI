using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace PeminjamanBukuApp
{
    public class RiwayatPeminjaman
    {
        private List<Peminjaman> riwayatPeminjaman = new List<Peminjaman>();

        public RiwayatPeminjaman()
        {
            TambahRiwayat();
        }

        private void TambahRiwayat()
        {
            string[,] dataPeminjaman = new string[,]
            {
                { "John Doe", "Introduction to Programming", "2024-04-01" },
                { "Jane Smith", "Data Structures and Algorithms", "2024-04-05" },
                { "Alice Johnson", "Database Management Systems", "2024-04-10" }
            };

            for (int i = 0; i < dataPeminjaman.GetLength(0); i++)
            {
                string namaPeminjam = dataPeminjaman[i, 0];
                string judulBuku = dataPeminjaman[i, 1];
                DateTime tanggalPeminjaman = DateTime.Parse(dataPeminjaman[i, 2]);

                Contract.Requires(tanggalPeminjaman <= DateTime.Now, "Tanggal peminjaman tidak valid");
                Contract.Ensures(!string.IsNullOrEmpty(judulBuku), "Judul buku tidak boleh kosong");

                riwayatPeminjaman.Add(new Peminjaman(namaPeminjam, judulBuku, tanggalPeminjaman));
            }
        }

        public List<Peminjaman> GetRiwayat()
        {
            return riwayatPeminjaman;
        }

        public void TambahPeminjaman(string namaPeminjam, string judulBuku, DateTime tanggalPeminjaman)
        {
            riwayatPeminjaman.Add(new Peminjaman(namaPeminjam, judulBuku, tanggalPeminjaman));
        }
    }
}
