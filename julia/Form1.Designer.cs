namespace julia
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXCR = new System.Windows.Forms.TextBox();
            this.textBoxYCR = new System.Windows.Forms.TextBox();
            this.textBox1CR = new System.Windows.Forms.TextBox();
            this.textBoxXCI = new System.Windows.Forms.TextBox();
            this.textBoxYCI = new System.Windows.Forms.TextBox();
            this.textBox1CI = new System.Windows.Forms.TextBox();
            this.textBoxXZR = new System.Windows.Forms.TextBox();
            this.textBoxYZR = new System.Windows.Forms.TextBox();
            this.textBox1ZR = new System.Windows.Forms.TextBox();
            this.textBoxXZI = new System.Windows.Forms.TextBox();
            this.textBoxYZI = new System.Windows.Forms.TextBox();
            this.textBox1ZI = new System.Windows.Forms.TextBox();
            this.buttonMandelbrot = new System.Windows.Forms.Button();
            this.buttonJulia = new System.Windows.Forms.Button();
            this.buttonRender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "[ cr, ci, zr, zi ] = [ x, y, 1 ] X Transform Matrix";
            // 
            // textBoxXCR
            // 
            this.textBoxXCR.Location = new System.Drawing.Point(232, 84);
            this.textBoxXCR.Name = "textBoxXCR";
            this.textBoxXCR.Size = new System.Drawing.Size(100, 20);
            this.textBoxXCR.TabIndex = 3;
            this.textBoxXCR.Text = "1.000";
            // 
            // textBoxYCR
            // 
            this.textBoxYCR.Location = new System.Drawing.Point(232, 110);
            this.textBoxYCR.Name = "textBoxYCR";
            this.textBoxYCR.Size = new System.Drawing.Size(100, 20);
            this.textBoxYCR.TabIndex = 4;
            this.textBoxYCR.Text = "0.000";
            // 
            // textBox1CR
            // 
            this.textBox1CR.Location = new System.Drawing.Point(232, 136);
            this.textBox1CR.Name = "textBox1CR";
            this.textBox1CR.Size = new System.Drawing.Size(100, 20);
            this.textBox1CR.TabIndex = 5;
            this.textBox1CR.Text = "0.000";
            // 
            // textBoxXCI
            // 
            this.textBoxXCI.Location = new System.Drawing.Point(338, 84);
            this.textBoxXCI.Name = "textBoxXCI";
            this.textBoxXCI.Size = new System.Drawing.Size(100, 20);
            this.textBoxXCI.TabIndex = 6;
            this.textBoxXCI.Text = "0.000";
            // 
            // textBoxYCI
            // 
            this.textBoxYCI.Location = new System.Drawing.Point(338, 110);
            this.textBoxYCI.Name = "textBoxYCI";
            this.textBoxYCI.Size = new System.Drawing.Size(100, 20);
            this.textBoxYCI.TabIndex = 7;
            this.textBoxYCI.Text = "1.000";
            // 
            // textBox1CI
            // 
            this.textBox1CI.Location = new System.Drawing.Point(338, 136);
            this.textBox1CI.Name = "textBox1CI";
            this.textBox1CI.Size = new System.Drawing.Size(100, 20);
            this.textBox1CI.TabIndex = 8;
            this.textBox1CI.Text = "0.000";
            // 
            // textBoxXZR
            // 
            this.textBoxXZR.Location = new System.Drawing.Point(444, 84);
            this.textBoxXZR.Name = "textBoxXZR";
            this.textBoxXZR.Size = new System.Drawing.Size(100, 20);
            this.textBoxXZR.TabIndex = 9;
            this.textBoxXZR.Text = "0.000";
            // 
            // textBoxYZR
            // 
            this.textBoxYZR.Location = new System.Drawing.Point(444, 110);
            this.textBoxYZR.Name = "textBoxYZR";
            this.textBoxYZR.Size = new System.Drawing.Size(100, 20);
            this.textBoxYZR.TabIndex = 10;
            this.textBoxYZR.Text = "0.000";
            // 
            // textBox1ZR
            // 
            this.textBox1ZR.Location = new System.Drawing.Point(444, 136);
            this.textBox1ZR.Name = "textBox1ZR";
            this.textBox1ZR.Size = new System.Drawing.Size(100, 20);
            this.textBox1ZR.TabIndex = 11;
            this.textBox1ZR.Text = "0.000";
            // 
            // textBoxXZI
            // 
            this.textBoxXZI.Location = new System.Drawing.Point(550, 84);
            this.textBoxXZI.Name = "textBoxXZI";
            this.textBoxXZI.Size = new System.Drawing.Size(100, 20);
            this.textBoxXZI.TabIndex = 12;
            this.textBoxXZI.Text = "0.000";
            // 
            // textBoxYZI
            // 
            this.textBoxYZI.Location = new System.Drawing.Point(550, 110);
            this.textBoxYZI.Name = "textBoxYZI";
            this.textBoxYZI.Size = new System.Drawing.Size(100, 20);
            this.textBoxYZI.TabIndex = 13;
            this.textBoxYZI.Text = "0.000";
            // 
            // textBox1ZI
            // 
            this.textBox1ZI.Location = new System.Drawing.Point(550, 136);
            this.textBox1ZI.Name = "textBox1ZI";
            this.textBox1ZI.Size = new System.Drawing.Size(100, 20);
            this.textBox1ZI.TabIndex = 14;
            this.textBox1ZI.Text = "0.000";
            // 
            // buttonMandelbrot
            // 
            this.buttonMandelbrot.Location = new System.Drawing.Point(232, 219);
            this.buttonMandelbrot.Name = "buttonMandelbrot";
            this.buttonMandelbrot.Size = new System.Drawing.Size(75, 23);
            this.buttonMandelbrot.TabIndex = 15;
            this.buttonMandelbrot.Text = "Mandelbrot";
            this.buttonMandelbrot.UseVisualStyleBackColor = true;
            this.buttonMandelbrot.Click += new System.EventHandler(this.buttonMandelbrot_Click);
            // 
            // buttonJulia
            // 
            this.buttonJulia.Location = new System.Drawing.Point(313, 219);
            this.buttonJulia.Name = "buttonJulia";
            this.buttonJulia.Size = new System.Drawing.Size(75, 23);
            this.buttonJulia.TabIndex = 16;
            this.buttonJulia.Text = "Julia";
            this.buttonJulia.UseVisualStyleBackColor = true;
            this.buttonJulia.Click += new System.EventHandler(this.buttonJulia_Click);
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(232, 286);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(75, 23);
            this.buttonRender.TabIndex = 17;
            this.buttonRender.Text = "Render";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Preset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "...where x and y and each in the range [-2, +2]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.buttonJulia);
            this.Controls.Add(this.buttonMandelbrot);
            this.Controls.Add(this.textBox1ZI);
            this.Controls.Add(this.textBoxYZI);
            this.Controls.Add(this.textBoxXZI);
            this.Controls.Add(this.textBox1ZR);
            this.Controls.Add(this.textBoxYZR);
            this.Controls.Add(this.textBoxXZR);
            this.Controls.Add(this.textBox1CI);
            this.Controls.Add(this.textBoxYCI);
            this.Controls.Add(this.textBoxXCI);
            this.Controls.Add(this.textBox1CR);
            this.Controls.Add(this.textBoxYCR);
            this.Controls.Add(this.textBoxXCR);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXCR;
        private System.Windows.Forms.TextBox textBoxYCR;
        private System.Windows.Forms.TextBox textBox1CR;
        private System.Windows.Forms.TextBox textBoxXCI;
        private System.Windows.Forms.TextBox textBoxYCI;
        private System.Windows.Forms.TextBox textBox1CI;
        private System.Windows.Forms.TextBox textBoxXZR;
        private System.Windows.Forms.TextBox textBoxYZR;
        private System.Windows.Forms.TextBox textBox1ZR;
        private System.Windows.Forms.TextBox textBoxXZI;
        private System.Windows.Forms.TextBox textBoxYZI;
        private System.Windows.Forms.TextBox textBox1ZI;
        private System.Windows.Forms.Button buttonMandelbrot;
        private System.Windows.Forms.Button buttonJulia;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

