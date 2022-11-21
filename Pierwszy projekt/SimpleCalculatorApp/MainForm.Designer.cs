
namespace SimpleCalculatorApp
{
    partial class MainForm
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
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(188, 38);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(85, 15);
            this.labelFirstNumber.TabIndex = 0;
            this.labelFirstNumber.Text = "Pierwsza liczba";
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(188, 56);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstNumber.TabIndex = 1;
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(446, 37);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(72, 15);
            this.labelSecondNumber.TabIndex = 2;
            this.labelSecondNumber.Text = "Druga liczba";
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(446, 56);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxSecondNumber.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(188, 102);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(284, 102);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(379, 102);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 6;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(471, 102);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(618, 56);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Prosty kalkulator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label labelResult;
    }
}

