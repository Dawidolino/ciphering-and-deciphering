using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace szyfrowanie_i_deszyfrowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hash = "hashkey@!#!@";
        //private void encryptButton_Click(object sender, EventArgs e)    //MD5 encryption
        //{
        //    byte[] data = UTF8Encoding.UTF8.GetBytes(textBox.Text);

        //    using (System.Security.Cryptography.MD5CryptoServiceProvider
        //    encr = new System.Security.Cryptography.MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = encr.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //        using (System.Security.Cryptography.TripleDESCryptoServiceProvider
        //        triDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider()
        //        {
        //            Key = keys,
        //            Mode = System.Security.Cryptography.CipherMode.ECB,
        //            Padding = System.Security.Cryptography.PaddingMode.PKCS7
        //        })
        //        {
        //            System.Security.Cryptography.ICryptoTransform transform = triDes.CreateEncryptor();
        //            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
        //            encryptionBox.Text = Convert.ToBase64String(result, 0, result.Length);
        //        }

        //    }
        //}
        //private void decryptButton_Click(object sender, EventArgs e)
        //{

        //    byte[] data = Convert.FromBase64String(encryptionBox.Text);
        //    using (System.Security.Cryptography.MD5CryptoServiceProvider
        //        md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //        using (System.Security.Cryptography.TripleDESCryptoServiceProvider
        //        triDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider()
        //        {
        //            Key = keys,
        //            Mode = System.Security.Cryptography.CipherMode.ECB,
        //            Padding = System.Security.Cryptography.PaddingMode.PKCS7
        //        })
        //        {
        //            System.Security.Cryptography.ICryptoTransform transform = triDes.CreateDecryptor();
        //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

        //            decryptionBox.Text = UTF8Encoding.UTF8.GetString(results);
        //        }
        //    }
        //}
        //private void loadButton_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {

        //        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        //        openFileDialog.FilterIndex = 2;
        //        openFileDialog.RestoreDirectory = true;
        //        openFileDialog.FileName = "";

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            //Get the path of specified file
        //            textBox.Text = openFileDialog.FileName;

        //            //Read the contents of the file into a stream
        //            var fileStream = openFileDialog.OpenFile();

        //            using (StreamReader reader = new StreamReader(fileStream))
        //            {
        //                textBox.Text = reader.ReadToEnd();
        //            }
        //        }
        //    }

        //}
        //private void saveButton_Click(object sender, EventArgs e)
        //{
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        // saveFileDialog.InitialDirectory = @"C:\";    
        //        saveFileDialog.RestoreDirectory = true;
        //        saveFileDialog.FileName = "*.txt";
        //        saveFileDialog.DefaultExt = "txt";
        //        saveFileDialog.Filter = "txt files (*.txt) | *.txt";
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            Stream fileStream = saveFileDialog.OpenFile();
        //            StreamWriter sw = new StreamWriter(fileStream);
        //            sw.Write(textBox.Text);
        //            sw.Close();
        //            fileStream.Close();
        //        }
        //    }
        //}
        //private void clearButton_Click(object sender, EventArgs e)
        //{
        //    textBox.Clear();
        //    decryptionBox.Clear();
        //    encryptionBox.Clear();
        //}
        //private void encryptionButton2_Click(object sender, EventArgs e) //unicode encryption
        //{
        //    encryptionBox.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(textBox.Text));

        //}
        //private void decryptionButton2_Click(object sender, EventArgs e)
        //{
        //    decryptionBox.Text = Encoding.Unicode.GetString(Convert.FromBase64String(encryptionBox.Text));

        //}

        private void encryptButton_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(textBox.Text);

            using (System.Security.Cryptography.MD5CryptoServiceProvider
            encr = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] keys = encr.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (System.Security.Cryptography.TripleDESCryptoServiceProvider
                triDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = System.Security.Cryptography.CipherMode.ECB,
                    Padding = System.Security.Cryptography.PaddingMode.PKCS7
                })
                {
                    System.Security.Cryptography.ICryptoTransform transform = triDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    encryptionBox.Text = Convert.ToBase64String(result, 0, result.Length);
                }

            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(encryptionBox.Text);
            using (System.Security.Cryptography.MD5CryptoServiceProvider
                md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (System.Security.Cryptography.TripleDESCryptoServiceProvider
                triDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = System.Security.Cryptography.CipherMode.ECB,
                    Padding = System.Security.Cryptography.PaddingMode.PKCS7
                })
                {
                    System.Security.Cryptography.ICryptoTransform transform = triDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    decryptionBox.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FileName = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBox.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // saveFileDialog.InitialDirectory = @"C:\";    
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "txt files (*.txt) | *.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = saveFileDialog.OpenFile();
                    StreamWriter sw = new StreamWriter(fileStream);
                    sw.Write(textBox.Text);
                    sw.Close();
                    fileStream.Close();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            decryptionBox.Clear();
            encryptionBox.Clear();
        }
        private void encryptionButton2_Click(object sender, EventArgs e)
        {
            encryptionBox.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(textBox.Text));

        }
        private void decryptionButton2_Click(object sender, EventArgs e)
        {
            decryptionBox.Text = Encoding.Unicode.GetString(Convert.FromBase64String(encryptionBox.Text));

        }

      
    }
}
