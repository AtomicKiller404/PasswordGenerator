using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private int length = 8;
        private string upper_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string lower_chars = "abcdefghijklmnopqrstuvwxyz";
        private string num_chars = "0123456789";
        private string symbols_chars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = length;
        }

        private void button2_Click(object sender, EventArgs e) // Generate Password
        {
            if (length == 0) return;
            string chars = "";

            if (uppercase_checkBox.Checked) chars += upper_chars;
            if (lowercase_checkBox.Checked) chars += lower_chars;
            if (num_checkBox.Checked) chars += num_chars;
            if (symbols_checkBox.Checked) chars += symbols_chars;

            if (chars == "") return;

            passwordBox.Text = generatePassword(chars, length);

            chars = "";
        }

        private string generatePassword(string chars, int length)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] data = new byte[length];
                rng.GetBytes(data);

                StringBuilder result = new StringBuilder(length);
                foreach (byte b in data)
                {
                    result.Append(chars[b % chars.Length]);
                }

                return result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordBox.Text))
            {
                Clipboard.SetText(passwordBox.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No password generated yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            length = (int)numericUpDown1.Value;
        }
    }
}
