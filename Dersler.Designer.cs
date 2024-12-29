namespace ObsApp
{
    partial class Dersler
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
            grp_dersEkle = new GroupBox();
            txtDersAdi = new TextBox();
            txtdersKodu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            btn_bul = new Button();
            grp_dersEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grp_dersEkle
            // 
            grp_dersEkle.Controls.Add(txtDersAdi);
            grp_dersEkle.Controls.Add(txtdersKodu);
            grp_dersEkle.Controls.Add(label2);
            grp_dersEkle.Controls.Add(label1);
            grp_dersEkle.Location = new Point(23, 12);
            grp_dersEkle.Name = "grp_dersEkle";
            grp_dersEkle.Size = new Size(451, 182);
            grp_dersEkle.TabIndex = 4;
            grp_dersEkle.TabStop = false;
            grp_dersEkle.Text = "Ders Ekle";
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(173, 103);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(133, 27);
            txtDersAdi.TabIndex = 7;
            txtDersAdi.TextChanged += txt_TextChanged;
            // 
            // txtdersKodu
            // 
            txtdersKodu.Location = new Point(173, 53);
            txtdersKodu.Name = "txtdersKodu";
            txtdersKodu.Size = new Size(133, 27);
            txtdersKodu.TabIndex = 6;
            txtdersKodu.TextChanged += txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 102);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 5;
            label2.Text = "Ders Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 4;
            label1.Text = "Ders Kodu";
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(23, 209);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(114, 40);
            btn_ekle.TabIndex = 5;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(196, 209);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(114, 40);
            btn_sil.TabIndex = 6;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(360, 209);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(114, 40);
            btn_guncelle.TabIndex = 7;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(196, 269);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(114, 41);
            btn_bul.TabIndex = 8;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // Dersler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 320);
            Controls.Add(btn_bul);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Controls.Add(grp_dersEkle);
            Name = "Dersler";
            Text = "Ders Ekle";
            grp_dersEkle.ResumeLayout(false);
            grp_dersEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_dersEkle;
        private TextBox txtDersAdi;
        private TextBox txtdersKodu;
        private Label label2;
        private Label label1;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_bul;
    }
}