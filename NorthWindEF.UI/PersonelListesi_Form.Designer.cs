namespace NorthWindEF.UI
{
    partial class PersonelListesi_Form
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
            this.components = new System.ComponentModel.Container();
            this.dgw_PersonelListesi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaydıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_PersonelListesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_PersonelListesi
            // 
            this.dgw_PersonelListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_PersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_PersonelListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgw_PersonelListesi.Location = new System.Drawing.Point(12, 12);
            this.dgw_PersonelListesi.Name = "dgw_PersonelListesi";
            this.dgw_PersonelListesi.RowTemplate.Height = 24;
            this.dgw_PersonelListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_PersonelListesi.Size = new System.Drawing.Size(763, 426);
            this.dgw_PersonelListesi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydıGüncelleToolStripMenuItem,
            this.kaydıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // kaydıGüncelleToolStripMenuItem
            // 
            this.kaydıGüncelleToolStripMenuItem.Name = "kaydıGüncelleToolStripMenuItem";
            this.kaydıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kaydıGüncelleToolStripMenuItem.Text = "Güncelle";
            this.kaydıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kaydıGüncelleToolStripMenuItem_Click);
            // 
            // kaydıSilToolStripMenuItem
            // 
            this.kaydıSilToolStripMenuItem.Name = "kaydıSilToolStripMenuItem";
            this.kaydıSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kaydıSilToolStripMenuItem.Text = "Sil";
            this.kaydıSilToolStripMenuItem.Click += new System.EventHandler(this.kaydıSilToolStripMenuItem_Click);
            // 
            // PersonelListesi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_PersonelListesi);
            this.Name = "PersonelListesi_Form";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonelListesi_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_PersonelListesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_PersonelListesi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydıSilToolStripMenuItem;
    }
}