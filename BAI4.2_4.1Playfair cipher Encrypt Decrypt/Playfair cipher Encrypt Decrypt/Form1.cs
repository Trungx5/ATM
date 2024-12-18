using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Playfair_cipher_Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (TextBoxKey.Text.Length == 0)
            {
                MessageBox.Show("Please enter the key");
                return;
            }

            char[,] playfairtable = GeneratePlayFairTable(TextBoxKey.Text);

            //display arr
            DisplayTable(playfairtable);

            string input = "";
            foreach (char x in RichTextBoxInput.Text)
            {
                if (char.IsLetter(x))
                {
                    input += char.ToUpper(x);
                }
            }

            bool containsI = input.Contains('I');
            bool containsJ = input.Contains('J');

            if (containsI && containsJ)
            {
                MessageBox.Show("I and J cannot be in the same plaintext");
                return;
            }

            //insert X between double letters
            for (int i = 0; i < input.Length; i = i + 2)
            {
                if (((i + 2) < input.Length) && (input[i] == input[i + 1]))
                {
                    input = input.Insert(i + 1, "X");
                }
            }

            //split every two chars
            RichTextBoxOutput.Text = "";
            foreach (string s in SplitStrings(input, 2))
            {
                if (s.Length == 1)
                {
                    RichTextBoxOutput.Text += Encrypt(s + "X", playfairtable);
                    //continue;
                }
                else
                    RichTextBoxOutput.Text += Encrypt(s, playfairtable);
            }
        }

        private void DisplayTable(char[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                DataGridViewTable.Rows.Add();
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    DataGridViewTable.Rows[i].Cells[j].Value = table[i, j];
                }
            }
        }

        private string Encrypt(string plainText, char[,] table)
        {
            //find pos of each char in the string
            int[] first_char = findXinTable(plainText[0], table);
            int X_First_Char = first_char[0];
            int Y_First_Char = first_char[1];

            int[] second_char = findXinTable(plainText[1], table);
            int X_Second_Char = second_char[0];
            int Y_Second_Char = second_char[1];

            string output = "";

            //if both char are in the same column
            if (Y_First_Char == Y_Second_Char)
            {
                // shift to the bottom and mod 4 because x start at 0
                output += table[(X_First_Char + 1) % 5, Y_First_Char];
                output += table[(X_Second_Char + 1) % 5, Y_Second_Char];
                return output;

            }

            //if both char are in the same row
            if (X_First_Char == X_Second_Char)
            {
                // shift to the right and mod 4 because y start at 0
                output += table[X_First_Char, (Y_First_Char + 1) % 5];
                output += table[X_Second_Char, (Y_Second_Char + 1) % 5];
                return output;
            }

            //if both char are in different row and column
            output += table[X_First_Char, Y_Second_Char];
            output += table[X_Second_Char, Y_First_Char];
            return output;
        }

        private int[] findXinTable(char x, char[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == x)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        private List<string> SplitStrings(string input, int x)
        {
            List<string> output = new List<string>();
            int index_output = 0;
            // split string every x characters
            for (int i = 0; i < input.Length; i += x)
            {
                if (i + x >= input.Length)
                {
                    output.Add(input.Substring(i, input.Length - i));
                    break;
                }
                output.Add(input.Substring(i, x));
                index_output++;
            }
            return output;
        }

        private void RichTextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private char[,] GeneratePlayFairTable(string Keyin)
        {
            List<char> key = new List<char>();
            foreach (char c in Keyin)
            {
                if (char.IsLetter(c))
                {
                    key.Add(char.ToUpper(c));
                }
            }

            key = key.Distinct().ToList();
            char[,] playfairtable = new char[5, 5];

            // add the rest of the alphabet
            char character = 'A';
            while (key.Count < 26)
            {
                key.Add(character);
                key = key.Distinct().ToList();
                character++;
            }

            //remove duplicate I and J
            int containsIorJ = 0;
            for (int i = 0; i < key.Count; ++i)
            {
                if (key[i] == 'I' || key[i] == 'J')
                {
                    ++containsIorJ;
                    if (containsIorJ > 1)
                    {
                        key.Remove(key[i]);
                    }
                }
            }

            int charIndex = 0;
            for (int i = 0; i < playfairtable.GetLength(0); i++)
            {
                for (int j = 0; j < playfairtable.GetLength(1); j++)
                {
                    playfairtable[i, j] = key[charIndex];
                    charIndex++;
                }
            }
            return playfairtable;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (RichTextBoxOutput.Text.Length == 0)
            {
                MessageBox.Show("Please enter the cipher text");
                return;
            }
            char[,] playfairtable = GeneratePlayFairTable(TextBoxKey.Text);

            //display arr
            DisplayTable(playfairtable);

            //clean input
            string cipher_clean = "";
            foreach (char x in RichTextBoxOutput.Text)
            {
                if (char.IsLetter(x))
                {
                    cipher_clean += char.ToUpper(x);
                }
            }

            //split cipher text into substrings of 2
            List<string> cipher_list = SplitStrings(cipher_clean, 2);

            RichTextBoxInput.Text = "";
            foreach (string s in cipher_list)
            {
                RichTextBoxInput.Text += Decrypt(s, playfairtable);
            }

        }

        private string Decrypt(string cipherText, char[,] table)
        {
            //find pos of each char in the string
            int[] first_char = findXinTable(cipherText[0], table);
            int X_First_Char = first_char[0];
            int Y_First_Char = first_char[1];

            int[] second_char = findXinTable(cipherText[1], table);
            int X_Second_Char = second_char[0];
            int Y_Second_Char = second_char[1];

            string output = "";
            //if both char are in the same column
            if (Y_First_Char == Y_Second_Char)
            {
                //shift down 1
                //add 5 if the result is negative
                int X_First_Char_New_Pos = X_First_Char - 1;
                int X_Second_Char_New_Pos = X_Second_Char - 1;

                if (X_First_Char_New_Pos < 0)
                {
                    X_First_Char_New_Pos += 5;
                }

                if (X_Second_Char_New_Pos < 0)
                {
                    X_Second_Char_New_Pos += 5;
                }
                output += table[X_First_Char_New_Pos, Y_First_Char];
                output += table[X_Second_Char_New_Pos, Y_Second_Char];
                return output;

            }

            //if both char are in the same row
            if (X_First_Char == X_Second_Char)
            {
                // shift to the left and add 5 if the result is negative

                int Y_First_Char_New_Pos = Y_First_Char - 1;
                int Y_Second_Char_New_Pos = Y_Second_Char - 1;

                if (Y_First_Char_New_Pos < 0)
                {
                    Y_First_Char_New_Pos += 5;
                }

                if (Y_Second_Char_New_Pos < 0)
                {
                    Y_Second_Char_New_Pos += 5;
                }

                output += table[X_First_Char, Y_First_Char_New_Pos];
                output += table[X_Second_Char, Y_Second_Char_New_Pos];
                return output;
            }

            //if both char are in different row and column
            output += table[X_First_Char, Y_Second_Char];
            output += table[X_Second_Char, Y_First_Char];
            return output;
        }

        private void RandomEncryptButton_Click(object sender, EventArgs e)
        {
            // Generate a random key
            string randomKey = GenerateRandomKey();

            // Display the random key
            TextBoxKey.Text = randomKey;

            // Encrypt the input text using the random key
            ButtonEncrypt_Click(sender, e);
        }

        private string GenerateRandomKey()
        {
            Random random = new Random();
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Exclude 'J'
            char[] keyArray = new char[25];
            HashSet<char> usedChars = new HashSet<char>();

            for (int i = 0; i < 25; i++)
            {
                char randomChar;
                do
                {
                    randomChar = alphabet[random.Next(alphabet.Length)];
                } while (usedChars.Contains(randomChar));

                keyArray[i] = randomChar;
                usedChars.Add(randomChar);
            }

            return new string(keyArray);
        }

        private void Encrypt_Random_All_Click(object sender, EventArgs e)
        {
            // Generate a random plaintext
            string randomPlaintext = GenerateRandomPlaintext();

            // Generate a random key
            string randomKey = GenerateRandomKey();

            // Display the random plaintext and key
            RichTextBoxInput.Text = randomPlaintext;
            TextBoxKey.Text = randomKey;

            // Encrypt the random plaintext using the random key
            char[,] playfairtable = GeneratePlayFairTable(randomKey);
            DisplayTable(playfairtable);

            string input = "";
            foreach (char x in randomPlaintext)
            {
                if (char.IsLetter(x))
                {
                    input += char.ToUpper(x);
                }
            }

            // Insert X between double letters
            for (int i = 0; i < input.Length; i = i + 2)
            {
                if (((i + 2) < input.Length) && (input[i] == input[i + 1]))
                {
                    input = input.Insert(i + 1, "X");
                }
            }

            // Split into pairs and encrypt
            RichTextBoxOutput.Text = "";
            foreach (string s in SplitStrings(input, 2))
            {
                if (s.Length == 1)
                {
                    RichTextBoxOutput.Text += Encrypt(s + "X", playfairtable);
                }
                else
                {
                    RichTextBoxOutput.Text += Encrypt(s, playfairtable);
                }
            }
        }

        private string GenerateRandomPlaintext()
        {
            Random random = new Random();
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Exclude 'J'
            int length = random.Next(10, 20); // Random length between 10 and 20
            char[] plaintextArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                plaintextArray[i] = alphabet[random.Next(alphabet.Length)];
            }

            return new string(plaintextArray);
        }
    }
}