namespace PocztaWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxRodzajPrzesylki = new System.Windows.Forms.GroupBox();
            this.radioButtonPaczka = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonPocztowka = new System.Windows.Forms.RadioButton();
            this.groupBoxDaneAdresowe = new System.Windows.Forms.GroupBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.textBoxKodPocztowy = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.labelKodPocztowy = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxRodzajPrzesylki.SuspendLayout();
            this.groupBoxDaneAdresowe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRodzajPrzesylki
            // 
            this.groupBoxRodzajPrzesylki.Controls.Add(this.radioButtonPaczka);
            this.groupBoxRodzajPrzesylki.Controls.Add(this.radioButtonList);
            this.groupBoxRodzajPrzesylki.Controls.Add(this.radioButtonPocztowka);
            this.groupBoxRodzajPrzesylki.Location = new System.Drawing.Point(32, 27);
            this.groupBoxRodzajPrzesylki.Name = "groupBoxRodzajPrzesylki";
            this.groupBoxRodzajPrzesylki.Size = new System.Drawing.Size(200, 129);
            this.groupBoxRodzajPrzesylki.TabIndex = 0;
            this.groupBoxRodzajPrzesylki.TabStop = false;
            this.groupBoxRodzajPrzesylki.Text = "Rodzaj przesyłki";
            // 
            // radioButtonPaczka
            // 
            this.radioButtonPaczka.AutoSize = true;
            this.radioButtonPaczka.Location = new System.Drawing.Point(24, 81);
            this.radioButtonPaczka.Name = "radioButtonPaczka";
            this.radioButtonPaczka.Size = new System.Drawing.Size(61, 17);
            this.radioButtonPaczka.TabIndex = 2;
            this.radioButtonPaczka.TabStop = true;
            this.radioButtonPaczka.Text = "Paczka";
            this.radioButtonPaczka.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(24, 58);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(41, 17);
            this.radioButtonList.TabIndex = 1;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "List";
            this.radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonPocztowka
            // 
            this.radioButtonPocztowka.AutoSize = true;
            this.radioButtonPocztowka.Location = new System.Drawing.Point(24, 35);
            this.radioButtonPocztowka.Name = "radioButtonPocztowka";
            this.radioButtonPocztowka.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPocztowka.TabIndex = 0;
            this.radioButtonPocztowka.TabStop = true;
            this.radioButtonPocztowka.Text = "Pocztówka";
            this.radioButtonPocztowka.UseVisualStyleBackColor = true;
            // 
            // groupBoxDaneAdresowe
            // 
            this.groupBoxDaneAdresowe.Controls.Add(this.textBoxMiasto);
            this.groupBoxDaneAdresowe.Controls.Add(this.textBoxKodPocztowy);
            this.groupBoxDaneAdresowe.Controls.Add(this.textBoxUlica);
            this.groupBoxDaneAdresowe.Controls.Add(this.labelMiasto);
            this.groupBoxDaneAdresowe.Controls.Add(this.labelKodPocztowy);
            this.groupBoxDaneAdresowe.Controls.Add(this.labelUlica);
            this.groupBoxDaneAdresowe.Location = new System.Drawing.Point(267, 27);
            this.groupBoxDaneAdresowe.Name = "groupBoxDaneAdresowe";
            this.groupBoxDaneAdresowe.Size = new System.Drawing.Size(226, 225);
            this.groupBoxDaneAdresowe.TabIndex = 1;
            this.groupBoxDaneAdresowe.TabStop = false;
            this.groupBoxDaneAdresowe.Text = "Dane adresowe";
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Location = new System.Drawing.Point(19, 160);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(169, 20);
            this.textBoxMiasto.TabIndex = 5;
            // 
            // textBoxKodPocztowy
            // 
            this.textBoxKodPocztowy.Location = new System.Drawing.Point(19, 109);
            this.textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            this.textBoxKodPocztowy.Size = new System.Drawing.Size(100, 20);
            this.textBoxKodPocztowy.TabIndex = 4;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(19, 58);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(175, 20);
            this.textBoxUlica.TabIndex = 3;
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Location = new System.Drawing.Point(19, 138);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(38, 13);
            this.labelMiasto.TabIndex = 2;
            this.labelMiasto.Text = "Miasto";
            // 
            // labelKodPocztowy
            // 
            this.labelKodPocztowy.AutoSize = true;
            this.labelKodPocztowy.Location = new System.Drawing.Point(19, 87);
            this.labelKodPocztowy.Name = "labelKodPocztowy";
            this.labelKodPocztowy.Size = new System.Drawing.Size(74, 13);
            this.labelKodPocztowy.TabIndex = 1;
            this.labelKodPocztowy.Text = "Kod pocztowy";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Location = new System.Drawing.Point(19, 36);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(85, 13);
            this.labelUlica.TabIndex = 0;
            this.labelUlica.Text = "Ulica z numerem";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(32, 162);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(200, 23);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Sprawdź cenę";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(32, 278);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(461, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Zatwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(161, 206);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 20);
            this.labelWynik.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PocztaWindowsFormsApp.Properties.Resources.pocztowka;
            this.pictureBox.Location = new System.Drawing.Point(34, 191);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 65);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 309);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.groupBoxDaneAdresowe);
            this.Controls.Add(this.groupBoxRodzajPrzesylki);
            this.Name = "Form1";
            this.Text = "Nadaj przesyłkę: PESEL: PESEL";
            this.groupBoxRodzajPrzesylki.ResumeLayout(false);
            this.groupBoxRodzajPrzesylki.PerformLayout();
            this.groupBoxDaneAdresowe.ResumeLayout(false);
            this.groupBoxDaneAdresowe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRodzajPrzesylki;
        private System.Windows.Forms.RadioButton radioButtonPaczka;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonPocztowka;
        private System.Windows.Forms.GroupBox groupBoxDaneAdresowe;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.Label labelKodPocztowy;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.TextBox textBoxKodPocztowy;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList imageList1;    

    }
}

