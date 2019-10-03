namespace MobidiagGUI
{
    partial class MainForm
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
            this.btnPrimeSummation = new System.Windows.Forms.Button();
            this.lblPrimeSummation = new System.Windows.Forms.Label();
            this.btnCollatz = new System.Windows.Forms.Button();
            this.lblCollatz = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrimeSummation
            // 
            this.btnPrimeSummation.Location = new System.Drawing.Point(72, 56);
            this.btnPrimeSummation.Name = "btnPrimeSummation";
            this.btnPrimeSummation.Size = new System.Drawing.Size(265, 38);
            this.btnPrimeSummation.TabIndex = 0;
            this.btnPrimeSummation.Text = "10. Sum all primes below  2mil";
            this.btnPrimeSummation.UseVisualStyleBackColor = true;
            this.btnPrimeSummation.Click += new System.EventHandler(this.btnPrimeSummation_Click);
            // 
            // lblPrimeSummation
            // 
            this.lblPrimeSummation.AutoSize = true;
            this.lblPrimeSummation.Location = new System.Drawing.Point(367, 65);
            this.lblPrimeSummation.Name = "lblPrimeSummation";
            this.lblPrimeSummation.Size = new System.Drawing.Size(132, 20);
            this.lblPrimeSummation.TabIndex = 1;
            this.lblPrimeSummation.Text = "not visible at start";
            this.lblPrimeSummation.Visible = false;
            // 
            // btnCollatz
            // 
            this.btnCollatz.Location = new System.Drawing.Point(72, 171);
            this.btnCollatz.Name = "btnCollatz";
            this.btnCollatz.Size = new System.Drawing.Size(265, 55);
            this.btnCollatz.TabIndex = 2;
            this.btnCollatz.Text = "14. Solve Longest Collatz sequence starting under 1mil";
            this.btnCollatz.UseVisualStyleBackColor = true;
            this.btnCollatz.Click += new System.EventHandler(this.BtnCollatz_Click);
            // 
            // lblCollatz
            // 
            this.lblCollatz.AutoSize = true;
            this.lblCollatz.Location = new System.Drawing.Point(367, 188);
            this.lblCollatz.Name = "lblCollatz";
            this.lblCollatz.Size = new System.Drawing.Size(132, 20);
            this.lblCollatz.TabIndex = 3;
            this.lblCollatz.Text = "not visible at start";
            this.lblCollatz.Visible = false;
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(72, 304);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(265, 55);
            this.btnFibonacci.TabIndex = 4;
            this.btnFibonacci.Text = "2. Sum even Fibonacci numbers under 4mil";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.BtnFibonacci_Click);
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(367, 321);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(132, 20);
            this.lblFibonacci.TabIndex = 5;
            this.lblFibonacci.Text = "not visible at start";
            this.lblFibonacci.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.lblCollatz);
            this.Controls.Add(this.btnCollatz);
            this.Controls.Add(this.lblPrimeSummation);
            this.Controls.Add(this.btnPrimeSummation);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobidiag Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimeSummation;
        private System.Windows.Forms.Label lblPrimeSummation;
        private System.Windows.Forms.Button btnCollatz;
        private System.Windows.Forms.Label lblCollatz;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Label lblFibonacci;
    }
}

