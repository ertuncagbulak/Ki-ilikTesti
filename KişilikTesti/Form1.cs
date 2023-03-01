using System.Windows.Forms;

namespace KişilikTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ss = 0;
        int puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            puan = puan + 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            puan = puan + 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            puan = puan + 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            puan = puan + 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            puan = puan + 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ss++;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            label1.Text=ss.ToString();
            button6.Text = "Sıradaki";
            if (ss == 1)
            {
                richTextBox1.Text = "Sabahları neşeli bir şekilde uyanırım.";
            }
            else if (ss == 2)
            {
                richTextBox1.Text = "Çoğunlukla neşem yerindedir.";
            }
            else if (ss == 3)
            {
                richTextBox1.Text = "Çoğu kimse tarafından sevilirim.";
            }
            else if (ss == 4)
            {
                richTextBox1.Text = "Aynaya baktığım zaman, aynada gördüklerim hoşuma gider.";
            }
            else if (ss == 5)
            {
                richTextBox1.Text = "Eğer karşı cinsten biri olsaydım kendimi çekici bulurdum.";
            }
            else if (ss == 6)
            {
                richTextBox1.Text = "Zeki bir insanım.";
            }
            else if (ss == 7)
            {
                richTextBox1.Text = "İşimden hoşlanırım.";
            }
            else if (ss == 8)
            {
                richTextBox1.Text = "Kendimle ilgili olarak utanılacak pek bir şey göremiyorum.";
            }
            else if (ss == 9)
            {
                richTextBox1.Text = "Arkadaşlarımın sayısı yönünden içim rahat";
            }
            else if (ss == 10)
            {
                richTextBox1.Text = "Oldukça enerjik bir insanım.";
            }
            else if (ss == 11)
            {
                richTextBox1.Text = "Esas olarak iyimser bir kişiyim.";
            }
            else if (ss == 12)
            {
                richTextBox1.Text = "Kendi hatalarıma gülebilirim.";
            }
            else if (ss == 13)
            {
                richTextBox1.Text = "Eğer yaşama yeniden başlama olanağım olsaydı, değiştirmek istediğim pek bir şey olmazdı.";
            }
            else if (ss == 14)
            {
                richTextBox1.Text = "Ben ilginç bir insanım.";
            }
            else if (ss == 15)
            {
                richTextBox1.Text = "Cinsel yaşamımdan memnunum.";
                button6.Text="Bitir";
            }
            else if (ss == 16)
            {
                label1.Visible=false;
                richTextBox1.Clear();
                MessageBox.Show("Test Bitmiştir. Puanınınız: " + puan);
                if (puan <= 47)
                {
                    MessageBox.Show("Kanka Kendine Kötü Olursun Bak");
                }
                else if ( 47< puan && puan <85)
                {
                    MessageBox.Show("İyisin İyi");
                }
                else
                {
                    MessageBox.Show("Salladın Dimi.. Neyse Sallamadıysan Hayatından Baya Memnunsun Demek");
                }
            }

            
        }   
    }
}