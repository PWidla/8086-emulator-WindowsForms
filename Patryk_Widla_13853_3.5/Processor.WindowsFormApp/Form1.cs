using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Processor.WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMOV_Click(object sender, EventArgs e)
        {
            //duplikat
            if (listBox1.SelectedIndex==0 && listBox2.SelectedIndex==0)
            {
                axResult.Text = $"{textBoxAX.Text}";
            }
            else if (listBox1.SelectedIndex==1 && listBox2.SelectedIndex==1)
            {
                bxResult.Text = $"{textBoxBX.Text}";
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 2)
            {
                cxResult.Text = $"{textBoxCX.Text}";
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 3)
            {
                dxResult.Text = $"{textBoxDX.Text}";
            }

            //do AX
            if (listBox1.SelectedIndex==0 && listBox2.SelectedIndex==1)
            {
                axResult.Text = textBoxBX.Text;
            }
            else if (listBox1.SelectedIndex==0 && listBox2.SelectedIndex==2)
            {
                axResult.Text = textBoxCX.Text;
            }
            else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3)
            {
                axResult.Text = textBoxDX.Text;
            }

            //do BX
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
                bxResult.Text = textBoxAX.Text;
            }
            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                bxResult.Text = textBoxCX.Text;
            }
            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)
            {
                bxResult.Text = textBoxDX.Text;
            }

            //do CX
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                cxResult.Text = textBoxAX.Text;
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                cxResult.Text = textBoxBX.Text;
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3)
            {
                cxResult.Text = textBoxDX.Text;
            }

            //do DX
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                dxResult.Text = textBoxAX.Text;
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                dxResult.Text = textBoxBX.Text;
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 2)
            {
                dxResult.Text = textBoxCX.Text;
            }


        }

        private void btnXCHG_Click(object sender, EventArgs e)
        {
            //duplikat
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0)
            {
                axResult.Text = $"{textBoxAX.Text}";
            }
            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1)
            {
                bxResult.Text = $"{textBoxBX.Text}";
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 2)
            {
                cxResult.Text = $"{textBoxCX.Text}";
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 3)
            {
                dxResult.Text = $"{textBoxDX.Text}";
            }

            //z AX 
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
            {
                axResult.Text = textBoxBX.Text;
                bxResult.Text = textBoxAX.Text;
            }
            else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2)
            {
                axResult.Text = textBoxCX.Text;
                cxResult.Text = textBoxAX.Text;
            }
            else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3)
            {
                axResult.Text = textBoxDX.Text;
                dxResult.Text = textBoxAX.Text;
            }

            //z BX
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
                bxResult.Text = textBoxAX.Text;
                axResult.Text = textBoxBX.Text;
            }
            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                bxResult.Text = textBoxCX.Text;
                cxResult.Text = textBoxBX.Text;
            }
            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)
            {
                bxResult.Text = textBoxDX.Text;
                dxResult.Text = textBoxBX.Text;
            }

            //z CX
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                cxResult.Text = textBoxAX.Text;
                axResult.Text = textBoxCX.Text;
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                cxResult.Text = textBoxBX.Text;
                bxResult.Text = textBoxCX.Text;
            }
            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3)
            {
                cxResult.Text = textBoxDX.Text;
                dxResult.Text = textBoxCX.Text;
            }

            //z DX
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                dxResult.Text = textBoxAX.Text;
                axResult.Text = textBoxDX.Text;
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                dxResult.Text = textBoxBX.Text;
                bxResult.Text = textBoxDX.Text;
            }
            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 2)
            {
                dxResult.Text = textBoxCX.Text;
                cxResult.Text = textBoxDX.Text;
            }

        }

        static Random random = new Random();
        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = GetRandomHexNumber(8);
            textBoxBX.Text = GetRandomHexNumber(8);
            textBoxCX.Text = GetRandomHexNumber(8);
            textBoxDX.Text = GetRandomHexNumber(8);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = null;
            textBoxBX.Text = null;
            textBoxCX.Text = null;
            textBoxDX.Text = null;

            axResult.Text = null;
            bxResult.Text = null;
            cxResult.Text = null;
            dxResult.Text = null;
        }
    }
}
