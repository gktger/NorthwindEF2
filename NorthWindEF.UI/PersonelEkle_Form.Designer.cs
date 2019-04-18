namespace NorthWindEF.UI
{
    partial class YeniPersonelEkle_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.cb_title = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim:";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(85, 22);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(162, 22);
            this.tb_isim.TabIndex = 1;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(85, 67);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(162, 22);
            this.tb_soyisim.TabIndex = 1;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(103, 159);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(129, 35);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // cb_title
            // 
            this.cb_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_title.FormattingEnabled = true;
            this.cb_title.Location = new System.Drawing.Point(85, 112);
            this.cb_title.Name = "cb_title";
            this.cb_title.Size = new System.Drawing.Size(162, 24);
            this.cb_title.TabIndex = 3;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Görevi:";
            // 
            // YeniPersonelEkle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 206);
            this.Controls.Add(this.cb_title);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.tb_soyisim);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniPersonelEkle_Form";
            this.Text = "Yeni Personel";
            this.Load += new System.EventHandler(this.YeniPersonelEkle_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ComboBox cb_title;
        private System.Windows.Forms.Label label3;
    }
}