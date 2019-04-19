namespace NorthWindEF.UI
{
    partial class PersonelGuncelle_Form
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
            this.cb_titleguncelle = new System.Windows.Forms.ComboBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.tb_soyisimguncelle = new System.Windows.Forms.TextBox();
            this.tb_isimguncelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_titleguncelle
            // 
            this.cb_titleguncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_titleguncelle.FormattingEnabled = true;
            this.cb_titleguncelle.Location = new System.Drawing.Point(82, 104);
            this.cb_titleguncelle.Name = "cb_titleguncelle";
            this.cb_titleguncelle.Size = new System.Drawing.Size(162, 24);
            this.cb_titleguncelle.TabIndex = 10;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(100, 151);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(129, 35);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Kaydet";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // tb_soyisimguncelle
            // 
            this.tb_soyisimguncelle.Location = new System.Drawing.Point(82, 59);
            this.tb_soyisimguncelle.Name = "tb_soyisimguncelle";
            this.tb_soyisimguncelle.Size = new System.Drawing.Size(162, 22);
            this.tb_soyisimguncelle.TabIndex = 7;
            // 
            // tb_isimguncelle
            // 
            this.tb_isimguncelle.Location = new System.Drawing.Point(82, 14);
            this.tb_isimguncelle.Name = "tb_isimguncelle";
            this.tb_isimguncelle.Size = new System.Drawing.Size(162, 22);
            this.tb_isimguncelle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Görevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsim:";
            // 
            // PersonelGuncelle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 229);
            this.Controls.Add(this.cb_titleguncelle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.tb_soyisimguncelle);
            this.Controls.Add(this.tb_isimguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelGuncelle_Form";
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_titleguncelle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox tb_soyisimguncelle;
        private System.Windows.Forms.TextBox tb_isimguncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}