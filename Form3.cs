﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElse
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            #region soruAciklamasi
            /* 
                 * Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler 
                 * adli label'a yazdirilacak ve kullanicidan butona bastigi anda 
                 * textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. 
                 * Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak.
                 * Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak... 
                 * Her hatali giriste yeni bir rastgele sayi turetilmelidir...
                */
            #endregion

            Random rnd = new Random();
            int sayi = rnd.Next(10000000, 100000000);
            lblRastgeleKarakterler.Text = sayi.ToString();
        }

        sbyte sayac = 5;

        #region mesajTanimlar
        string mesaj1 = "Doğru eşleşme, tebrikler ;-)\nBir deneme daha? =)";
        string mesaj2 = "Üzgünüz, giriş hakkın bitti =(\nTekrar denemeye cesaretin var mı? =)";
        string baslik1 = "SELAM DUR =)", baslik2 = "YAZIKLAR OLSUN...";

        MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
        DialogResult result;
        #endregion

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtMetinGirisAlani.Text == lblRastgeleKarakterler.Text)
            {
                result = MessageBox.Show
                    (mesaj1, baslik1, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Cancel)
                {
                    Thread.Sleep(300);
                    //Application.Exit();
                    Close();
                }
                else
                    Application.Restart();
            }
            else
            {
                sayac--;
                if (sayac > 0)
                {
                    lblKalanHakkimiz.Text = sayac.ToString();
                    Form3_Load(sender, e);
                }
                else
                {
                    btnGirisYap.Enabled = false;
                    lblKalanHakkimiz.Text = sayac.ToString();

                    result = MessageBox.Show
                        (mesaj2, baslik2, buttons, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Cancel)
                    {
                        Thread.Sleep(300);
                        Close();
                    }
                    else
                        Application.Restart();
                }
            }
        }
    }
}
