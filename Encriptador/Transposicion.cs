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
    public partial class Transposicion : Form
    {
        public Transposicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbEncriptado.Text = Encrypt(tbTextoPlano.Text, tbLlave.Text);
        }
        // Decrypts a string encrypted using a Columnar Transposition Cipher with a Keyword
        public static string Decrypt(string cipherText, string keyword)
        {
            // Calculate the number of rows and columns required based on the length of the ciphertext and the keyword
            int numRows = (int)Math.Ceiling((double)cipherText.Length / keyword.Length);
            int numCols = keyword.Length;

            // Create a list to store the column order based on the alphabetical order of the keyword
            List<int> columnOrder = Enumerable.Range(0, keyword.Length).ToList();
            columnOrder.Sort((a, b) => keyword[a].CompareTo(keyword[b]));

            // Create a 2D array to represent the grid
            char[,] grid = new char[numRows, numCols];

            // Fill the grid with the ciphertext characters
            int index = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (index < cipherText.Length)
                    {
                        grid[row, col] = cipherText[index++];
                    }
                    else
                    {
                        grid[row, col] = ' ';
                    }
                }
            }

            // Read the grid row-wise to get the plaintext
            string plainText = "";
            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    plainText += grid[row, columnOrder[col]];
                }
            }

            return plainText.Trim(); // Remove any extra spaces at the end
        }
        // Encrypts a string using a Columnar Transposition Cipher with a Keyword
        public static string Encrypt(string plainText, string keyword)
        {
            // Remove any spaces in the plaintext
            plainText = plainText.Replace(" ", "");

            // Create a list to store the column order based on the alphabetical order of the keyword
            List<int> columnOrder = Enumerable.Range(0, keyword.Length).ToList();
            columnOrder.Sort((a, b) => keyword[a].CompareTo(keyword[b]));

            // Calculate the number of rows and columns required based on the length of the plaintext and the keyword
            int numRows = (int)Math.Ceiling((double)plainText.Length / keyword.Length);
            int numCols = keyword.Length;

            // Create a 2D array to represent the grid
            char[,] grid = new char[numRows, numCols];

            // Fill the grid with the plaintext characters
            int index = 0;
            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    if (index < plainText.Length)
                    {
                        grid[row, columnOrder[col]] = plainText[index++];
                    }
                    else
                    {
                        grid[row, columnOrder[col]] = ' ';
                    }
                }
            }

            // Read the grid column-wise to get the ciphertext
            string cipherText = "";
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    cipherText += grid[row, col];
                }
            }

            return cipherText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbTextoPlano.Text = Decrypt(tbEncriptado.Text, tbLlave.Text);
        }
    }
}
