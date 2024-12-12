using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RSA_cypher_ATM
{
    public partial class Form1 : Form
    {
        Random random = new Random();   
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (!(TextBoxP.Text == "") && !(TextboxQ.Text == "") && !(TextboxE.Text == "") 
                && CheckValid(BigInteger.Parse(TextBoxP.Text), BigInteger.Parse(TextboxQ.Text), BigInteger.Parse(TextboxE.Text)))
            {
                TextBoxD.Text = GenerateD(BigInteger.Parse(TextboxE.Text), (BigInteger.Parse(TextBoxP.Text) -1) *(BigInteger.Parse(TextboxQ.Text) - 1)).ToString();
            }
            else
            {
                try
                {
                    GenerateParameters();
                }
                catch
                {
                    ButtonGenerate_Click(sender, e);
                }
            }
        }

        private void GenerateParameters()
        {
            BigInteger p = random.Next();
            BigInteger q = random.Next();
            while (!isPrime(p))
            {
                p = random.Next();
            }
            while (!isPrime(q) || q == p)
            {
                q = random.Next();
            }

            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger e;
            checked
            {
                e = random.Next();
            }
            while (e <= 1 || e >= phi || BigInteger.GreatestCommonDivisor(phi, e) != 1)
            {
                e = random.Next();
            }

            BigInteger d = GenerateD(e, phi);

            TextBoxP.Text = p.ToString();
            TextboxQ.Text = q.ToString();
            TextboxE.Text = e.ToString();
            TextBoxD.Text = d.ToString();
        }

        private BigInteger GenerateD(BigInteger e, BigInteger phi)
        {
            BigInteger d = modInverse(e, phi);
            return d;
        }

        private bool CheckValid(BigInteger p, BigInteger q, BigInteger e)
        {
            if (p == q) { return false; }
            if ((!isPrime(p)) || (!isPrime(q)))
            {
                return false;
            }

            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            if (e <= 1 || e >= phi || BigInteger.GreatestCommonDivisor(e,phi) != 1)
            {
                return false;
            }

            return true;
        }

        private bool isPrime(BigInteger x)
        {
            if (x < 2) return false;
            for (BigInteger i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }


        BigInteger modInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if(TextBoxP.Text == "" || TextboxQ.Text == "" || TextboxE.Text == "" || TextBoxD.Text == "" || RichTextBoxInput.Text == "")
            {
                MessageBox.Show("Please generate parameters");
                return;
            }
            if(CheckBoxNumeric.Checked)
            {
               try
                {
                    BigInteger n = BigInteger.Parse(RichTextBoxInput.Text);
                    RichTextBoxOutput.Text = BigInteger.ModPow(n, BigInteger.Parse(TextboxE.Text), BigInteger.Parse(TextBoxP.Text) * BigInteger.Parse(TextboxQ.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Please enter valid M");
                    return;
                }

            }
            else
            {
                List<BigInteger> PlainText = new List<BigInteger>();
                foreach (char c in RichTextBoxInput.Text)
                {
                    PlainText.Add(c);
                }
                List<BigInteger> CipherText = new List<BigInteger>();
                foreach (BigInteger c in PlainText)
                {
                    CipherText.Add(BigInteger.ModPow(c, BigInteger.Parse(TextboxE.Text), BigInteger.Parse(TextBoxP.Text) * BigInteger.Parse(TextboxQ.Text)));
                }
                RichTextBoxOutput.Text = "";
                foreach (BigInteger c in CipherText)
                {
                    RichTextBoxOutput.Text += c.ToString() + " ";
                }
            }
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (TextBoxP.Text == "" || TextboxQ.Text == "" || TextboxE.Text == "" || TextBoxD.Text == "" || RichTextBoxOutput.Text == "")
            {
                MessageBox.Show("Please generate parameters");
                return;
            }
            
            if (CheckBoxNumeric.Checked)
            {
                try
                {
                    BigInteger n = BigInteger.Parse(RichTextBoxOutput.Text);
                    RichTextBoxInput.Text = BigInteger.ModPow(n, BigInteger.Parse(TextBoxD.Text), BigInteger.Parse(TextBoxP.Text) * BigInteger.Parse(TextboxQ.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Please enter valid C");
                }
            }
            else
            {
                RichTextBoxInput.Text = "";
               foreach (string s in RichTextBoxOutput.Text.Split(' '))
                {
                    if (s == "") continue;
                    try
                    {
                        BigInteger C = BigInteger.Parse(s);
                        RichTextBoxInput.Text += (char)BigInteger.ModPow(C, BigInteger.Parse(TextBoxD.Text), BigInteger.Parse(TextBoxP.Text) * BigInteger.Parse(TextboxQ.Text));
                    }

                    catch
                    {
                        MessageBox.Show("Please enter valid C");
                        return;
                    }
                }
            }
        }
    }
}
