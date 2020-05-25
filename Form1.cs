using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mutuSayi_Click(object sender, EventArgs e)
        {
            lbl_default.Text = "mutlu";
            label1.Text="Mutlu sayı mı?";
        }

        private void btn_mukemmelSayi_Click(object sender, EventArgs e)
        {
            lbl_default.Text = "mukemmel";
            label1.Text="Mükemmel sayı mı?";
        }

        private void btn_asalSayi_Click(object sender, EventArgs e)
        {
            lbl_default.Text = "asal";
            label1.Text="Asal sayı mı?";
        }
        static int numSquareSum(int n)
        {
            int squareSum = 0;
            while (n != 0)
            {
                squareSum += (n % 10) *
                             (n % 10);
                n /= 10;
            }
            return squareSum;
        }

        static bool isHappynumber(int n)
        {
            int slow, fast;
            slow = fast = n;
            do
            {
                slow = numSquareSum(slow);
                fast = numSquareSum(numSquareSum(fast));
            }
            while (slow != fast);
            return (slow == 1);
        }
        static bool perfectNumber(int num)
        {
            int n=num,toplam=0;
            List<int> liste=new List<int>();
            for (int i=1;i<num;i++)
            {
                if ((num%i)==0)
                {
                    liste.Add(i);
                }
            }
            foreach(int list in liste)
            {
                toplam+=list;
            }
            if (toplam == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (lbl_default.Text == "mutlu")
            {
                int n = int.Parse(textBox1.Text);
                if (isHappynumber(n))
                {
                    MessageBox.Show(n +
                    " sayısı mutlu sayı");
                }

                else
                {
                    MessageBox.Show(n +
                    " sayısı mutlu sayı değil");
                }
            }
            else if (lbl_default.Text == "mukemmel")
            {
                int num=int.Parse(textBox1.Text);
                if (perfectNumber(num))
                {
                    MessageBox.Show(num+ " sayısı mükemmel sayıdır.");
                }
                else
                {
                    MessageBox.Show(num+" sayısı mükemmel sayı değildir.");
                }
            }
            else if(lbl_default.Text=="asal")
            {
                bool asalmi=true;
                if (int.Parse(textBox1.Text) <= 2)
                {
                    MessageBox.Show("1 ve 2 sayıları asaldır.\n 1 den küçük sayılarda asal işlemi yapılmaz...");
                }
                else
                {
                    for (int i = 2; i < int.Parse(textBox1.Text); i++)
                    {
                        if (int.Parse(textBox1.Text) % i == 0)
                        {
                            asalmi=false;
                        }
                    }
                    if(asalmi==false) MessageBox.Show("sayı asal değil");
                    else MessageBox.Show("sayı asal");
                }
            }
        }
    }
}
