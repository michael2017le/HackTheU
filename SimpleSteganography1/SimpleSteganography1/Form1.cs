using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleSteganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile("Original");
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(OriginalFilePath.Text);
            //Console.WriteLine("ORIGINAL FILE PATH TEXT: " + OriginalFilePath.Text);
            //int x = 0;
            for (int i = 0; i < img.Width; i++)   
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    int digit1, digit2, digit3;
                    if (j < EnterMessage.TextLength)
                    {
                        //x += 2;

                        char letter = Convert.ToChar(EnterMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        digit1 = letter / 100;
                        digit2 = (letter - (digit1 * 100)) / 10;
                        digit3 = (letter - (digit1 * 100) - (digit2 * 10));

                        /*Console.WriteLine("First Value" + digit1);
                        Console.WriteLine("Second Value" + digit2);
                        Console.WriteLine("Third Value" + digit3);
                        Console.WriteLine("letter : " + letter + " value : " + value);*/
                        //Console.WriteLine("X: " + x + "i: " + i + "j: " + j);
                        //Console.WriteLine("Image Width: " + img.Width);
                        /*if (x >= img.Width)
                        {
                            x = 2;
                        }*/
                        //img.SetPixel(x - 1, j, Color.FromArgb(pixel.R, pixel.G, pixel.B));
                        if (pixel.R - 9 < 0 || pixel.G - 9 < 0 || pixel.B - 9 < 0)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R + digit1, pixel.G + digit2, pixel.B + digit3));
                        }
                        else
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R - digit1, pixel.G - digit2, pixel.B - digit3));
                        }

                        //img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                        if (i == img.Width - 1 && j == img.Height -1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, EnterMessage.TextLength));
                            //img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, EnterMessage.TextLength));
                        }
                    }
                }
                
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png) | *.png";
            saveFile.InitialDirectory = @"C:\Users\erict\OneDrive\Pictures\Hack The U\Sten";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                OriginalFilePath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = OriginalFilePath.Text;

                img.Save(OriginalFilePath.Text);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(StenFilePath.Text);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            int x = 0;
            for (int i = 0; i < img.Width / 2; i++)  
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (i < 1 && j < msgLength)
                    {
                        //Console.WriteLine("X: " + x + " i: " + i + " j: " + j);
                        x += 2;
                        if (x >= img.Width)
                        {
                            x = 2;
                        }
                        Color pixel = img.GetPixel(x, j);
                        Color previousPixel = img.GetPixel(x - 1, j);

                        int rOriginal = previousPixel.R;
                        int gOriginal = previousPixel.G;
                        int bOriginal = previousPixel.B;
                        int rNew = pixel.R;
                        int gNew = pixel.G;
                        int bNew = pixel.B;

                        int value; 
                        if(rOriginal - 9 < 0 || gOriginal - 9 < 0 || bOriginal - 9 < 0)
                        {
                            value = (
                            ((rNew - rOriginal) * 100) +
                            ((gNew - gOriginal) * 10) +
                            (bNew - bOriginal));
                        }
                        else
                        {
                            value = (
                            ((rOriginal - rNew) * 100) +
                            ((gOriginal - gNew) * 10) +
                            (bOriginal - bNew));
                        }


                        //int value = pixel.B;
                        char c = Convert.ToChar(value);
                        Console.WriteLine("Value" + value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
                x = 0;
            }

            ReturnMessage.Text = message;
        }

        private void OpenStenFile_Click(object sender, EventArgs e)
        {
            OpenFile("Sten");
        }

        private void OpenFile(string type)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png) | *.png";
            if (type == "Sten")
            {
                openDialog.InitialDirectory = @"C:\Users\erict\OneDrive\Pictures\Hack The U\Sten";
            }
            else if (type == "Original")
            {
                openDialog.InitialDirectory = @"C:\Users\erict\OneDrive\Pictures\Hack The U\Poke";
            }
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (type == "Original")
                {
                    OriginalFilePath.Text = openDialog.FileName.ToString();
                    pictureBox1.ImageLocation = OriginalFilePath.Text;
                }
                else if (type == "Sten")
                {
                    StenFilePath.Text = openDialog.FileName.ToString();
                    pictureBox1.ImageLocation = StenFilePath.Text;
                }
            }
        }

        private void FindFolder_Click(object sender, EventArgs e)
        {

        }

        private void EncryptMultiple_Click(object sender, EventArgs e)
        {
            for(int k = 1; k <= 151; k++)
            {
                FolderFinder.Text = @"C:\Users\erict\OneDrive\Pictures\Hack The U\Poke3\" + k + ".png";
                 Bitmap img = new Bitmap(FolderFinder.Text);

                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);
                        int digit1, digit2, digit3;
                        if (j < EnterMessage.TextLength)
                        {
                            char letter = Convert.ToChar(EnterMessage.Text.Substring(j, 1));
                            int value = Convert.ToInt32(letter);
                            digit1 = letter / 100;
                            digit2 = (letter - (digit1 * 100)) / 10;
                            digit3 = (letter - (digit1 * 100) - (digit2 * 10));
                            if (pixel.R - 9 < 0 || pixel.G - 9 < 0 || pixel.B - 9 < 0)
                            {
                                img.SetPixel(i, j, Color.FromArgb(pixel.R + digit1, pixel.G + digit2, pixel.B + digit3));
                            }
                            else
                            {
                                img.SetPixel(i, j, Color.FromArgb(pixel.R - digit1, pixel.G - digit2, pixel.B - digit3));
                            }

                            if (i == img.Width - 1 && j == img.Height - 1)
                            {
                                img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, EnterMessage.TextLength));
                            }
                        }
                    }
                }
                FolderFinder.Text = @"C:\Users\erict\OneDrive\Pictures\Hack The U\Sten\" + k + "Sten3.png";
                img.Save(FolderFinder.Text);
            }
        }

    }
}
