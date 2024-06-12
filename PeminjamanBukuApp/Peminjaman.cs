using System;
using System.Diagnostics.Contracts;

namespace PeminjamanBukuApp
{
    public class Peminjaman
    {
        public string NamaPeminjam { get; set; }
        public string JudulBuku { get; set; }
        public DateTime TanggalPeminjaman { get; set; }

        public Peminjaman(string namaPeminjam, string judulBuku, DateTime tanggalPeminjaman)
        {
            NamaPeminjam = namaPeminjam;
            Contract.Requires(!string.IsNullOrEmpty(judulBuku), "Judul buku tidak boleh kosong");
            JudulBuku = judulBuku;
            Contract.Ensures(TanggalPeminjaman == tanggalPeminjaman, "Tanggal peminjaman tidak valid");
            TanggalPeminjaman = tanggalPeminjaman;
        }
    }
}
