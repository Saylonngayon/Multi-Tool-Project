using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Multi_Tool_Project.Tools.Sec
{
    public partial class Cryptography : Form
    {
        public Cryptography()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = textBoxInput.Text;
            string key = textBoxKey.Text;

            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both text and key.");
                return;
            }

            try
            {
                string encryptedText = Encrypt(plainText, key);
                textBoxOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}");
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = textBoxInput.Text;
            string key = textBoxKey.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both text and key.");
                return;
            }

            try
            {
                string decryptedText = Decrypt(cipherText, key);
                textBoxOutput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption failed: {ex.Message}");
            }
        }

        private string Encrypt(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                Array.Resize(ref keyBytes, aes.KeySize / 8);
                aes.Key = keyBytes;

                aes.GenerateIV();
                byte[] iv = aes.IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }

                    byte[] encryptedBytes = ms.ToArray();
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        private string Decrypt(string cipherText, string key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                Array.Resize(ref keyBytes, aes.KeySize / 8);
                aes.Key = keyBytes;

                byte[] iv = new byte[aes.BlockSize / 8];
                Array.Copy(encryptedBytes, 0, iv, 0, iv.Length);
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        cs.Write(encryptedBytes, iv.Length, encryptedBytes.Length - iv.Length);
                    }

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Security securityForm = new Security();
            securityForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}