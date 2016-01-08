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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoominToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazek = new Zdjecia.MyPictureBox();
            this.nastepnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otworzToolStripMenuItem,
            this.nastepnyToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "plik";
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otworzToolStripMenuItem.Text = "otworz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click_1);
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
            // obrazek
            // 
            this.obrazek.AutoScroll = true;
            this.obrazek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obrazek.Location = new System.Drawing.Point(0, 24);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(284, 237);
            this.obrazek.TabIndex = 0;
            this.obrazek.Paint += new System.Windows.Forms.PaintEventHandler(this.obrazek_Paint);
            // 
            // nastepnyToolStripMenuItem
            // 
            this.nastepnyToolStripMenuItem.Name = "nastepnyToolStripMenuItem";
            this.nastepnyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nastepnyToolStripMenuItem.Text = "nastepny";
            this.nastepnyToolStripMenuItem.Click += new System.EventHandler(this.nastepnyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Zdjecia";
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
    }
}

