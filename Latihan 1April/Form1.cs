using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1April
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float Angka1 = 0;
        float Total = 0;
        float Tambah = 0;
        float Kurang = 0;
        float Kali = 0;
        float Bagi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxInput.Enabled = false;
            TextBoxOutput.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "1";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "9";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "6";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "3";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + "0";
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            Angka1 = float.Parse(TextBoxInput.Text);
            TextBoxInput.Text = "";
            Tambah++;
        }
       
        private void ButtonHasil_Click(object sender, EventArgs e)
        {
            float Angka2 = float.Parse(TextBoxInput.Text);
            if(Tambah != 0)
            {
                Total = Angka1 + Angka2;
            }
            else if(Kurang != 0)
            {
                Total = Angka1 - Angka2;
            }
            else if (Bagi != 0)
            {
                Total = Angka1 / Angka2;
            }
            else if (Kali != 0)
            {
                Total = Angka1 * Angka2;
            }
            TextBoxOutput.Text = Total.ToString();
            Angka1 = 0;
            Angka2 = 0;
            Total = 0;
            Tambah = 0;
            Kurang = 0;
            Kali = 0;
            Bagi = 0;
            TextBoxInput.Text = "";
        }

        private void ButtonHapusSemua_Click(object sender, EventArgs e)
        {
            TextBoxOutput.Text = "";
            TextBoxInput.Text = "";
        }

        private void ButtonKali_Click(object sender, EventArgs e)
        {
            Angka1 = float.Parse(TextBoxInput.Text);
            TextBoxInput.Text = "";
            Kali++;
        }

        private void ButtonBagi_Click(object sender, EventArgs e)
        {
            Angka1 = float.Parse(TextBoxInput.Text);
            TextBoxInput.Text = "";
            Bagi++;
        }

        private void ButtonKurang_Click(object sender, EventArgs e)
        {
            Angka1 = float.Parse(TextBoxInput.Text);
            TextBoxInput.Text = "";
            Kurang++;
        }

        private void ButtonPersen_Click(object sender, EventArgs e)
        {
            Angka1 = float.Parse(TextBoxInput.Text);
            TextBoxInput.Text = "";
            Angka1 = Angka1 / 100;
            TextBoxOutput.Text = Angka1.ToString();
            Angka1 = 0;
        }

        private void ButtonKoma_Click(object sender, EventArgs e)
        {
            TextBoxInput.Text = TextBoxInput.Text + ",";
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            int length = TextBoxInput.TextLength - 1;
            string text = TextBoxInput.Text;
            TextBoxInput.Clear();
            for (int i = 0; i < length; i++)
            {
                TextBoxInput.Text = TextBoxInput.Text + text[i];
            }

        }
    }
}
