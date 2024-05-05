using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarısı_oyunu
{
    public partial class frm_YarisAlani_212701069 : Form
    {
        int yenioyuncusayisi_212701069;
        public frm_YarisAlani_212701069(int oyuncusayisi_212701069) /* giriş formundan gelen oyuncu sayısını yarıs alanı ekranına tutar */
        {
            InitializeComponent();
            yenioyuncusayisi_212701069 = oyuncusayisi_212701069; /* giriş formundaki oyuncu sayısını yenioyuncusayisi adındaki değişkene atar */
        }
        
        Random rnd_212701069 = new Random(); /* Random sayı oluşturup , oyuncu değerlerini sıfırdan başlatır  */
        int oyuncu1_212701069 = 0;
        int oyuncu2_212701069 = 0;
        int oyuncu3_212701069 = 0;
        int oyuncu4_212701069 = 0;

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            int r = rnd_212701069.Next(5,85); /* Oyuncu1 her butona bastığında random sayı oluşturup atı random sayı kadar ilerletir*/
            pictureBox1_212701069.Left += r;
            oyuncu1_212701069 += r;
            //label2.Text = oyuncu1.ToString(); /*Yarış kulvarının (panelin) uzunluğunu bulmak için kullanılır*/
            if (635 <= oyuncu1_212701069)  /*Eğer oyuncu1 panelin sonuna ilk gelirse  messagebox ile ekrana oyuncu1 kazandı yazdırır*/
            {
                MessageBox.Show("Oyuncu 1 kazandı");
            }
            btn_Oyuncu1_212701069.Enabled = false;  /* oyuncu1'in buton aktifliğini kapatır*/
            btn_Oyuncu2_212701069.Enabled = true;   /* oyuncu2'nin buton aktifliğini açar*/
            btn_Basla_212701069.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = rnd_212701069.Next(5, 85); /* Oyuncu2 her butona bastığında random sayı oluşturup atı random sayı kadar ilerletir*/
            pictureBox2_212701069.Left += r;
            oyuncu2_212701069 += r;
            label2.Text = oyuncu2_212701069.ToString(); /*Yarış kulvarının (panelin) uzunluğunu bulmak için kullanılır*/
            if (635 <= oyuncu2_212701069)  /*Eğer oyuncu2 panelin sonuna ilk gelirse  messagebox ile ekrana oyuncu2 kazandı yazdırır*/
            {
                MessageBox.Show("Oyuncu 2 kazandı");
            }
            if (yenioyuncusayisi_212701069 == 2) /* Eğer oyuncu sayısı 2 olursa*/
            {
                btn_Oyuncu1_212701069.Enabled = true; /* oyuncu1'in buton aktifliğini açar*/
                btn_Oyuncu2_212701069.Enabled = false; /* oyuncu2'nin buton aktifliğini kapatır*/
            }
            if (yenioyuncusayisi_212701069 == 3) /* Eğer oyuncu sayısı 3 olursa*/
            {
                btn_Oyuncu1_212701069.Enabled = false;  /* oyuncu1'in buton aktifliğini kapatır*/
                btn_Oyuncu2_212701069.Enabled = false; /* oyuncu2'nin buton aktifliğini kapatır*/
                btn_Oyuncu3_212701069.Enabled = true; /* oyuncu3'ün buton aktifliğini açar*/
            }
            if (yenioyuncusayisi_212701069 == 4) /* Eğer oyuncu sayısı 4 olursa*/
            {
                
                btn_Oyuncu2_212701069.Enabled = false; /* oyuncu2'nin buton aktifliğini kapatır*/


            }

            btn_Oyuncu3_212701069.Enabled = true;  /* oyuncu3'ün buton aktifliğini açar*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = rnd_212701069.Next(5,85); /* Oyuncu3 her butona bastığında random sayı oluşturup atı random sayı kadar ilerletir*/
            pictureBox3_212701069.Left += r;
            oyuncu3_212701069 += r;
            label2.Text = oyuncu3_212701069.ToString(); /*Yarış kulvarının (panelin) uzunluğunu bulmak için kullanılır*/
            if (635 <= oyuncu3_212701069) /*Eğer oyuncu3 panelin sonuna ilk gelirse  messagebox ile ekrana oyuncu3 kazandı yazdırır*/
            {
                MessageBox.Show("Oyuncu 3 kazandı");
            }
            btn_Oyuncu3_212701069.Enabled = false; /* oyuncu3'ün buton aktifliğini kapatır*/
            btn_Oyuncu4_212701069.Enabled = true;  /* oyuncu4'ün buton aktifliğini açar*/
            if (yenioyuncusayisi_212701069 == 3)
            {
                btn_Oyuncu1_212701069.Enabled = true; /* oyuncu1'nin buton aktifliğini açar*/
                btn_Oyuncu3_212701069.Enabled = false; /* oyuncu3'ün buton aktifliğini kapatır*/
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int r = rnd_212701069.Next(5, 85); /* Oyuncu4 her butona bastığında random sayı oluşturup atı random sayı kadar ilerletir*/
            pictureBox4_212701069.Left += r;
            oyuncu4_212701069 += r;
            label2.Text = oyuncu4_212701069.ToString(); /*Yarış kulvarının (panelin) uzunluğunu bulmak için kullanılır*/
            if (635 <= oyuncu4_212701069) /*Eğer oyuncu4 panelin sonuna ilk gelirse  messagebox ile ekrana oyuncu4 kazandı yazdırır*/
            {
                MessageBox.Show("Oyuncu 4 kazandı");
            }
            btn_Oyuncu4_212701069.Enabled = false; /* oyuncu4'ün buton aktifliğini kapatır*/
            btn_Oyuncu1_212701069.Enabled = true; /* oyuncu1'in buton  aktifliğini açar*/
        }

        private void form2_Load(object sender, EventArgs e)
        {
            if (yenioyuncusayisi_212701069 == 2) /*Eğer oyuncu sayısı 2 olursa*/
            {
                pictureBox3_212701069.Visible = false; /* oyuncu 3 ve 4'ün at resimlerini kapatır*/
                pictureBox4_212701069.Visible = false;

                btn_Oyuncu3_212701069.Visible = false;  /* oyuncu  3 ve 4'ün butonun görünür özelliğini kapatır*/
                btn_Oyuncu4_212701069.Visible = false;

                panel4_212701069.Visible = false; /* oyuncu 4 ve 5'in panelleri kapatır*/
                panel5_212701069.Visible = false;

                 btn_Oyuncu3_212701069.Enabled = false; /* oyuncu 3 ve 4'ün butonun aktifliğini kapatır*/
                btn_Oyuncu4_212701069.Enabled = false;

                btn_Oyuncu1_212701069.Enabled = true; /* oyuncu1' in buton aktifliğini açar*/
               

            }

            if (yenioyuncusayisi_212701069 == 3)  /*Eğer oyuncu sayısı 3 olursa*/
            {
                pictureBox4_212701069.Visible = false; /*  4. at resmi kapanır*/

                btn_Oyuncu4_212701069.Visible = false;  /* oyuncu 4 'ün buton özelliği kapanır*/
                
                panel5_212701069.Visible = false; /* panel özelliği kapanır*/
            }

            btn_Oyuncu1_212701069.Visible = false; /* yarış alanı açıldığında butonların görünürlük özelliği kapalı olur  */
                btn_Oyuncu2_212701069.Visible = false;
            btn_Oyuncu3_212701069.Visible = false;
            btn_Oyuncu4_212701069.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yenioyuncusayisi_212701069 == 4) /*Eğer oyuncu sayısı 4 olursa*/
            {
                btn_Oyuncu1_212701069.Visible = true;  /* butonlara bastığımızda butonların görünür  olmasını sağlar*/
                btn_Oyuncu2_212701069.Visible = true;
                btn_Oyuncu3_212701069.Visible = true;
                btn_Oyuncu4_212701069.Visible = true;

                btn_Oyuncu1_212701069.Enabled = true;/* butonlara bastığımızda butonların  aktif  olmasını sağlar*/
                btn_Oyuncu2_212701069.Enabled = false;/* oyuncu 2'nin butonuna bastığımızda aktifliği kapanır */
                btn_Oyuncu3_212701069.Enabled = false;
                btn_Oyuncu4_212701069.Enabled = false;
               
                
            }
            if (yenioyuncusayisi_212701069 == 3) /*Eğer oyuncu sayısı 3 olursa*/
            {

                btn_Oyuncu1_212701069.Visible = true;  /* butonlara bastığımızda butonların görünür  olmasını sağlar*/
                btn_Oyuncu2_212701069.Visible = true;
                btn_Oyuncu3_212701069.Visible = true;
                btn_Oyuncu4_212701069.Visible = false ;/*  butonun  pasif  olmasını sağlar*/

                btn_Oyuncu1_212701069.Enabled = true; /*  butonun  aktif  olmasını sağlar*/
                btn_Oyuncu2_212701069.Enabled = false; /* butonlara bastığımızda butonların pasif  olmasını sağlar*/
                btn_Oyuncu3_212701069.Enabled = false;
                btn_Oyuncu4_212701069.Enabled = false;
               
            }
            if (yenioyuncusayisi_212701069 == 2) /*Eğer oyuncu sayısı 2 olursa*/
            {
                btn_Oyuncu2_212701069.Enabled = false;/*  butonun  pasif  olmasını sağlar*/
                btn_Oyuncu1_212701069.Visible = true;  /*  butonların görünür  olmasını sağlar*/
                btn_Oyuncu2_212701069.Visible = true; 
                btn_Oyuncu3_212701069.Visible = false; /*  butonun  pasif  olmasını sağlar*/
                btn_Oyuncu4_212701069.Visible = false; /*  butonun  pasif  olmasını sağlar*/

                btn_Oyuncu1_212701069.Enabled = true;/*  butonun  aktif  olmasını sağlar*/
                
                btn_Oyuncu3_212701069.Enabled = false;/*  butonların pasif  olmasını sağlar*/
                btn_Oyuncu4_212701069.Enabled = false;
                
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_Basla_212701069.Enabled = true;
            pictureBox1_212701069.Left = 0; /* sıfırla butonuna bastığımızda resimlerin ilk halini almasını sağlar */
            pictureBox2_212701069.Left = 0;
            pictureBox3_212701069.Left = 0;
            pictureBox4_212701069.Left = 0;

            btn_Oyuncu1_212701069.Enabled = true; /*  butonun aktifliğini kapatır*/
            btn_Oyuncu2_212701069.Enabled = false; /* butonların aktifliğini kapatır*/
            btn_Oyuncu3_212701069.Enabled = false;
            btn_Oyuncu4_212701069.Enabled = false;

            oyuncu1_212701069 = 0; /* oyuncuların random değerlerini sıfırlar*/
            oyuncu2_212701069 = 0;
            oyuncu3_212701069 = 0;
            oyuncu4_212701069 = 0;
        }
    }
}
