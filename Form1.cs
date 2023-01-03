using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizligi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carpma_butonu_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(screen.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sayi1_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text=="0")
            {
                screen.Text = "";
            }
            screen.Text += "1";
        }

        private void sayi2_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "2";
        }

        private void sayi3_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "3";
        }

        private void sayi4_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "4";
        }

        private void sayi5_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "5";
        }

        private void sayi6_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "6";
        }

        private void sayi7_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "8";
        }

        private void sayi9_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "9";
        }

        private void sayi0_btn_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi)
            {
                screen.Text = "";
                _ekrantemizligi = false;
            }
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            screen.Text += "0";
        }

        private void topla_butonu_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(screen.Text);
        }

        private void cikart_butonu_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(screen.Text);
        }

        private void bolme_butonu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(screen.Text);
        }

        private void esittir_butonu_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(screen.Text);
            int sonuc=0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    break;
            }
            screen.Text = Convert.ToString(sonuc);
                 
        }
    }
}
