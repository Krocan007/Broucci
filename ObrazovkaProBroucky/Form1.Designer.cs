namespace ObrazovkaProBroucky
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
            this.pCanvas = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.bKrok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pCanvas
            // 
            this.pCanvas.Location = new System.Drawing.Point(26, 34);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(700, 700);
            this.pCanvas.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(807, 178);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(438, 123);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // bKrok
            // 
            this.bKrok.Location = new System.Drawing.Point(807, 316);
            this.bKrok.Name = "bKrok";
            this.bKrok.Size = new System.Drawing.Size(438, 123);
            this.bKrok.TabIndex = 2;
            this.bKrok.Text = "Udelej krok";
            this.bKrok.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 766);
            this.Controls.Add(this.bKrok);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bKrok;
    }
}

