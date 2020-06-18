using System;
using System.Text;
using System.Windows.Forms;

namespace dynamic_aes
{
    public partial class FrmEncrypt : Form
    {
        private Aes.KeySize keysize;
        public FrmEncrypt()
        {
            InitializeComponent();
        }

        private void btnEncrpyt_Click(object sender, EventArgs e)
        {
            if (rbtn128.Checked)
                keysize = Aes.KeySize.Bits128;
            else if (rbt192.Checked)
                keysize = Aes.KeySize.Bits192;
            else
                keysize = Aes.KeySize.Bits256;

            byte[] plainText = new byte[16];
            byte[] cipherText = new byte[16];

            plainText = Encoding.Unicode.GetBytes(txtPlainText.Text.PadRight(8, ' '));
            var aes = new Aes(keysize, new byte[16]);
            aes.Cipher(plainText, cipherText);
            txtResult.Text = Encoding.Unicode.GetString(cipherText);
        }
    }
}
