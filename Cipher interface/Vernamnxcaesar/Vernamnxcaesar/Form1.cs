using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vernamnxcaesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TbxPlain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComType.SelectedIndex == 0 && TbxKey.Text != string.Empty)
            {
                int key=0;
                try
                {
                    key = int.Parse(TbxKey.Text);
                    AddText(Caesar(key, e.KeyChar));
                }
                catch
                {
                    TbxKey.Text = "Enter numeric Key";
                }
            }

            if(ComType.SelectedIndex == 1 && TbxKey.Text != string.Empty)
            {
                string key = TbxKey.Text;
                Vernam(key, e.KeyChar);
            }
        }
        private void AddText(char e)
        {
            if (TbxKey.Text != string.Empty)
            {
                char temp = e;
                if (temp.ToString() == ((char)8).ToString() && TbxCiphert.Text != string.Empty)
                {
                    TbxCiphert.Text = TbxCiphert.Text.Substring(0, TbxCiphert.Text.Length - 1);
                }
                else if (temp.ToString() == ((char)8).ToString() && TbxCiphert.Text == string.Empty)
                { 
                }
                else
                {
                    TbxCiphert.Text += temp.ToString();
                }
            }
        }

        private char Caesar(int key,char e)
        {
            if (e == (char)8)
            {
                return e;
            }
            int e2 = (int)e + key;
            if (e2 > (int)'z')
            {
                while (e2 > (int)'z')
                {
                    e2 -= 26;
                }
            }
            char e3 = (char)e2;
            return e3;
        }

        private void Vernam(string key, char e)
        {

        }

        private void TbxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbxPlain.Text = string.Empty;
            TbxCiphert.Text = string.Empty;
        }

        private void TbxKey_MouseClick(object sender, MouseEventArgs e)
        {
            TbxKey.Text = string.Empty;
        }
    }
}
