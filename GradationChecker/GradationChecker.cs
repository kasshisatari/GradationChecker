﻿/*
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
        public GradationForm()
        {
            InitializeComponent();
            UpdatePreview();
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
            ColorDialog cd = new ColorDialog();
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
            ColorDialog cd = new ColorDialog();
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
            ColorDialog cd = new ColorDialog();
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
            ColorDialog cd = new ColorDialog();
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
    }
}
