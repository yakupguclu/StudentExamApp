namespace OgrenciSinav
{
    partial class OgretmenForm
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
            this.msNavbar = new System.Windows.Forms.MenuStrip();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavbar
            // 
            this.msNavbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNavbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem,
            this.sorularToolStripMenuItem});
            this.msNavbar.Location = new System.Drawing.Point(0, 0);
            this.msNavbar.Name = "msNavbar";
            this.msNavbar.Size = new System.Drawing.Size(1223, 28);
            this.msNavbar.TabIndex = 1;
            this.msNavbar.Text = "menuStrip1";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciListeleToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ogrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.öğrenciListeleToolStripMenuItem.Text = "ÖğrenciListele";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // sorularToolStripMenuItem
            // 
            this.sorularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soruİşlemleriToolStripMenuItem});
            this.sorularToolStripMenuItem.Name = "sorularToolStripMenuItem";
            this.sorularToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sorularToolStripMenuItem.Text = "Sorular";
            // 
            // soruİşlemleriToolStripMenuItem
            // 
            this.soruİşlemleriToolStripMenuItem.Name = "soruİşlemleriToolStripMenuItem";
            this.soruİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.soruİşlemleriToolStripMenuItem.Text = "Soru İşlemleri";
            this.soruİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.soruİşlemleriToolStripMenuItem_Click);
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 560);
            this.Controls.Add(this.msNavbar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msNavbar;
            this.MaximizeBox = false;
            this.Name = "OgretmenForm";
            this.Text = "OgretmenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msNavbar.ResumeLayout(false);
            this.msNavbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavbar;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruİşlemleriToolStripMenuItem;
    }
}