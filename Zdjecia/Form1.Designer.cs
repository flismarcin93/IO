namespace Zdjecia
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrazek = new Zdjecia.MyPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.obrazek.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "zakoncz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "nastepny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 21);
            this.button3.TabIndex = 5;
            this.button3.Text = "poprzedni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(118, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 19);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(533, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(496, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 19);
            this.button8.TabIndex = 9;
            this.button8.Text = "sprawdź";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrazek
            // 
            this.obrazek.AutoScroll = true;
            this.obrazek.Controls.Add(this.button8);
            this.obrazek.Controls.Add(this.textBox1);
            this.obrazek.Controls.Add(this.label3);
            this.obrazek.Controls.Add(this.label2);
            this.obrazek.Controls.Add(this.button7);
            this.obrazek.Controls.Add(this.button5);
            this.obrazek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obrazek.Location = new System.Drawing.Point(0, 24);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(606, 296);
            this.obrazek.TabIndex = 0;
            this.obrazek.Paint += new System.Windows.Forms.PaintEventHandler(this.obrazek_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Twoje punkty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(533, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 27);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 320);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Gra Edukacyjna";
            this.obrazek.ResumeLayout(false);
            this.obrazek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyPictureBox obrazek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

