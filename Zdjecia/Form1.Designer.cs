﻿namespace Zdjecia
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastepnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poprzedniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoominToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.obrazek = new Zdjecia.MyPictureBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logowanieToolStripMenuItem,
            this.otworzToolStripMenuItem,
            this.nastepnyToolStripMenuItem,
            this.poprzedniToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "plik";
            // 
            // logowanieToolStripMenuItem
            // 
            this.logowanieToolStripMenuItem.Name = "logowanieToolStripMenuItem";
            this.logowanieToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.logowanieToolStripMenuItem.Text = "Rozpocznij";
            this.logowanieToolStripMenuItem.Click += new System.EventHandler(this.logowanieToolStripMenuItem_Click);
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.otworzToolStripMenuItem.Text = "otworz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click_1);
            // 
            // nastepnyToolStripMenuItem
            // 
            this.nastepnyToolStripMenuItem.Name = "nastepnyToolStripMenuItem";
            this.nastepnyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.nastepnyToolStripMenuItem.Text = "nastepny";
            this.nastepnyToolStripMenuItem.Click += new System.EventHandler(this.nastepnyToolStripMenuItem_Click);
            // 
            // poprzedniToolStripMenuItem
            // 
            this.poprzedniToolStripMenuItem.Name = "poprzedniToolStripMenuItem";
            this.poprzedniToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.poprzedniToolStripMenuItem.Text = "poprzedni";
            this.poprzedniToolStripMenuItem.Click += new System.EventHandler(this.poprzedniToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoominToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.opcjeToolStripMenuItem.Text = "opcje";
            // 
            // zoominToolStripMenuItem
            // 
            this.zoominToolStripMenuItem.Name = "zoominToolStripMenuItem";
            this.zoominToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zoominToolStripMenuItem.Text = "zoomin";
            this.zoominToolStripMenuItem.Click += new System.EventHandler(this.zoominToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zoomOutToolStripMenuItem.Text = "zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "zakoncz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // obrazek
            // 
            this.obrazek.AutoScroll = true;
            this.obrazek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obrazek.Location = new System.Drawing.Point(0, 24);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(460, 237);
            this.obrazek.TabIndex = 0;
            this.obrazek.Paint += new System.Windows.Forms.PaintEventHandler(this.obrazek_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Gra Edukacyjna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyPictureBox obrazek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoominToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastepnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poprzedniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logowanieToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
    }
}

