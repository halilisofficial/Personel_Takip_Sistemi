using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PersonelTakipOtomasyonu
{
    public partial class GirisBilgiDegis : DevExpress.XtraEditors.XtraForm
    {
        FrmSifreGiris frmSifreGiris = new FrmSifreGiris();
        FrmSifreGiris yeni = new FrmSifreGiris();
        string YazilacakVeri;
        public GirisBilgiDegis()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text == frmSifreGiris.kullaniciAdi && txtParola.Text == frmSifreGiris.parola )
            {


                YazilacakVeri = "Kullanıcı Adı:"+txtYeniKullaniciAdi.Text+":\nŞifre:"+txtYeniParola.Text+":\n" +
                    "Geliştirici Notu-> Sistemin Doğru Çalışması İçin Bu Dosyayı Silmeyin!\n"
                +"Geliştirici Notu-> İkinokta'ların Yerini Değiştirmeyin!\n"+
                "Geliştirici Notu-> Kullanıcı Adı Ve Şifreyi Okurken İkinokta'ları Görmezden Gelin!";

                System.IO.File.WriteAllText(frmSifreGiris.dosyaYoluPaylas,YazilacakVeri, Encoding.GetEncoding("windows-1254"));
                this.Hide();
                frmSifreGiris.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Eski Kullanıcıadı Veya Eski Şifre Uyuşmamaktadır!");
            }
        }
    }
}