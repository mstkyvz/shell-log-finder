using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shell_log_finder
{
    public partial class taramaAyarları : MetroFramework.Forms.MetroForm
    {
        public taramaAyarları()
        {
            InitializeComponent();
        }
        private void taramaAyarları_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = scan_settings.Default.blacklist;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scan_settings.Default.blacklist = richTextBox1.Text;
            scan_settings.Default.Save();
            this.Close();
        }

    }
}
