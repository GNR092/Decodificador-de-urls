using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Decodificador_de_urls
{
    public partial class Form1 : Form
    {
        public CharDetect CheckChar = new CharDetect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Decode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_Decode.Text)) TXT_Decode.Text.Remove(0, TXT_Decode.Text.Length);

            if (string.IsNullOrEmpty(TXT_PreDecode.Text))
            {
                MessageBox.Show("Campo vacio");
                TXT_PreDecode.Focus();
                return;
            }

            TXT_Decode.Text = CheckChar.CheckString(TXT_PreDecode.Text);

            TXT_Decode.Focus();
            TXT_Decode.SelectionStart = 0;
            TXT_Decode.SelectionLength = TXT_Decode.Text.Length;
            TXT_Decode.Copy();
            MessageBox.Show("Texto Copiado");

           
            


            
        }
    }
}
