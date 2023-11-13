using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasvuruTurleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Araba bmw1 = new Araba();
        Araba bmw2;
        int sayi1 = 37;
        int sayi2;

        private void button1_Click(object sender, EventArgs e)
        {
            sayi2 = sayi1;
            MessageBox.Show(String.Format("sayi1 = {0}, sayi2 = {1}", sayi1, sayi2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bmw2 == null)
            {
                bmw2 = bmw1;
            }
            //bmw2 = bmw1;
            bmw1.kapiSayisi = 4;
            bmw2.kapiSayisi = 4;
            MessageBox.Show(String.Format("bmw1 in kapı sayısı = {0}, bmw2 nin kapı sayısı = {1}",bmw1.kapiSayisi.ToString(),bmw2.kapiSayisi.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi2 = sayi1;
            sayi1--;
            sayi2++;
            MessageBox.Show(String.Format("sayi1 = {0}, sayi2 = {1}", sayi1, sayi2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmw2 = bmw1;
            bmw1.kapiSayisi = 104;
            MessageBox.Show(String.Format("bmw1 in kapı sayısı = {0}, bmw2 nin kapı sayısı = {1}", bmw1.kapiSayisi.ToString(), bmw2.kapiSayisi.ToString()));
            bmw2.kapiSayisi = 2;
            MessageBox.Show(String.Format("bmw1 in kapı sayısı = {0}, bmw2 nin kapı sayısı = {1}", bmw1.kapiSayisi.ToString(), bmw2.kapiSayisi.ToString()));
        }
    }
    public class Araba
    {
        public int kapiSayisi;
    }
}
