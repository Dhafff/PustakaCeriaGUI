using ManajemenBukuLibrary;
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
    public partial class FormManajemenBuku : Form
    {
        private readonly IBookFactory bookFactory;
        private List<Buku> books;

        public FormManajemenBuku(IBookFactory bookFactory)
        {
            InitializeComponent();
            this.bookFactory = bookFactory;
            books = new List<Buku>();
            InitializeDataGridView();
            LoadBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var selectedBook = books[e.RowIndex];
                    using (var form = new FormEditBuku(selectedBook))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells["Judul"].Value = selectedBook.Judul;
                            dataGridView1.Rows[e.RowIndex].Cells["Penulis"].Value = selectedBook.Penulis;
                            dataGridView1.Rows[e.RowIndex].Cells["Genre"].Value = selectedBook.Genre;
                        }
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    books.RemoveAt(e.RowIndex);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void buttonTambahBuku_Click(object sender, EventArgs e)
        {
            using (var form = new FormTambahBuku())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newBook = form.BukuBaru;
                    books.Add(newBook);
                    dataGridView1.Rows.Add(newBook.Judul, newBook.Penulis, newBook.Genre);
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Judul";
            dataGridView1.Columns[1].Name = "Penulis";
            dataGridView1.Columns[2].Name = "Genre";

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "Hapus";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnHapus);
        }

        private void LoadBooks()
        {
            try
            {
                books = bookFactory.LoadBooks("../../../Buku.json");
                foreach (var book in books)
                {
                    dataGridView1.Rows.Add(book.Judul, book.Penulis, book.Genre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }
    }
}
