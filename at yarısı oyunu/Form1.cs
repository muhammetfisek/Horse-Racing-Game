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
    public partial class frm_GirisEkrani_212701069 : Form
    {
        public frm_GirisEkrani_212701069()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try /* try catch yaparak if else de verilen değerin dışında bir değer girildiğinde kodun hatasını engeller*/
            {
                int oyuncusayisi_212701069;
                oyuncusayisi_212701069 = Convert.ToInt32(txtOyuncu_Sayisi_212701069.Text); /* oyuncusayisi değişkenini int e çevirir  */
                if (oyuncusayisi_212701069 >= 2 && oyuncusayisi_212701069 <= 4)
                {

                    frm_YarisAlani_212701069 yeniform_212701069 = new frm_YarisAlani_212701069(oyuncusayisi_212701069); /* eğer oyuncu sayısı 2 ve 4 arasında olursa yarış alanını açar*/
                    yeniform_212701069.Show();
                    this.Hide(); /* oyuna gir butonuna bastığımızda giriş sayfasını kapatır*/

                }
                else
                {
                    MessageBox.Show(" 2 ile 4 arasında oyuncu sayısı giriniz: "); /* oyuncu sayısı 2,3 veya 4 değilse ekrana yazdırır */
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" 2 ile 4 arasında oyuncu sayısı giriniz: "); /* oyuncu sayısı 2,3 veya 4 değilse ekrana yazdırır */

            }
                
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
