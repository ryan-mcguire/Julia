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
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImageHeight = new System.Windows.Forms.TextBox();
            this.textBoxImageWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.buttonMandelbrot.Location = new System.Drawing.Point(315, 397);
            this.buttonMandelbrot.Name = "buttonMandelbrot";
            this.buttonMandelbrot.Size = new System.Drawing.Size(75, 23);
            this.buttonMandelbrot.TabIndex = 15;
            this.buttonMandelbrot.Text = "Mandelbrot";
            this.buttonMandelbrot.UseVisualStyleBackColor = true;
            this.buttonMandelbrot.Click += new System.EventHandler(this.buttonMandelbrot_Click);
            // 
            // buttonJulia
            // 
            this.buttonJulia.Location = new System.Drawing.Point(396, 397);
            this.buttonJulia.Name = "buttonJulia";
            this.buttonJulia.Size = new System.Drawing.Size(75, 23);
            this.buttonJulia.TabIndex = 16;
            this.buttonJulia.Text = "Julia";
            this.buttonJulia.UseVisualStyleBackColor = true;
            this.buttonJulia.Click += new System.EventHandler(this.buttonJulia_Click);
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(232, 442);
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
            this.label1.Location = new System.Drawing.Point(228, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Presets";
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.Location = new System.Drawing.Point(232, 201);
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxXMin.TabIndex = 20;
            this.textBoxXMin.Text = "-2.000";
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(350, 201);
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxXMax.TabIndex = 21;
            this.textBoxXMax.Text = "2.000";
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.Location = new System.Drawing.Point(118, 229);
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxYMin.TabIndex = 22;
            this.textBoxYMin.Text = "-2.000";
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(118, 283);
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxYMax.TabIndex = 23;
            this.textBoxYMax.Text = "2.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "x";
            // 
            // textBoxImageHeight
            // 
            this.textBoxImageHeight.Location = new System.Drawing.Point(232, 321);
            this.textBoxImageHeight.Name = "textBoxImageHeight";
            this.textBoxImageHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxImageHeight.TabIndex = 26;
            this.textBoxImageHeight.Text = "200";
            // 
            // textBoxImageWidth
            // 
            this.textBoxImageWidth.Location = new System.Drawing.Point(232, 348);
            this.textBoxImageWidth.Name = "textBoxImageWidth";
            this.textBoxImageWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxImageWidth.TabIndex = 27;
            this.textBoxImageWidth.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "image height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "image width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxImageWidth);
            this.Controls.Add(this.textBoxImageHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYMax);
            this.Controls.Add(this.textBoxYMin);
            this.Controls.Add(this.textBoxXMax);
            this.Controls.Add(this.textBoxXMin);
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
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImageHeight;
        private System.Windows.Forms.TextBox textBoxImageWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

