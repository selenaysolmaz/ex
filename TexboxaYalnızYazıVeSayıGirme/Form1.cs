using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexboxaYalnızYazıVeSayıGirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_YalnizKarakter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_YalnizSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
        private void txt_CharacterCasingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToUpper.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_CharacterCasingToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToLower.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
