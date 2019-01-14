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

namespace GradationChecker
{
    partial class GradationForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.leftTopText = new System.Windows.Forms.TextBox();
            this.rightTopText = new System.Windows.Forms.TextBox();
            this.leftBottomText = new System.Windows.Forms.TextBox();
            this.rightBottomText = new System.Windows.Forms.TextBox();
            this.leftTopButton = new System.Windows.Forms.Button();
            this.rightTopButton = new System.Windows.Forms.Button();
            this.leftBottomButton = new System.Windows.Forms.Button();
            this.rightBottomButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.previewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(12, 12);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(400, 400);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // leftTopText
            // 
            this.leftTopText.Location = new System.Drawing.Point(645, 43);
            this.leftTopText.Name = "leftTopText";
            this.leftTopText.Size = new System.Drawing.Size(116, 25);
            this.leftTopText.TabIndex = 5;
            this.leftTopText.Text = "&HFFFFFF&";
            this.leftTopText.Click += new System.EventHandler(this.leftTopText_Click);
            // 
            // rightTopText
            // 
            this.rightTopText.Location = new System.Drawing.Point(645, 103);
            this.rightTopText.Name = "rightTopText";
            this.rightTopText.Size = new System.Drawing.Size(116, 25);
            this.rightTopText.TabIndex = 5;
            this.rightTopText.Text = "&HFFFFFF&";
            this.rightTopText.Click += new System.EventHandler(this.rightTopText_Click);
            // 
            // leftBottomText
            // 
            this.leftBottomText.Location = new System.Drawing.Point(645, 158);
            this.leftBottomText.Name = "leftBottomText";
            this.leftBottomText.Size = new System.Drawing.Size(116, 25);
            this.leftBottomText.TabIndex = 5;
            this.leftBottomText.Text = "&HFFFFFF&";
            this.leftBottomText.Click += new System.EventHandler(this.leftBottomText_Click);
            // 
            // rightBottomText
            // 
            this.rightBottomText.Location = new System.Drawing.Point(645, 214);
            this.rightBottomText.Name = "rightBottomText";
            this.rightBottomText.Size = new System.Drawing.Size(116, 25);
            this.rightBottomText.TabIndex = 5;
            this.rightBottomText.Text = "&HFFFFFF&";
            this.rightBottomText.Click += new System.EventHandler(this.rightBottomText_Click);
            // 
            // leftTopButton
            // 
            this.leftTopButton.Location = new System.Drawing.Point(436, 41);
            this.leftTopButton.Name = "leftTopButton";
            this.leftTopButton.Size = new System.Drawing.Size(166, 28);
            this.leftTopButton.TabIndex = 7;
            this.leftTopButton.Text = "Left Top";
            this.leftTopButton.UseVisualStyleBackColor = true;
            this.leftTopButton.Click += new System.EventHandler(this.leftTopButton_Click);
            // 
            // rightTopButton
            // 
            this.rightTopButton.Location = new System.Drawing.Point(436, 100);
            this.rightTopButton.Name = "rightTopButton";
            this.rightTopButton.Size = new System.Drawing.Size(166, 28);
            this.rightTopButton.TabIndex = 7;
            this.rightTopButton.Text = "Right Top";
            this.rightTopButton.UseVisualStyleBackColor = true;
            this.rightTopButton.Click += new System.EventHandler(this.rightTopButton_Click);
            // 
            // leftBottomButton
            // 
            this.leftBottomButton.Location = new System.Drawing.Point(436, 158);
            this.leftBottomButton.Name = "leftBottomButton";
            this.leftBottomButton.Size = new System.Drawing.Size(166, 28);
            this.leftBottomButton.TabIndex = 7;
            this.leftBottomButton.Text = "Left Bottom";
            this.leftBottomButton.UseVisualStyleBackColor = true;
            this.leftBottomButton.Click += new System.EventHandler(this.leftBottomButton_Click);
            // 
            // rightBottomButton
            // 
            this.rightBottomButton.Location = new System.Drawing.Point(436, 214);
            this.rightBottomButton.Name = "rightBottomButton";
            this.rightBottomButton.Size = new System.Drawing.Size(166, 28);
            this.rightBottomButton.TabIndex = 7;
            this.rightBottomButton.Text = "Right Bottom";
            this.rightBottomButton.UseVisualStyleBackColor = true;
            this.rightBottomButton.Click += new System.EventHandler(this.rightBottomButton_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(435, 296);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(527, 25);
            this.resultText.TabIndex = 8;
            this.resultText.Click += new System.EventHandler(this.resultText_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(792, 63);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(159, 151);
            this.previewButton.TabIndex = 9;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // GradationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 425);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.rightBottomButton);
            this.Controls.Add(this.leftBottomButton);
            this.Controls.Add(this.rightTopButton);
            this.Controls.Add(this.leftTopButton);
            this.Controls.Add(this.rightBottomText);
            this.Controls.Add(this.leftBottomText);
            this.Controls.Add(this.rightTopText);
            this.Controls.Add(this.leftTopText);
            this.Controls.Add(this.previewBox);
            this.Name = "GradationForm";
            this.Text = "GradationChecker";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.TextBox leftTopText;
        private System.Windows.Forms.TextBox rightTopText;
        private System.Windows.Forms.TextBox leftBottomText;
        private System.Windows.Forms.TextBox rightBottomText;
        private System.Windows.Forms.Button leftTopButton;
        private System.Windows.Forms.Button rightTopButton;
        private System.Windows.Forms.Button leftBottomButton;
        private System.Windows.Forms.Button rightBottomButton;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button previewButton;
    }
}

