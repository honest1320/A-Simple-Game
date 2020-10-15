/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ                             
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                        
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ                       
**					     2019-2020 BAHAR DÖNEMİ                            
**	                                                                      
**				ÖDEV NUMARASI.......1. Proje / Tasarım...:                              
**				ÖĞRENCİ ADI.........HONEST TEMU......:                             
**				ÖĞRENCİ NUMARASI....B181210561...:                            
**              DERSİN ALINDIĞI GRUP..........1A........:                               
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace MyProject
{
    public partial class Form1 : Form
    {
       //default constructor
        public Form1()
        {
            InitializeComponent();
        }

        int timeLeft = 60; //initial time
        int t=0;

        //initial random image generator
        private void RandomImage()
        {
            Random random = new Random();
            int i = random.Next(0, 8);
            string filePath = @"photos";
            string[] paths = Directory.GetFiles(filePath);
            //List<string> images = paths.ToList();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = paths[i];
        }

        //declare variables to store obtained item values 
        private int sum = 0;
        private int sum1 = 0;
        private int sum2 = 0;
        private int sum3 = 0;
        private int sum4 = 0;
        int sayac = 0;

        private void yeniOyun_Click(object sender, EventArgs e)
        {
            RandomImage();

            //enable buttons when button clicked
            yeniOyun.Enabled = false;

            organikBtn.Enabled = true;
            kagitBtn.Enabled = true;
            camBtn.Enabled = true;
            metalBtn.Enabled = true;
            oragnikBosalt.Enabled = true;
            kagitBosalt.Enabled = true;
            camBosalt.Enabled = true;
            button4.Enabled = true;

            //start time when button clicked
            timer1.Start();

            //disable buttons of undisplayed images
            if(pictureBox1.ImageLocation.Contains("6.jpg")&& pictureBox1.ImageLocation.Contains("3.jpg")){
                kagitBtn.Enabled = false;
                metalBtn.Enabled = false;
                camBtn.Enabled = false;
            }
            if (pictureBox1.ImageLocation.Contains("4.jpg") && pictureBox1.ImageLocation.Contains("5.jpg")){
                oragnikBosalt.Enabled = false;
                metalBtn.Enabled = false;
                camBtn.Enabled = false;
            }
            if (pictureBox1.ImageLocation.Contains("0.jpg") && pictureBox1.ImageLocation.Contains("7.jpg")){
                kagitBtn.Enabled = false;
                metalBtn.Enabled = false;
                organikBtn.Enabled = false;
            }
            if (pictureBox1.ImageLocation.Contains("1.jpg") && pictureBox1.ImageLocation.Contains("2.jpg")){
                kagitBtn.Enabled = false;
                organikBtn.Enabled = false;
                camBtn.Enabled = false;
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft>0)
            {
                timeLeft--;                                             //time decrease by a factor of 1
                label8.Text = timeLeft.ToString();                      
            }
            else
            {
                timer1.Stop();                                            //stops time
                yeniOyun.Enabled = false;
                organikBtn.Enabled = false;
                kagitBtn.Enabled = false;
                camBtn.Enabled = false;
                metalBtn.Enabled = false;
                oragnikBosalt.Enabled = false;
                kagitBosalt.Enabled = false;
                camBosalt.Enabled = false;
                button4.Enabled = false;
            }
        }
        private void organikBtn_Click(object sender, EventArgs e)
        {
            Organic salata = new Organic(150, 120, 700);                                          //Declare Organic items by using a constructor
            progressBar1.Maximum = salata.OrganicKutusu;                                          //place the value of Organıc items in the progress bar

            if (pictureBox1.ImageLocation.Contains("6.jpg"))
            {
                sum1 += salata.domates;
                if (sum1 <= progressBar1.Maximum) { 
                progressBar1.Value = sum1;
                

                    if (progressBar1.Value <= progressBar1.Maximum)
                    {
                        listBox1.Items.Add("Domates (" + salata.domates + ")");
                        sum += salata.domates;
                        sayac += salata.domates;
                        puanKutusu.Text = Convert.ToString(sayac);
                        label8.Text = t.ToString();
                        RandomImage();
                    }
                }
            }

            if (pictureBox1.ImageLocation.Contains("3.jpg"))
            {

                sum1 += salata.salatalik;
                if (sum1 <= progressBar1.Maximum)
                {
                    progressBar1.Value = sum1;

                    if (progressBar1.Value <= progressBar1.Maximum)
                    {
                        listBox1.Items.Add("Salatalik (" + salata.salatalik + ")");
                        sum += salata.salatalik;
                        sayac += salata.salatalik;
                        puanKutusu.Text = Convert.ToString(sayac);
                        label8.Text = t.ToString();
                        RandomImage();
                    }
                }
            }
        }

        private void kagitBtn_Click(object sender, EventArgs e)
        {
                Kagit kgt = new Kagit(250, 200, 1200);                                                  //Declare Kağıt items by using a constructor
                progressBar2.Maximum = kgt.KagitKutusu;                                                 //place the value of Kağıt items in the progress bar

                if (pictureBox1.ImageLocation.Contains("4.jpg"))
                {
                    sum2 += kgt.Dergi;
                    if (sum2 <= progressBar2.Maximum)
                    {
                        progressBar2.Value = sum2;
                    
                        if(progressBar2.Value<=progressBar2.Maximum)
                        listBox2.Items.Add("Dergi (" + kgt.Dergi + ")");
                        sum += kgt.Dergi;
                        sayac += kgt.Dergi;
                        puanKutusu.Text = Convert.ToString(sayac);
                        label8.Text = t.ToString();
                        RandomImage();
                    } 
                }

                if (pictureBox1.ImageLocation.Contains("5.jpg"))
                {
                    sum2 += kgt.Gazete;
                    if (sum2 <= progressBar2.Maximum)
                    {
                        progressBar2.Value = sum2;
                        if (progressBar2.Value <= progressBar2.Maximum)
                        {
                            listBox2.Items.Add("Gazete (" + kgt.Gazete + ")");
                            sum += kgt.Gazete;
                            sayac += kgt.Gazete;
                            puanKutusu.Text = Convert.ToString(sayac);
                            label8.Text = t.ToString();
                            RandomImage();
                        }
                    }
                }
        }

        private void camBtn_Click(object sender, EventArgs e)
        {
                Cam cam = new Cam(600, 250, 2200);                                              //Declare Cam items by using a constructor
                progressBar3.Maximum = cam.CamKutusu;                                            //place the value of Cam items in the progress bar
                if (pictureBox1.ImageLocation.Contains("0.jpg"))
                {
                    sum3 += cam.camSise;
                    if (sum3 <= progressBar3.Maximum)
                    {
                        progressBar3.Value = sum3;

                        if (progressBar3.Value <= progressBar3.Maximum)
                        {
                            listBox3.Items.Add("Cam Şişe (" + cam.camSise + ")");
                            sum += cam.camSise;
                            sayac += cam.camSise;
                            puanKutusu.Text = Convert.ToString(sayac);
                            label8.Text = t.ToString();
                            RandomImage();
                        }
                    }
                }

                if (pictureBox1.ImageLocation.Contains("7.jpg"))
                {
                    sum3 += cam.Bardak;
                    if (sum3 <= progressBar3.Maximum)
                    {
                        progressBar3.Value = sum3;
                        if (progressBar3.Value <= progressBar3.Maximum)
                        {
                            listBox3.Items.Add("Bardak (" + cam.Bardak + ")");
                            sum += cam.Bardak;
                            sayac += cam.Bardak;
                            puanKutusu.Text = Convert.ToString(sayac);
                            label8.Text = t.ToString();
                            RandomImage();
                        }
                    }
                }
        }

        private void metalBtn_Click(object sender, EventArgs e)
        {
            Metal metal = new Metal(350, 550, 2300);                                          //Declare Metalık items by using a constructor
            progressBar4.Maximum = metal.MetalKutusu;                                         //place the value of Metal items in the progress bar
            if (pictureBox1.ImageLocation.Contains("1.jpg"))
            {
                sum4 += metal.kolaKutusu;
                if (sum4 <= progressBar4.Maximum)
                {
                    progressBar4.Value = sum4;
                    if (progressBar4.Value <= progressBar4.Maximum)
                    {
                        listBox4.Items.Add("Kola Kutusu (" + metal.kolaKutusu + ")");
                        sum += metal.kolaKutusu;
                        sayac += metal.kolaKutusu;
                        puanKutusu.Text = Convert.ToString(sayac);
                        label8.Text = t.ToString();
                        RandomImage();
                    }
                }
            }

            if (pictureBox1.ImageLocation.Contains("2.jpg"))
            {
                sum4 += metal.salcaKutusu;
                if (sum4 <= progressBar4.Maximum)
                {
                    progressBar4.Value = sum4;
                    if (progressBar4.Value <= progressBar4.Maximum)
                    {
                        listBox4.Items.Add("Salça Kutusu (" + metal.salcaKutusu + ")");
                        sum += metal.salcaKutusu;
                        sayac += metal.salcaKutusu;
                        puanKutusu.Text = Convert.ToString(sayac);
                        label8.Text = t.ToString();
                        RandomImage();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //empty a listbox1 on button click
            if (sum1 >= (progressBar1.Maximum * 75) / 100)
            {
                listBox1.Items.Clear();
                timeLeft += 3;
                progressBar1.Value = 0;
                sum1 = 0;
                puanKutusu.Text = Convert.ToString(sayac);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //empty a listbox2 on button click
            if (sum2 >=(progressBar2.Maximum*75)/100)
            {
                listBox2.Items.Clear();
                timeLeft += 3;
                progressBar2.Value = 0;
                sum2 = 0;
                sayac += 1000;
                puanKutusu.Text = Convert.ToString(sayac);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //empty a listbox3 on button click
            if (sum3 >= (progressBar3.Maximum * 75) / 100)
            {
                listBox3.Items.Clear();
                timeLeft += 3;
                progressBar3.Value = 0;
                sum3 = 0;
                sayac += 600;
                puanKutusu.Text = Convert.ToString(sayac);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //empty a listbox4 on button click
            if (sum4 >= (progressBar4.Maximum * 75) / 100)
            {
                listBox4.Items.Clear();
                timeLeft += 3;
                progressBar4.Value = 0;
                sayac += 800;
                puanKutusu.Text = Convert.ToString(sayac);
                sum4 = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //close application
            Close();
        }
    }
}
