namespace PustakaCeriaGUI
{
    partial class FormEditBuku
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(34, 348);
            button1.Name = "button1";
            button1.Size = new Size(356, 46);
            button1.TabIndex = 15;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 164);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 239);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 10;
            label3.Text = "Penulis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 90);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 9;
            label2.Text = "Judul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 8;
            label1.Text = "Edit Buku";
            // 
            // FormEditBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditBuku";
            Text = "FormEditBuku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}