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
            this.components = new System.ComponentModel.Container();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.bRestart = new System.Windows.Forms.Button();
            this.bKrok = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bPeriodickeKroky = new System.Windows.Forms.Button();
            this.nMiliseconds = new System.Windows.Forms.NumericUpDown();
            this.lPerioda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nMiliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // pCanvas
            // 
            this.pCanvas.Location = new System.Drawing.Point(26, 34);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(700, 700);
            this.pCanvas.TabIndex = 0;
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(807, 178);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(438, 123);
            this.bRestart.TabIndex = 1;
            this.bRestart.Text = "Start";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // bKrok
            // 
            this.bKrok.Enabled = false;
            this.bKrok.Location = new System.Drawing.Point(807, 316);
            this.bKrok.Name = "bKrok";
            this.bKrok.Size = new System.Drawing.Size(438, 123);
            this.bKrok.TabIndex = 2;
            this.bKrok.Text = "Udelej krok";
            this.bKrok.UseVisualStyleBackColor = true;
            this.bKrok.Click += new System.EventHandler(this.BKrok_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bPeriodickeKroky
            // 
            this.bPeriodickeKroky.Enabled = false;
            this.bPeriodickeKroky.Location = new System.Drawing.Point(807, 467);
            this.bPeriodickeKroky.Name = "bPeriodickeKroky";
            this.bPeriodickeKroky.Size = new System.Drawing.Size(181, 66);
            this.bPeriodickeKroky.TabIndex = 3;
            this.bPeriodickeKroky.Text = "Delat kroky automaticky";
            this.bPeriodickeKroky.UseVisualStyleBackColor = true;
            this.bPeriodickeKroky.Click += new System.EventHandler(this.BPeriodickeKroky_Click);
            // 
            // nMiliseconds
            // 
            this.nMiliseconds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nMiliseconds.Location = new System.Drawing.Point(1019, 490);
            this.nMiliseconds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nMiliseconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMiliseconds.Name = "nMiliseconds";
            this.nMiliseconds.Size = new System.Drawing.Size(120, 22);
            this.nMiliseconds.TabIndex = 5;
            this.nMiliseconds.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nMiliseconds.ValueChanged += new System.EventHandler(this.NMiliseconds_ValueChanged);
            // 
            // lPerioda
            // 
            this.lPerioda.AutoSize = true;
            this.lPerioda.Location = new System.Drawing.Point(1016, 470);
            this.lPerioda.Name = "lPerioda";
            this.lPerioda.Size = new System.Drawing.Size(89, 17);
            this.lPerioda.TabIndex = 6;
            this.lPerioda.Text = "Perioda (ms)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 766);
            this.Controls.Add(this.lPerioda);
            this.Controls.Add(this.nMiliseconds);
            this.Controls.Add(this.bPeriodickeKroky);
            this.Controls.Add(this.bKrok);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.pCanvas);
            this.Name = "Form1";
            this.Text = "Broučkúf svjet";
            ((System.ComponentModel.ISupportInitialize)(this.nMiliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button bKrok;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bPeriodickeKroky;
        private System.Windows.Forms.NumericUpDown nMiliseconds;
        private System.Windows.Forms.Label lPerioda;
    }
}

