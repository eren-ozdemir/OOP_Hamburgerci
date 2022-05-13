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
    public partial class SiparisleriListeleForm : Form
    {
        public static BindingList<Siparis> tumSiparisler = new BindingList<Siparis>();
        public SiparisleriListeleForm()
        {
            int toplamUrunAdedi = 0;
            decimal ekstraMalzemeGeliri = 0;

            InitializeComponent();

            foreach (var item in tumSiparisler)
            {
                lbxTumSiparisler.Items.Add(item);
                ekstraMalzemeGeliri += item.Soslar.Sum(s => s.Fiyat);
                toplamUrunAdedi += item.Soslar.Count;
                toplamUrunAdedi += item.Adet;
            }

            lblCiro.Text = tumSiparisler.Sum(x => x.Tutar).ToString() + "₺";
            lblToplamSiparisSayisi.Text = tumSiparisler.Count.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString() + "₺";
            lblSatilanUrunAdedi.Text = toplamUrunAdedi.ToString();

        }
    }
}
