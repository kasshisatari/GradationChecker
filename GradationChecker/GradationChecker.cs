/*
Copyright 2019 oscillo

Permission is hereby granted, free of charge,
to any person obtaining a copy of this software 
and associated documentation files (the "Software"),
to deal in the Software without restriction, 
including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit
persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission 
notice shall be included in all copies or substantial
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY
OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE 
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradationChecker
{
    public partial class GradationForm : Form
    {
        private ColorDialog cd = null;
        private static Bitmap bitmap = new Bitmap(400, 400);
        private static Graphics graphics = Graphics.FromImage(bitmap);
        private static string stopCaption = "Press N";
        private static string startCaption = "Spuit";
        public GradationForm()
        {
            InitializeComponent();
            UpdatePreview();
            cd = new ColorDialog();
            bitmap = new Bitmap(previewBox.Size.Width, previewBox.Size.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private int GetR(string str)
        {
            const string PREFIX = "&H";
            const string SUFFIX = "&";
            const int START = 4;
            if (0 > str.IndexOf(PREFIX))
            {
                throw new Exception();
            }
            str = str.Substring(str.IndexOf(PREFIX) + PREFIX.Length);
            if (0 > str.LastIndexOf(SUFFIX))
            {
                throw new Exception();
            }
            str = str.Substring(0, str.LastIndexOf(SUFFIX));
            if (6 != str.Length)
            {
                throw new Exception();
            }
            str = str.Substring(START, 2);
            str = str.ToUpper();
            char c = str[0];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            int val = 0;
            if ('0' <= c && c <= '9')
            {
                val = c - '0';
            }
            else
            {
                val = c - 'A' + 10;
            }
            c = str[1];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            val *= 16;
            if ('0' <= c && c <= '9')
            {
                val += c - '0';
            }
            else
            {
                val += c - 'A' + 10;
            }
            return val;
        }

        private int GetG(string str)
        {
            const string PREFIX = "&H";
            const string SUFFIX = "&";
            const int START = 2;
            if (0 > str.IndexOf(PREFIX))
            {
                throw new Exception();
            }
            str = str.Substring(str.IndexOf(PREFIX) + PREFIX.Length);
            if (0 > str.LastIndexOf(SUFFIX))
            {
                throw new Exception();
            }
            str = str.Substring(0, str.LastIndexOf(SUFFIX));
            if (6 != str.Length)
            {
                throw new Exception();
            }
            str = str.Substring(START, 2);
            str = str.ToUpper();
            char c = str[0];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            int val = 0;
            if ('0' <= c && c <= '9')
            {
                val = c - '0';
            }
            else
            {
                val = c - 'A' + 10;
            }
            c = str[1];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            val *= 16;
            if ('0' <= c && c <= '9')
            {
                val += c - '0';
            }
            else
            {
                val += c - 'A' + 10;
            }
            return val;
        }

        private int GetB(string str)
        {
            const string PREFIX = "&H";
            const string SUFFIX = "&";
            const int START = 0;
            if (0 > str.IndexOf(PREFIX))
            {
                throw new Exception();
            }
            str = str.Substring(str.IndexOf(PREFIX) + PREFIX.Length);
            if (0 > str.LastIndexOf(SUFFIX))
            {
                throw new Exception();
            }
            str = str.Substring(0, str.LastIndexOf(SUFFIX));
            if (6 != str.Length)
            {
                throw new Exception();
            }
            str = str.Substring(START, 2);
            str = str.ToUpper();
            char c = str[0];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            int val = 0;
            if ('0' <= c && c <= '9')
            {
                val = c - '0';
            }
            else
            {
                val = c - 'A' + 10;
            }
            c = str[1];
            if (false == Uri.IsHexDigit(c))
            {
                throw new Exception();
            }
            val *= 16;
            if ('0' <= c && c <= '9')
            {
                val += c - '0';
            }
            else
            {
                val += c - 'A' + 10;
            }
            return val;
        }

        private void UpdatePreview()
        {
            try
            {
                const int WIDTH = 400;
                const int HEIGHT = 400;
                Bitmap img = new Bitmap(WIDTH, HEIGHT);
                int leftTopR = GetR(leftTopText.Text);
                int leftTopG = GetG(leftTopText.Text);
                int leftTopB = GetB(leftTopText.Text);
                int rightTopR = GetR(rightTopText.Text);
                int rightTopG = GetG(rightTopText.Text);
                int rightTopB = GetB(rightTopText.Text);
                int leftBottomR = GetR(leftBottomText.Text);
                int leftBottomG = GetG(leftBottomText.Text);
                int leftBottomB = GetB(leftBottomText.Text);
                int rightBottomR = GetR(rightBottomText.Text);
                int rightBottomG = GetG(rightBottomText.Text);
                int rightBottomB = GetB(rightBottomText.Text);

                for (int y = 0; y < HEIGHT; ++y)
                {
                    for (int x = 0; x < WIDTH; x++)
                    {
                        double s = (double)x / (double)WIDTH;
                        double t = (double)y / (double)HEIGHT;
                        Color c = Color.FromArgb(
                            (int)((1 - s) * (1 - t) * leftTopR + s * (1 - t) * rightTopR + (1 - s) * t * leftBottomR + s * t * rightBottomR),
                            (int)((1 - s) * (1 - t) * leftTopG + s * (1 - t) * rightTopG + (1 - s) * t * leftBottomG + s * t * rightBottomG),
                            (int)((1 - s) * (1 - t) * leftTopB + s * (1 - t) * rightTopB + (1 - s) * t * leftBottomB + s * t * rightBottomB)
                        );
                        img.SetPixel(x, y, c);
                    }
                }
                previewBox.Image = img;
                resultText.Text = "{\\1vc(" + leftTopText.Text + "," + rightTopText.Text + "," + leftBottomText.Text + "," + rightBottomText.Text + ")}";
            }
            catch
            {

            }
        }

        private void leftTopButton_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            try
            {
                r = GetR(leftTopText.Text);
                g = GetG(leftTopText.Text);
                b = GetB(leftTopText.Text);
            }
            catch
            {
                r = 0;
                g = 0;
                b = 0;
            }
            cd.FullOpen = true;
            cd.Color = Color.FromArgb(r, g, b);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                leftTopText.Text = "&H" + cd.Color.B.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.R.ToString("X2") +  "&";
            }
            UpdatePreview();
        }

        private void rightTopButton_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            try
            {
                r = GetR(rightTopText.Text);
                g = GetG(rightTopText.Text);
                b = GetB(rightTopText.Text);
            }
            catch
            {
                r = 0;
                g = 0;
                b = 0;
            }
            cd.FullOpen = true;
            cd.Color = Color.FromArgb(r, g, b);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rightTopText.Text = "&H" + cd.Color.B.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.R.ToString("X2") + "&";
            }
            UpdatePreview();
        }

        private void leftBottomButton_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            try
            {
                r = GetR(leftBottomText.Text);
                g = GetG(leftBottomText.Text);
                b = GetB(leftBottomText.Text);
            }
            catch
            {
                r = 0;
                g = 0;
                b = 0;
            }
            cd.FullOpen = true;
            cd.Color = Color.FromArgb(r, g, b);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                leftBottomText.Text = "&H" + cd.Color.B.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.R.ToString("X2") + "&";
            }
            UpdatePreview();
        }

        private void rightBottomButton_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            try
            {
                r = GetR(rightBottomText.Text);
                g = GetG(rightBottomText.Text);
                b = GetB(rightBottomText.Text);
            }
            catch
            {
                r = 0;
                g = 0;
                b = 0;
            }
            cd.FullOpen = true;
            cd.Color = Color.FromArgb(r, g, b);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rightBottomText.Text = "&H" + cd.Color.B.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.R.ToString("X2") + "&";
            }
            UpdatePreview();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void resultText_Click(object sender, EventArgs e)
        {
            resultText.SelectAll();
        }

        private void leftTopText_Click(object sender, EventArgs e)
        {
            leftTopText.SelectAll();
        }

        private void rightTopText_Click(object sender, EventArgs e)
        {
            rightTopText.SelectAll();
        }

        private void leftBottomText_Click(object sender, EventArgs e)
        {
            leftBottomText.SelectAll();
        }

        private void rightBottomText_Click(object sender, EventArgs e)
        {
            rightBottomText.SelectAll();
        }

        private string PreviewSpuit()
        {
            int width = previewBox.Size.Width;
            int height = previewBox.Size.Height;
            Bitmap img = new Bitmap(width, height);
            while (GetAsyncKeyState('N') == 0)
            {
                graphics.CopyFromScreen(
                    Cursor.Position.X - (width / 2), Cursor.Position.Y - (height / 2), 
                    0, 0, 
                    new Size(width, height));
                graphics.DrawLine(
                    Pens.Black, 
                    width * 1 / 4, height / 2, 
                    width * 3 / 4, height / 2);
                graphics.DrawLine(
                    Pens.Black, 
                    width / 2, height * 1 / 4, 
                    width / 2, height * 3 / 4);
                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; x++)
                    {
                        img.SetPixel(x, y, bitmap.GetPixel(x, y));
                    }
                }
                previewBox.Image = img;
                previewBox.Refresh();
                Application.DoEvents();
                Task.Delay(100);
            }
            graphics.CopyFromScreen(Cursor.Position.X, Cursor.Position.Y, 0, 0, new Size(1, 1));
            Color color = bitmap.GetPixel(0, 0);
            return "&H" + color.B.ToString("X2") + color.G.ToString("X2") + color.R.ToString("X2") + "&";
        }

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        private void leftTopSpuitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            leftTopSpuitButton.Text = stopCaption;
            leftTopSpuitButton.Refresh();
            leftTopText.Text = PreviewSpuit();
            Cursor = Cursors.Arrow;
            leftTopSpuitButton.Text = startCaption;
            leftTopSpuitButton.Refresh();
            UpdatePreview();
        }

        private void rightTopSpuitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            rightTopSpuitButton.Text = stopCaption;
            rightTopSpuitButton.Refresh();
            rightTopText.Text = PreviewSpuit();
            Cursor = Cursors.Arrow;
            rightTopSpuitButton.Text = startCaption;
            rightTopSpuitButton.Refresh();
            UpdatePreview();
        }

        private void leftBottomSpuitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            leftBottomSpuitButton.Text = stopCaption;
            leftBottomSpuitButton.Refresh();
            leftBottomText.Text = PreviewSpuit();
            Cursor = Cursors.Arrow;
            leftBottomSpuitButton.Text = startCaption;
            leftBottomSpuitButton.Refresh();
            UpdatePreview();
        }

        private void rightBottomSpuitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            rightBottomSpuitButton.Text = stopCaption;
            rightBottomSpuitButton.Refresh();
            rightBottomText.Text = PreviewSpuit();
            Cursor = Cursors.Arrow;
            rightBottomSpuitButton.Text = startCaption;
            rightBottomSpuitButton.Refresh();
            UpdatePreview();
        }
    }
}
