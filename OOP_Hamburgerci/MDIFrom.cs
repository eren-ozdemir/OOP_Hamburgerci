using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class MDIFrom : Form
    {
        public MDIFrom()
        {
            InitializeComponent();
            SiparisOlustur_Click(this, EventArgs.Empty);
        }

        public void SiparisOlustur_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            SiparisOlusturForm siparisOlusturForm = new SiparisOlusturForm();
            siparisOlusturForm.MdiParent = this;
            siparisOlusturForm.Show();
        }

        public void TumSiparisler_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            SiparisleriListeleForm tumSiparislerForm = new SiparisleriListeleForm();
            tumSiparislerForm.MdiParent = this;
            this.ActivateMdiChild(tumSiparislerForm);
            tumSiparislerForm.Show();
        }
    }
}
