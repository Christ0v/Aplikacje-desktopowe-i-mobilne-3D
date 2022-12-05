
namespace Test
{
    partial class PierwiastekRownaniaKwadratowego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PierwiastekRownaniaKwadratowego));
            this.labelDane = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonPolicz = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDane
            // 
            this.labelDane.AutoSize = true;
            this.labelDane.Location = new System.Drawing.Point(40, 26);
            this.labelDane.Name = "labelDane";
            this.labelDane.Size = new System.Drawing.Size(34, 15);
            this.labelDane.TabIndex = 0;
            this.labelDane.Text = "Dane";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(46, 84);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 15);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(46, 119);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 15);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(46, 156);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(18, 15);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "C:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(83, 84);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 23);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(83, 119);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 23);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(83, 156);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 6;
            // 
            // buttonPolicz
            // 
            this.buttonPolicz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPolicz.Location = new System.Drawing.Point(83, 209);
            this.buttonPolicz.Name = "buttonPolicz";
            this.buttonPolicz.Size = new System.Drawing.Size(75, 23);
            this.buttonPolicz.TabIndex = 7;
            this.buttonPolicz.Text = "Policz";
            this.buttonPolicz.UseVisualStyleBackColor = true;
            this.buttonPolicz.Click += new System.EventHandler(this.buttonPolicz_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.Color.Black;
            this.labelWynik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWynik.Location = new System.Drawing.Point(83, 258);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 15);
            this.labelWynik.TabIndex = 8;
            // 
            // PierwiastekRownaniaKwadratowego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonPolicz);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelDane);
            this.Name = "PierwiastekRownaniaKwadratowego";
            this.Text = "PierwiastekKwadratowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDane;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonPolicz;
        private System.Windows.Forms.Label labelWynik;
    }
}

