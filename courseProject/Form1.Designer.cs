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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLine
            // 
            this.firstLine.Location = new System.Drawing.Point(333, 41);
            this.firstLine.Name = "firstLine";
            this.firstLine.Size = new System.Drawing.Size(296, 20);
            this.firstLine.TabIndex = 0;
            // 
            // secondLine
            // 
            this.secondLine.Location = new System.Drawing.Point(333, 101);
            this.secondLine.Name = "secondLine";
            this.secondLine.Size = new System.Drawing.Size(296, 20);
            this.secondLine.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(230, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первая строка";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(230, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторая строка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Расстояния Левенштейна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(334, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 233);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пусто";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondLine);
            this.Controls.Add(this.firstLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox firstLine;
        private System.Windows.Forms.TextBox secondLine;

        #endregion
    }
}