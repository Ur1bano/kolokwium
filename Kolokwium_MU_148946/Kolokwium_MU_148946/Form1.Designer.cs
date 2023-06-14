namespace Kolokwium_MU_148946
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.poziom_aktywnosci = new System.Windows.Forms.ComboBox();
            this.numeric_wiek = new System.Windows.Forms.NumericUpDown();
            this.numeric_waga = new System.Windows.Forms.NumericUpDown();
            this.numeric_wzrost = new System.Windows.Forms.NumericUpDown();
            this.zapisz_oblicz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioMezczyzna = new System.Windows.Forms.RadioButton();
            this.radioKobieta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wzrost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj płeć:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj wiek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Podaj wagę:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaj wzrost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kalkulator BMI";
            // 
            // poziom_aktywnosci
            // 
            this.poziom_aktywnosci.FormattingEnabled = true;
            this.poziom_aktywnosci.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5 dni tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność"});
            this.poziom_aktywnosci.Location = new System.Drawing.Point(63, 240);
            this.poziom_aktywnosci.Name = "poziom_aktywnosci";
            this.poziom_aktywnosci.Size = new System.Drawing.Size(167, 21);
            this.poziom_aktywnosci.TabIndex = 5;
            // 
            // numeric_wiek
            // 
            this.numeric_wiek.Location = new System.Drawing.Point(114, 126);
            this.numeric_wiek.Name = "numeric_wiek";
            this.numeric_wiek.Size = new System.Drawing.Size(140, 20);
            this.numeric_wiek.TabIndex = 6;
            this.numeric_wiek.ValueChanged += new System.EventHandler(this.numeric_wiek_ValueChanged);
            // 
            // numeric_waga
            // 
            this.numeric_waga.Location = new System.Drawing.Point(114, 157);
            this.numeric_waga.Name = "numeric_waga";
            this.numeric_waga.Size = new System.Drawing.Size(140, 20);
            this.numeric_waga.TabIndex = 7;
            this.numeric_waga.ValueChanged += new System.EventHandler(this.numeric_waga_ValueChanged);
            // 
            // numeric_wzrost
            // 
            this.numeric_wzrost.Location = new System.Drawing.Point(114, 188);
            this.numeric_wzrost.Name = "numeric_wzrost";
            this.numeric_wzrost.Size = new System.Drawing.Size(140, 20);
            this.numeric_wzrost.TabIndex = 8;
            this.numeric_wzrost.ValueChanged += new System.EventHandler(this.numeric_wzrost_ValueChanged);
            // 
            // zapisz_oblicz
            // 
            this.zapisz_oblicz.Location = new System.Drawing.Point(93, 267);
            this.zapisz_oblicz.Name = "zapisz_oblicz";
            this.zapisz_oblicz.Size = new System.Drawing.Size(106, 24);
            this.zapisz_oblicz.TabIndex = 9;
            this.zapisz_oblicz.Text = "Zapisz i oblicz";
            this.zapisz_oblicz.UseVisualStyleBackColor = true;
            this.zapisz_oblicz.Click += new System.EventHandler(this.zapisz_oblicz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(18-99)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Poziom aktywsności fizycznej:";
            // 
            // radioMezczyzna
            // 
            this.radioMezczyzna.AutoSize = true;
            this.radioMezczyzna.Location = new System.Drawing.Point(114, 83);
            this.radioMezczyzna.Name = "radioMezczyzna";
            this.radioMezczyzna.Size = new System.Drawing.Size(34, 17);
            this.radioMezczyzna.TabIndex = 14;
            this.radioMezczyzna.TabStop = true;
            this.radioMezczyzna.Text = "M";
            this.radioMezczyzna.UseVisualStyleBackColor = true;
            // 
            // radioKobieta
            // 
            this.radioKobieta.AutoSize = true;
            this.radioKobieta.Location = new System.Drawing.Point(154, 83);
            this.radioKobieta.Name = "radioKobieta";
            this.radioKobieta.Size = new System.Drawing.Size(32, 17);
            this.radioKobieta.TabIndex = 15;
            this.radioKobieta.TabStop = true;
            this.radioKobieta.Text = "K";
            this.radioKobieta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.radioKobieta);
            this.Controls.Add(this.radioMezczyzna);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zapisz_oblicz);
            this.Controls.Add(this.numeric_wzrost);
            this.Controls.Add(this.numeric_waga);
            this.Controls.Add(this.numeric_wiek);
            this.Controls.Add(this.poziom_aktywnosci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wzrost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox poziom_aktywnosci;
        private System.Windows.Forms.NumericUpDown numeric_wiek;
        private System.Windows.Forms.NumericUpDown numeric_waga;
        private System.Windows.Forms.NumericUpDown numeric_wzrost;
        private System.Windows.Forms.Button zapisz_oblicz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioMezczyzna;
        private System.Windows.Forms.RadioButton radioKobieta;
    }
}

