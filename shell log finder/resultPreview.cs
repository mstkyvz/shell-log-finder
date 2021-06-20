using System;
using System.Windows.Forms;

namespace shell_log_finder
{
    public partial class result_preview : MetroFramework.Forms.MetroForm
    {
        public result_preview()
        {
            InitializeComponent();
        }

        public string konum;

        private void btn_varsayılanOlarakÇalıştır_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(konum);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dosya açılırken bir sorun ile karşılaşıldı.\nBüyük ihtimal dosya uzantısını çalıştırmak için varsayılan program ayarlanmamış.\nDetaylı hata kodu:\n" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
