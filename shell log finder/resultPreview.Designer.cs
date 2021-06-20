namespace shell_log_finder
{
    partial class result_preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result_preview));
            this.listbox_Önizleme = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_varsayılanOlarakÇalıştır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_Önizleme
            // 
            this.listbox_Önizleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listbox_Önizleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbox_Önizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox_Önizleme.ForeColor = System.Drawing.Color.White;
            this.listbox_Önizleme.FormattingEnabled = true;
            this.listbox_Önizleme.ItemHeight = 18;
            this.listbox_Önizleme.Location = new System.Drawing.Point(30, 112);
            this.listbox_Önizleme.Name = "listbox_Önizleme";
            this.listbox_Önizleme.Size = new System.Drawing.Size(838, 452);
            this.listbox_Önizleme.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sheller:";
            // 
            // btn_varsayılanOlarakÇalıştır
            // 
            this.btn_varsayılanOlarakÇalıştır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_varsayılanOlarakÇalıştır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_varsayılanOlarakÇalıştır.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_varsayılanOlarakÇalıştır.Location = new System.Drawing.Point(620, 581);
            this.btn_varsayılanOlarakÇalıştır.Name = "btn_varsayılanOlarakÇalıştır";
            this.btn_varsayılanOlarakÇalıştır.Size = new System.Drawing.Size(248, 32);
            this.btn_varsayılanOlarakÇalıştır.TabIndex = 21;
            this.btn_varsayılanOlarakÇalıştır.Text = "Varsayılan metin editörüyle çalıştır";
            this.btn_varsayılanOlarakÇalıştır.UseVisualStyleBackColor = false;
            this.btn_varsayılanOlarakÇalıştır.Click += new System.EventHandler(this.btn_varsayılanOlarakÇalıştır_Click);
            // 
            // result_preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 633);
            this.Controls.Add(this.btn_varsayılanOlarakÇalıştır);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_Önizleme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "result_preview";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Sonuç Önizlemesi";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listbox_Önizleme;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_varsayılanOlarakÇalıştır;
    }
}