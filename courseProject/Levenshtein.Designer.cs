
namespace courseProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstLine = new System.Windows.Forms.TextBox();
            this.secondLine = new System.Windows.Forms.TextBox();
            this.labelForFirstLine = new System.Windows.Forms.Label();
            this.labelForSecondLine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelForDistance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstLine
            // 
            this.firstLine.Location = new System.Drawing.Point(444, 50);
            this.firstLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstLine.Name = "firstLine";
            this.firstLine.Size = new System.Drawing.Size(393, 22);
            this.firstLine.TabIndex = 0;
            // 
            // secondLine
            // 
            this.secondLine.Location = new System.Drawing.Point(444, 124);
            this.secondLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondLine.Name = "secondLine";
            this.secondLine.Size = new System.Drawing.Size(393, 22);
            this.secondLine.TabIndex = 2;
            // 
            // labelForFirstLine
            // 
            this.labelForFirstLine.Location = new System.Drawing.Point(307, 50);
            this.labelForFirstLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForFirstLine.Name = "labelForFirstLine";
            this.labelForFirstLine.Size = new System.Drawing.Size(129, 25);
            this.labelForFirstLine.TabIndex = 3;
            this.labelForFirstLine.Text = "Первая строка";
            // 
            // labelForSecondLine
            // 
            this.labelForSecondLine.Location = new System.Drawing.Point(307, 124);
            this.labelForSecondLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForSecondLine.Name = "labelForSecondLine";
            this.labelForSecondLine.Size = new System.Drawing.Size(129, 25);
            this.labelForSecondLine.TabIndex = 4;
            this.labelForSecondLine.Text = "Вторая строка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Расстояния Левенштейна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelForDistance
            // 
            this.labelForDistance.AutoSize = true;
            this.labelForDistance.Location = new System.Drawing.Point(59, 21);
            this.labelForDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForDistance.Name = "labelForDistance";
            this.labelForDistance.Size = new System.Drawing.Size(47, 17);
            this.labelForDistance.TabIndex = 6;
            this.labelForDistance.Text = "Пусто";
            this.labelForDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelForDistance);
            this.panel1.Location = new System.Drawing.Point(444, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 263);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelForSecondLine);
            this.Controls.Add(this.labelForFirstLine);
            this.Controls.Add(this.secondLine);
            this.Controls.Add(this.firstLine);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Levenshtein";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label labelForDistance;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label labelForSecondLine;

        private System.Windows.Forms.Label labelForFirstLine;

        private System.Windows.Forms.TextBox firstLine;
        private System.Windows.Forms.TextBox secondLine;

        #endregion
    }
}