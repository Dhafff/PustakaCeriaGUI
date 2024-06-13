namespace PustakaCeriaGUI
{
    partial class FormManajemenBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Judul = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            buttonTambahBuku = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Blue;
            splitContainer1.Panel1.Controls.Add(button10);
            splitContainer1.Panel1.Controls.Add(button9);
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(button7);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.HighlightText;
            splitContainer1.Panel2.Controls.Add(buttonTambahBuku);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1056, 675);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 1;
            // 
            // button10
            // 
            button10.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(33, 525);
            button10.Name = "button10";
            button10.Size = new Size(195, 37);
            button10.TabIndex = 11;
            button10.Text = "Pengaturan";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(231, 41, 41);
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(33, 610);
            button9.Name = "button9";
            button9.Size = new Size(195, 37);
            button9.TabIndex = 10;
            button9.Text = "Keluar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(33, 472);
            button8.Name = "button8";
            button8.Size = new Size(195, 37);
            button8.TabIndex = 9;
            button8.Text = "Notifikasi";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(33, 419);
            button7.Name = "button7";
            button7.Size = new Size(195, 37);
            button7.TabIndex = 8;
            button7.Text = "Manajemen anggota";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(33, 367);
            button6.Name = "button6";
            button6.Size = new Size(195, 37);
            button6.TabIndex = 7;
            button6.Text = "Statistik buku";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(33, 317);
            button5.Name = "button5";
            button5.Size = new Size(195, 37);
            button5.TabIndex = 6;
            button5.Text = "Riwayat peminjaman";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(33, 265);
            button4.Name = "button4";
            button4.Size = new Size(195, 37);
            button4.TabIndex = 5;
            button4.Text = "Manajemen buku";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(33, 212);
            button3.Name = "button3";
            button3.Size = new Size(195, 37);
            button3.TabIndex = 4;
            button3.Text = "Pencarian buku";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(33, 159);
            button2.Name = "button2";
            button2.Size = new Size(195, 37);
            button2.TabIndex = 3;
            button2.Text = "Peminjaman buku";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(33, 106);
            button1.Name = "button1";
            button1.Size = new Size(195, 37);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 49);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(33, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 0;
            label2.Text = "Selamat datang,";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Judul, Penulis, Genre, Edit, Hapus });
            dataGridView1.Location = new Point(30, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 281);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 0;
            label1.Text = "Manajemen Buku";
            // 
            // Judul
            // 
            Judul.HeaderText = "Judul";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
            Judul.Width = 125;
            // 
            // Penulis
            // 
            Penulis.HeaderText = "Penulis";
            Penulis.MinimumWidth = 6;
            Penulis.Name = "Penulis";
            Penulis.Width = 125;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.ToolTipText = "Edit";
            Edit.Width = 125;
            // 
            // Hapus
            // 
            Hapus.HeaderText = "Hapus";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Resizable = DataGridViewTriState.True;
            Hapus.SortMode = DataGridViewColumnSortMode.Automatic;
            Hapus.Width = 125;
            // 
            // buttonTambahBuku
            // 
            buttonTambahBuku.Location = new Point(30, 375);
            buttonTambahBuku.Name = "buttonTambahBuku";
            buttonTambahBuku.Size = new Size(177, 42);
            buttonTambahBuku.TabIndex = 2;
            buttonTambahBuku.Text = "Tambah";
            buttonTambahBuku.UseVisualStyleBackColor = true;
            buttonTambahBuku.Click += buttonTambahBuku_Click;
            // 
            // FormManajemenBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 675);
            Controls.Add(splitContainer1);
            Name = "FormManajemenBuku";
            Text = "FormManajemenBuku";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button buttonTambahBuku;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}