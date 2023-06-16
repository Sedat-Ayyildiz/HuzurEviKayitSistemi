using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuzurEviKayıtSistemi
{
    public partial class FrmYasliRapor : Form
    {
        public FrmYasliRapor()
        {
            InitializeComponent();
        }

        private void FrmYasliRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HuzureviOtomasyonuDataSet8.Yasli' table. You can move, or remove it, as needed.
            this.YasliTableAdapter.Fill(this.HuzureviOtomasyonuDataSet8.Yasli);

            this.reportViewer1.RefreshReport();
        }
    }
}
