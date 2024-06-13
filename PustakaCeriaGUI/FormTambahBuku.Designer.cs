namespace PustakaCeriaGUI
{
    partial class FormTambahBuku
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 32);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "Tambah Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Judul";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 225);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Penulis";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 150);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 334);
            button1.Name = "button1";
            button1.Size = new Size(356, 46);
            button1.TabIndex = 7;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTambahBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTambahBuku";
            Text = "FormTambahBuku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}