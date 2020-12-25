using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class FrmSifreGiris : DevExpress.XtraEditors.XtraForm
    {
    PTOAnaEkran PtoAna;
    GirisBilgiDegis BilgiDegis;
      
        static string DosyaYolu = Application.StartupPath.ToString() + "\\kuladisifre.txt";

        public string dosyaYoluPaylas = DosyaYolu;
        static char ikinok = ':';
        static string DosyaMetni  = System.IO.File.ReadAllText(DosyaYolu, Encoding.GetEncoding("windows-1254"));
        static string[] veri = DosyaMetni.Split(ikinok);
        public string kullaniciAdi = veri[1];
        public string parola = veri[3];
        public FrmSifreGiris()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            ortak();
            if (txtKullaniciAdi.Text.Equals(kullaniciAdi) && txtParola.Text.Equals(parola))
            {
             PtoAna = new PTOAnaEkran();
                this.Hide();
                PtoAna.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Parola Eşleşmemektedir!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ortak();
            BilgiDegis = new GirisBilgiDegis();
            this.Hide();
            BilgiDegis.ShowDialog();
            this.Close();
        }

        void ortak()
        {
            DosyaMetni = System.IO.File.ReadAllText(DosyaYolu, Encoding.GetEncoding("windows-1254"));
            veri = DosyaMetni.Split(ikinok);
            kullaniciAdi = veri[1];
            parola = veri[3];

        }
    }
}
