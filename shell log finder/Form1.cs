using System;
using System.Windows.Forms;
using System.IO;

namespace shell_log_finder
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logger(string metin) {
            listbox_loglar.Items.Add($"{metin}");
        }

        private void btn_Başlat_Click(object sender, EventArgs e)
        {
            logger("Başlatıldı!");
            string[] sheller = new string[listBox_Sheller.Items.Count];
            int count = 0;
            foreach (string shell in listBox_Sheller.Items)
                sheller[count++] = shell;
            string[] blacklist = scan_settings.Default.blacklist.Split('\n');
            for(int i = 0; i< count;i++) {
                string[] shell_lines = File.ReadAllLines(sheller[i]);
                for (int f = 0; f < blacklist.Length; f++) {
                    string word = blacklist[f];
                    for (int g = 0; g < shell_lines.Length; g++)
                        if (shell_lines[g].Contains(word))
                            logger($"Dosya konumu = {sheller[i]} İlgili satır = {g + 1} Kelime = {word}");
                }
            }
            logger("Tarama bitti. Detaylı önizleme için sonuca çift tıklayınız.");
            listbox_loglar.SelectedIndex = listbox_loglar.Items.Count - 1;
        }

        private void btn_klasörSeç_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string[] files = Directory.GetFileSystemEntries(fbd.SelectedPath);
                foreach (string file in files)
                    if (file.Contains("."))
                    {
                        count++;
                        listBox_Sheller.Items.Add(file);
                    }
                logger($"{count} dosya eklendi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu. Hata detayı:\n{ex}","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                logger("Dosya eklerken bir hata oluştu.");
            }
        }

        private void btn_ManuelEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();

            foreach (string names in ofd.FileNames)
                listBox_Sheller.Items.Add(names);
        }

        private void btn_İletişim_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_TaramaAyarları_Click(object sender, EventArgs e)
        {
            taramaAyarları f = new taramaAyarları();
            f.Show();
        }

        private void listbox_loglar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string line = listbox_loglar.SelectedItem.ToString();
                int loc_start = line.IndexOf("Dosya konumu = ") + 15;
                int loc_end = line.Substring(loc_start).IndexOf("İlgili satır = ");
                string konum = line.Substring(loc_start, loc_end);

                int li_start = line.IndexOf("İlgili satır = ") + 15;
                int li_end = line.Substring(li_start).IndexOf("Kelime = ");
                string satır = line.Substring(li_start, li_end);


                result_preview resprew = new result_preview();

                string[] şüpheli_dosya = File.ReadAllLines(konum);
                int count = 0;
                foreach (string lines in şüpheli_dosya)
                    resprew.listbox_Önizleme.Items.Add(şüpheli_dosya[count++]);
                resprew.listbox_Önizleme.SelectedIndex = Convert.ToInt32(satır) - 1;
                resprew.label1.Text = ($"Log: {line}");
                resprew.konum = konum;
                resprew.Show();
            }
            catch
            {
                logger("Bir hata oluştu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox_loglar.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_Sheller.Items.Clear();
        }

        private void btn_Base64Decoder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bu bölüm eğer programa ilgi gelirse birdahaki sürümde bu özellik eklenilecektir.\nEn çok kullanılan online Base64 decoder siteleri açılsınmı?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                System.Diagnostics.Process.Start("https://hasteb.in/faqutuqa.nginx");
        }

        private void btn_ListeyiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ("Metin Dosyası|*.txt");
                sfd.ShowDialog();
                StreamWriter Kayit = new StreamWriter(sfd.FileName);
                foreach (string lines in listbox_loglar.Items)
                    Kayit.WriteLine(lines);
                Kayit.Close();
                logger("Başarıyla loglar kaydedildi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu! Hata detayı:\n" + ex, "Hata!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}