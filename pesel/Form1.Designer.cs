namespace pesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.buttonOdczytaj = new System.Windows.Forms.Button();
            this.labelPesel = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelMiesiac = new System.Windows.Forms.Label();
            this.labelDzien = new System.Windows.Forms.Label();
            this.labelCyfra = new System.Windows.Forms.Label();
            this.labelRok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(239, 68);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(252, 22);
            this.textBoxPesel.TabIndex = 0;
            this.textBoxPesel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesel_KeyDown);
            // 
            // buttonOdczytaj
            // 
            this.buttonOdczytaj.Location = new System.Drawing.Point(513, 64);
            this.buttonOdczytaj.Name = "buttonOdczytaj";
            this.buttonOdczytaj.Size = new System.Drawing.Size(76, 30);
            this.buttonOdczytaj.TabIndex = 1;
            this.buttonOdczytaj.Text = "Odczytaj";
            this.buttonOdczytaj.UseVisualStyleBackColor = true;
            this.buttonOdczytaj.Click += new System.EventHandler(this.buttonOdczytaj_Click);
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPesel.Location = new System.Drawing.Point(6, 69);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(203, 21);
            this.labelPesel.TabIndex = 2;
            this.labelPesel.Text = "Podaj numer PESEL:";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlec.Location = new System.Drawing.Point(125, 155);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(56, 25);
            this.labelPlec.TabIndex = 3;
            this.labelPlec.Text = "Płeć:";
            // 
            // labelMiesiac
            // 
            this.labelMiesiac.AutoSize = true;
            this.labelMiesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiesiac.Location = new System.Drawing.Point(5, 192);
            this.labelMiesiac.Name = "labelMiesiac";
            this.labelMiesiac.Size = new System.Drawing.Size(176, 25);
            this.labelMiesiac.TabIndex = 4;
            this.labelMiesiac.Text = "Miesiąc urodzenia:";
            // 
            // labelDzien
            // 
            this.labelDzien.AutoSize = true;
            this.labelDzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDzien.Location = new System.Drawing.Point(17, 228);
            this.labelDzien.Name = "labelDzien";
            this.labelDzien.Size = new System.Drawing.Size(164, 25);
            this.labelDzien.TabIndex = 5;
            this.labelDzien.Text = "Dzień urodzenia: ";
            // 
            // labelCyfra
            // 
            this.labelCyfra.AutoSize = true;
            this.labelCyfra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCyfra.Location = new System.Drawing.Point(26, 267);
            this.labelCyfra.Name = "labelCyfra";
            this.labelCyfra.Size = new System.Drawing.Size(155, 25);
            this.labelCyfra.TabIndex = 6;
            this.labelCyfra.Text = "Cyfra kontrolna: ";
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRok.Location = new System.Drawing.Point(33, 304);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(148, 25);
            this.labelRok.TabIndex = 7;
            this.labelRok.Text = "Rok urodzenia: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.labelCyfra);
            this.Controls.Add(this.labelDzien);
            this.Controls.Add(this.labelMiesiac);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.buttonOdczytaj);
            this.Controls.Add(this.textBoxPesel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = ":)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Button buttonOdczytaj;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelMiesiac;
        private System.Windows.Forms.Label labelDzien;
        private System.Windows.Forms.Label labelCyfra;
        private System.Windows.Forms.Label labelRok;
    }
}

