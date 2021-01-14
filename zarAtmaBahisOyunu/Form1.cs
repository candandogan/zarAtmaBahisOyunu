using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarAtmaBahisOyunu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Oyun zarOyunu = new Oyun();
        

        private void buttonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncuBirAd.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.toplamButce = 100;
            zarOyunu.BirinciOyuncu.OyuncununZari = new zar();
            labelOyuncu1.Text = zarOyunu.BirinciOyuncu.Ad;
           
            labelBahisOynanabilecekPara1.Text = $"Bahis için bütçeniz 100 TL.";
            


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            zarOyunu.İkinciOyuncu = new Oyuncu(textBoxOyuncuİkiAd.Text);
            zarOyunu.İkinciOyuncu.OyuncununZari = new zar();
            labelOyuncu2.Text = zarOyunu.İkinciOyuncu.Ad;
            zarOyunu.İkinciOyuncu.toplamButce = 100;
            labelBahisOynanabilecekPara2.Text = $"Bahis için bütçeniz 100 TL.";
        }

        private void buttonOyuncuBir_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
        }

        private void buttonOyuncuİki_Click(object sender, EventArgs e)
        {
            zarOyunu.IkıncıOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.İkinciOyuncu.OyuncununZari.Deger.ToString();

            

            
                if (zarOyunu.BirinciOyuncu.OyuncununZari.Deger > zarOyunu.İkinciOyuncu.OyuncununZari.Deger)
                {
                    labelKazanan.Text = $"{zarOyunu.BirinciOyuncu.Ad}, {zarOyunu.BirinciOyuncu.OyuncununZari.Deger} atarak oyunu kazandı!!!";
                zarOyunu.BirinciOyuncu.toplamButce = zarOyunu.BirinciOyuncu.toplamButce + zarOyunu.BirinciOyuncu.bahisMiktari + zarOyunu.İkinciOyuncu.bahisMiktari;
                labelBahisOynanabilecekPara1.Text = $"Bahis için {zarOyunu.BirinciOyuncu.toplamButce} TL bütçeniz kaldı. ";
                       
                }
                 else if (zarOyunu.BirinciOyuncu.OyuncununZari.Deger < zarOyunu.İkinciOyuncu.OyuncununZari.Deger)
                {
                    labelKazanan.Text = $"{zarOyunu.İkinciOyuncu.Ad}, {zarOyunu.İkinciOyuncu.OyuncununZari.Deger} atarak oyunu kazandı!!!";
                zarOyunu.İkinciOyuncu.toplamButce = zarOyunu.İkinciOyuncu.toplamButce + zarOyunu.İkinciOyuncu.bahisMiktari + zarOyunu.BirinciOyuncu.bahisMiktari;
                labelBahisOynanabilecekPara2.Text = $"Bahis için {zarOyunu.İkinciOyuncu.toplamButce} TL bütçeniz kaldı. ";
                }
                  
                else
                {
                    labelKazanan.Text = "Berabere ";
                }

            if (zarOyunu.İkinciOyuncu.toplamButce == 0)
            {
                labelBahisOynanabilecekPara2.Text = $"KAYBETTİNİZ :( ";
                labelBahisOynanabilecekPara1.Text = $"BÜTÇENİ İKİYE KATLADIN!";
                buttonBahisOynaOyuncu2.Enabled = false;
            }
            else if(zarOyunu.BirinciOyuncu.toplamButce == 0)
            {
                labelBahisOynanabilecekPara1.Text = $"KAYBETTİNİZ :( ";
                labelBahisOynanabilecekPara2.Text = $"BÜTÇENİ İKİYE KATLADIN ŞANSLI GÜNÜNDESİN!";
                buttonBahisOynaOyuncu1.Enabled = false;
            }
            else
            {
                
                    labelKazanan.Text = "Berabere ";
                
            }

        }
        
        private void buttonBahisOynaOyuncu1_Click(object sender, EventArgs e)
        {
           
            zarOyunu.BirinciOyuncu.bahisMiktari = Convert.ToDouble(textbahisMiktarıOyuncu1.Text);
            if (zarOyunu.BirinciOyuncu.toplamButce >= zarOyunu.BirinciOyuncu.bahisMiktari)
            {
                zarOyunu.BirinciOyuncu.toplamButce = zarOyunu.BirinciOyuncu.toplamButce - zarOyunu.BirinciOyuncu.bahisMiktari;
                labelBahisOynanabilecekPara1.Text = $"Bahis için {zarOyunu.BirinciOyuncu.toplamButce} TL bütçeniz kaldı. ";
            }
            else
            {
                labelBahisOynanabilecekPara1.Text = $"Bahis için {zarOyunu.BirinciOyuncu.toplamButce} TL'ye eşit ya da daha az bir bahis miktarı girin.";
            }
        }

        private void labelBahisOynanabilecekPara1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBahisOynaOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.İkinciOyuncu.bahisMiktari = Convert.ToDouble(textbahisMiktarıOyuncu2.Text);
            if (zarOyunu.İkinciOyuncu.toplamButce >= zarOyunu.İkinciOyuncu.bahisMiktari)
            {
                zarOyunu.İkinciOyuncu.toplamButce = zarOyunu.İkinciOyuncu.toplamButce - zarOyunu.İkinciOyuncu.bahisMiktari;
                labelBahisOynanabilecekPara2.Text = $"Bahis için {zarOyunu.İkinciOyuncu.toplamButce} TL bütçeniz kaldı. ";
            }
            else
            {
                labelBahisOynanabilecekPara2.Text = $"Bahis için {zarOyunu.İkinciOyuncu.toplamButce} TL'ye eşit ya da daha az bir bahis miktarı girin.";
            }
        }
    }
}
