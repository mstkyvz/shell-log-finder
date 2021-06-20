namespace shell_log_finder
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Sheller = new System.Windows.Forms.ListBox();
            this.btn_klasörSeç = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ManuelEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TaramaAyarları = new System.Windows.Forms.Button();
            this.btn_Başlat = new System.Windows.Forms.Button();
            this.btn_Base64Decoder = new System.Windows.Forms.Button();
            this.btn_ListeyiKaydet = new System.Windows.Forms.Button();
            this.btn_İletişim = new System.Windows.Forms.Button();
            this.listbox_loglar = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Sheller
            // 
            this.listBox_Sheller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox_Sheller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Sheller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Sheller.ForeColor = System.Drawing.Color.White;
            this.listBox_Sheller.FormattingEnabled = true;
            this.listBox_Sheller.ItemHeight = 15;
            this.listBox_Sheller.Location = new System.Drawing.Point(16, 40);
            this.listBox_Sheller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Sheller.Name = "listBox_Sheller";
            this.listBox_Sheller.Size = new System.Drawing.Size(564, 137);
            this.listBox_Sheller.TabIndex = 1;
            // 
            // btn_klasörSeç
            // 
            this.btn_klasörSeç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_klasörSeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_klasörSeç.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_klasörSeç.Location = new System.Drawing.Point(16, 201);
            this.btn_klasörSeç.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_klasörSeç.Name = "btn_klasörSeç";
            this.btn_klasörSeç.Size = new System.Drawing.Size(128, 26);
            this.btn_klasörSeç.TabIndex = 0;
            this.btn_klasörSeç.Text = "Klasör Seç";
            this.btn_klasörSeç.UseVisualStyleBackColor = false;
            this.btn_klasörSeç.Click += new System.EventHandler(this.btn_klasörSeç_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sheller:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Loglar:";
            // 
            // btn_ManuelEkle
            // 
            this.btn_ManuelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_ManuelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ManuelEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_ManuelEkle.Location = new System.Drawing.Point(154, 201);
            this.btn_ManuelEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ManuelEkle.Name = "btn_ManuelEkle";
            this.btn_ManuelEkle.Size = new System.Drawing.Size(115, 26);
            this.btn_ManuelEkle.TabIndex = 5;
            this.btn_ManuelEkle.Text = "Manuel Ekle";
            this.btn_ManuelEkle.UseVisualStyleBackColor = false;
            this.btn_ManuelEkle.Click += new System.EventHandler(this.btn_ManuelEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_ManuelEkle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox_Sheller);
            this.panel1.Controls.Add(this.btn_TaramaAyarları);
            this.panel1.Controls.Add(this.btn_klasörSeç);
            this.panel1.Controls.Add(this.btn_Başlat);
            this.panel1.Location = new System.Drawing.Point(17, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 247);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button2.Location = new System.Drawing.Point(394, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_TaramaAyarları
            // 
            this.btn_TaramaAyarları.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_TaramaAyarları.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaramaAyarları.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_TaramaAyarları.Location = new System.Drawing.Point(279, 201);
            this.btn_TaramaAyarları.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TaramaAyarları.Name = "btn_TaramaAyarları";
            this.btn_TaramaAyarları.Size = new System.Drawing.Size(105, 26);
            this.btn_TaramaAyarları.TabIndex = 8;
            this.btn_TaramaAyarları.Text = "Tarama Ayarları";
            this.btn_TaramaAyarları.UseVisualStyleBackColor = false;
            this.btn_TaramaAyarları.Click += new System.EventHandler(this.btn_TaramaAyarları_Click);
            // 
            // btn_Başlat
            // 
            this.btn_Başlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_Başlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Başlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Başlat.Location = new System.Drawing.Point(492, 201);
            this.btn_Başlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Başlat.Name = "btn_Başlat";
            this.btn_Başlat.Size = new System.Drawing.Size(85, 26);
            this.btn_Başlat.TabIndex = 18;
            this.btn_Başlat.Text = "Başlat";
            this.btn_Başlat.UseVisualStyleBackColor = false;
            this.btn_Başlat.Click += new System.EventHandler(this.btn_Başlat_Click);
            // 
            // btn_Base64Decoder
            // 
            this.btn_Base64Decoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_Base64Decoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Base64Decoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Base64Decoder.Location = new System.Drawing.Point(16, 182);
            this.btn_Base64Decoder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Base64Decoder.Name = "btn_Base64Decoder";
            this.btn_Base64Decoder.Size = new System.Drawing.Size(94, 26);
            this.btn_Base64Decoder.TabIndex = 15;
            this.btn_Base64Decoder.Text = "Base64 Decoder";
            this.btn_Base64Decoder.UseVisualStyleBackColor = false;
            this.btn_Base64Decoder.Click += new System.EventHandler(this.btn_Base64Decoder_Click);
            // 
            // btn_ListeyiKaydet
            // 
            this.btn_ListeyiKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_ListeyiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListeyiKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_ListeyiKaydet.Location = new System.Drawing.Point(316, 182);
            this.btn_ListeyiKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ListeyiKaydet.Name = "btn_ListeyiKaydet";
            this.btn_ListeyiKaydet.Size = new System.Drawing.Size(95, 26);
            this.btn_ListeyiKaydet.TabIndex = 9;
            this.btn_ListeyiKaydet.Text = "Logları Kaydet";
            this.btn_ListeyiKaydet.UseVisualStyleBackColor = false;
            this.btn_ListeyiKaydet.Click += new System.EventHandler(this.btn_ListeyiKaydet_Click);
            // 
            // btn_İletişim
            // 
            this.btn_İletişim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_İletişim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_İletişim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_İletişim.Location = new System.Drawing.Point(524, 182);
            this.btn_İletişim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_İletişim.Name = "btn_İletişim";
            this.btn_İletişim.Size = new System.Drawing.Size(54, 26);
            this.btn_İletişim.TabIndex = 19;
            this.btn_İletişim.Text = "İletişim";
            this.btn_İletişim.UseVisualStyleBackColor = false;
            this.btn_İletişim.Click += new System.EventHandler(this.btn_İletişim_Click);
            // 
            // listbox_loglar
            // 
            this.listbox_loglar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listbox_loglar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbox_loglar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox_loglar.ForeColor = System.Drawing.Color.White;
            this.listbox_loglar.FormattingEnabled = true;
            this.listbox_loglar.ItemHeight = 15;
            this.listbox_loglar.Location = new System.Drawing.Point(16, 38);
            this.listbox_loglar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listbox_loglar.Name = "listbox_loglar";
            this.listbox_loglar.Size = new System.Drawing.Size(564, 122);
            this.listbox_loglar.TabIndex = 6;
            this.listbox_loglar.DoubleClick += new System.EventHandler(this.listbox_loglar_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_ListeyiKaydet);
            this.panel2.Controls.Add(this.listbox_loglar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Base64Decoder);
            this.panel2.Controls.Add(this.btn_İletişim);
            this.panel2.Location = new System.Drawing.Point(17, 324);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 223);
            this.panel2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button1.Location = new System.Drawing.Point(422, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Shell Log Finder  | ElitHatz";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Sheller;
        private System.Windows.Forms.Button btn_klasörSeç;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ManuelEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Base64Decoder;
        private System.Windows.Forms.Button btn_TaramaAyarları;
        private System.Windows.Forms.Button btn_ListeyiKaydet;
        private System.Windows.Forms.Button btn_İletişim;
        private System.Windows.Forms.Button btn_Başlat;
        private System.Windows.Forms.ListBox listbox_loglar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

