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
    public partial class SiparisOlusturForm : Form
    {
        Siparis siparis = new Siparis();
        BindingList<Siparis> blSiparisler = new BindingList<Siparis>();
        List<Menu> menuler = new List<Menu>()
            {
                new Menu(){Ad="Whooper", Fiyat = 30},
                new Menu(){Ad="Köfteburger", Fiyat = 40},
                new Menu(){Ad="Big King", Fiyat = 50},
                new Menu(){Ad="Hamburger", Fiyat = 27},
                new Menu(){Ad="Tavukburger", Fiyat = 25},
                new Menu(){Ad="King Beef Burger", Fiyat = 42},
                new Menu(){Ad="BK Steakhouse Burger", Fiyat = 53}
            };
        List<Sos> soslar = new List<Sos>()
            {
                new Sos(){Ad="Ketçap", Fiyat = 0.75m},
                new Sos(){Ad="Mayonez", Fiyat = 0.75m},
                new Sos(){Ad="Hardal", Fiyat = 1},
                new Sos(){Ad="BBQ", Fiyat = 1.5m},
                new Sos(){Ad="Ranch", Fiyat = 1},
                new Sos(){Ad="Buffalo", Fiyat = 1.25m},

            };

        public SiparisOlusturForm()
        {
            InitializeComponent();
            blSiparisler.ListChanged += Siparisler_ListChanged;

            foreach (Menu menu in menuler)
                cmbMenuler.Items.Add(menu);

            foreach (Sos sos in soslar)
            {
                CheckBox chk = new CheckBox() { Text = sos.Ad };
                chk.CheckedChanged += SosEkleCikar;
                flpSoslar.Controls.Add(chk);
            }

            cmbMenuler.SelectedIndex = 0;
            rbKucuk.Checked = true;
        }

        private void Siparisler_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(blSiparisler.Count > 0)
                btnTamamla.Enabled = true;
            else
                btnTamamla.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            siparis.Menu = menuler[cmbMenuler.SelectedIndex];
            siparis.Adet = (byte)nudAdet.Value;

            foreach (RadioButton item in gbBoy.Controls)
                if (item.Checked)
                    siparis.Boyut = (Boyut)Enum.Parse(typeof(Boyut), item.Text);

            blSiparisler.Add(siparis);
            lbxSiparisler.Items.Add(siparis);

            lblToplamTutar.Text = blSiparisler.Sum(s => s.Tutar).ToString() + "₺";
            SiparisleriListeleForm.tumSiparisler.Add(siparis);
            Temizle();
        }

        private void SosEkleCikar(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
                siparis.Soslar.Add(soslar.Find(s => s.Ad == chk.Text));
            else
                siparis.Soslar.Remove(soslar.Find(s => s.Ad == chk.Text));

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            Temizle();
            blSiparisler.Clear();
            lbxSiparisler.Items.Clear();
            lblToplamTutar.Text = 0 + "₺";
        }

        private void Temizle()
        {
            siparis = new Siparis();
            cmbMenuler.SelectedIndex = 0;
            rbKucuk.Checked = true;
            rbOrta.Checked = false;
            rbBuyuk.Checked = false;
            nudAdet.Value = 1;
            foreach (CheckBox item in flpSoslar.Controls)
                item.Checked = false;
        }
    }
}
