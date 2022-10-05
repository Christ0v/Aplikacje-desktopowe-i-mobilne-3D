
namespace FirstWinFormsApp
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonHelloName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(12, 312);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(216, 114);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "Przycisk";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(622, 312);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(189, 106);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(305, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(189, 47);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Podaj imię:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(285, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonHelloName
            // 
            this.buttonHelloName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelloName.Location = new System.Drawing.Point(285, 117);
            this.buttonHelloName.Name = "buttonHelloName";
            this.buttonHelloName.Size = new System.Drawing.Size(228, 67);
            this.buttonHelloName.TabIndex = 4;
            this.buttonHelloName.Text = "Przywitaj się";
            this.buttonHelloName.UseVisualStyleBackColor = false;
            this.buttonHelloName.Click += new System.EventHandler(this.buttonHelloName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.buttonHelloName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pierwszy program okienkowy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonHelloName;
    }
}

