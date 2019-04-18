namespace NorthWindEF.UI
{
    partial class MainForm
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
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.siparişToolStripMenuItem,
            this.ürünToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelToolStripMenuItem,
            this.personelListesiToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // yeniPersonelToolStripMenuItem
            // 
            this.yeniPersonelToolStripMenuItem.Name = "yeniPersonelToolStripMenuItem";
            this.yeniPersonelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeniPersonelToolStripMenuItem.Text = "Yeni Personel";
            this.yeniPersonelToolStripMenuItem.Click += new System.EventHandler(this.yeniPersonelToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparişToolStripMenuItem,
            this.siparişListesiToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            // 
            // yeniSiparişToolStripMenuItem
            // 
            this.yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            this.yeniSiparişToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünToolStripMenuItem,
            this.ürünListesiToolStripMenuItem});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // yeniÜrünToolStripMenuItem
            // 
            this.yeniÜrünToolStripMenuItem.Name = "yeniÜrünToolStripMenuItem";
            this.yeniÜrünToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.yeniÜrünToolStripMenuItem.Text = "Yeni Ürün";
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Northwind";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
    }
}

