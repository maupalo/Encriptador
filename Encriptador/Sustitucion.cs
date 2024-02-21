using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class Sustitucion : Form
    {
        public Sustitucion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = EncryptROT4(textBox1.Text);
        }
        private string EncryptROT4(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char offset = char.IsUpper(chars[i]) ? 'A' : 'a';
                    int displacement = chars[i] == 'ñ' || chars[i] == 'Ñ' ? 15 : 4; // 'ñ' and 'Ñ' are 15 positions apart from 'a' and 'A'
                    chars[i] = (char)((((chars[i] + displacement) - offset) % 27) + offset);
                }
            }
            return new string(chars);
        }
        static string DecryptROT4(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char offset = char.IsUpper(chars[i]) ? 'A' : 'a';
                    int displacement = chars[i] == 'ñ' || chars[i] == 'Ñ' ? 15 : 4; // 'ñ' and 'Ñ' are 15 positions apart from 'a' and 'A'
                    chars[i] = (char)((((chars[i] - displacement + 27) - offset) % 27) + offset);
                }
            }
            return new string(chars);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DecryptROT4(textBox2.Text);
        }
    }
}
