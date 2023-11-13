using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DegerlerVeBasvurular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sayi1 = 37;
        int Sayi2;
        
        Araba Bmv1 = new Araba();
        Araba Bmv2 = null;
        //Araba Bmv2; Buda ayrı bir seçenek
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sayi2 = Sayi1;
            MessageBox.Show(String.Format("Sayi 1 = {0}----Sayi 2 = {1}",Sayi1,Sayi2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bmv2 = Bmv1;
            Bmv1.KapiSayisi = 4;
            Bmv2.KapiSayisi = 4;
            MessageBox.Show(String.Format("Bmv1 Kapı Sayısı = {0}----Bmv2 Kapı Sayısı = {1}",Bmv1.KapiSayisi,Bmv2.KapiSayisi));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sayi2 = Sayi1;
            Sayi2++;
            Sayi1--;
            MessageBox.Show(String.Format("Sayi 1 = {0}----Sayi 2 = {1}", Sayi1, Sayi2));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bmv2 = Bmv1;
            Bmv1.KapiSayisi = 10;
            Bmv2.KapiSayisi = 2;
            MessageBox.Show(String.Format("Bmv1 Kapı Sayısı = {0}----Bmv2 Kapı Sayısı = {1}", Bmv1.KapiSayisi, Bmv2.KapiSayisi));

        }
    }
    public class Araba
    {
        public int KapiSayisi;
 
    }
}
