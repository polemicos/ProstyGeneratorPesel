
namespace pesel_MikitaRakovich
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
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.PESEL = new System.Windows.Forms.Label();
            this.labelDataUrodzenia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxPlec = new System.Windows.Forms.TextBox();
            this.labelBlad = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSprawdz = new System.Windows.Forms.TabPage();
            this.tabPageGeneruj = new System.Windows.Forms.TabPage();
            this.textBoxPeselGen = new System.Windows.Forms.TextBox();
            this.labelPeselGen = new System.Windows.Forms.Label();
            this.buttonSubmitGen = new System.Windows.Forms.Button();
            this.textBoxPlecGen = new System.Windows.Forms.TextBox();
            this.textBoxDataGen = new System.Windows.Forms.TextBox();
            this.labelPlecGen = new System.Windows.Forms.Label();
            this.labelDataUrGen = new System.Windows.Forms.Label();
            this.labelUdane = new System.Windows.Forms.Label();
            this.labelBladPlecGen = new System.Windows.Forms.Label();
            this.labelBladDataGen = new System.Windows.Forms.Label();
            this.labelUdaneGen = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageSprawdz.SuspendLayout();
            this.tabPageGeneruj.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(133, 67);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesel.TabIndex = 0;
            // 
            // PESEL
            // 
            this.PESEL.AutoSize = true;
            this.PESEL.Location = new System.Drawing.Point(133, 48);
            this.PESEL.Name = "PESEL";
            this.PESEL.Size = new System.Drawing.Size(95, 13);
            this.PESEL.TabIndex = 1;
            this.PESEL.Text = "Wprowadz PESEL";
            this.PESEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDataUrodzenia
            // 
            this.labelDataUrodzenia.AutoSize = true;
            this.labelDataUrodzenia.Location = new System.Drawing.Point(133, 113);
            this.labelDataUrodzenia.Name = "labelDataUrodzenia";
            this.labelDataUrodzenia.Size = new System.Drawing.Size(82, 13);
            this.labelDataUrodzenia.TabIndex = 2;
            this.labelDataUrodzenia.Text = "Data urodzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Płeć:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(226, 110);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 4;
            // 
            // textBoxPlec
            // 
            this.textBoxPlec.Location = new System.Drawing.Point(226, 145);
            this.textBoxPlec.Name = "textBoxPlec";
            this.textBoxPlec.ReadOnly = true;
            this.textBoxPlec.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlec.TabIndex = 5;
            // 
            // labelBlad
            // 
            this.labelBlad.AutoSize = true;
            this.labelBlad.ForeColor = System.Drawing.Color.Red;
            this.labelBlad.Location = new System.Drawing.Point(133, 187);
            this.labelBlad.Name = "labelBlad";
            this.labelBlad.Size = new System.Drawing.Size(0, 13);
            this.labelBlad.TabIndex = 6;
            this.labelBlad.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(240, 67);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(86, 20);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Zatwierdź";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSprawdz);
            this.tabControl1.Controls.Add(this.tabPageGeneruj);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 292);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageSprawdz
            // 
            this.tabPageSprawdz.Controls.Add(this.labelUdane);
            this.tabPageSprawdz.Controls.Add(this.textBoxPesel);
            this.tabPageSprawdz.Controls.Add(this.buttonSubmit);
            this.tabPageSprawdz.Controls.Add(this.PESEL);
            this.tabPageSprawdz.Controls.Add(this.labelBlad);
            this.tabPageSprawdz.Controls.Add(this.labelDataUrodzenia);
            this.tabPageSprawdz.Controls.Add(this.textBoxPlec);
            this.tabPageSprawdz.Controls.Add(this.label2);
            this.tabPageSprawdz.Controls.Add(this.textBoxData);
            this.tabPageSprawdz.Location = new System.Drawing.Point(4, 22);
            this.tabPageSprawdz.Name = "tabPageSprawdz";
            this.tabPageSprawdz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSprawdz.Size = new System.Drawing.Size(482, 266);
            this.tabPageSprawdz.TabIndex = 0;
            this.tabPageSprawdz.Text = "Sprawdź";
            this.tabPageSprawdz.UseVisualStyleBackColor = true;
            // 
            // tabPageGeneruj
            // 
            this.tabPageGeneruj.Controls.Add(this.labelUdaneGen);
            this.tabPageGeneruj.Controls.Add(this.labelBladDataGen);
            this.tabPageGeneruj.Controls.Add(this.labelBladPlecGen);
            this.tabPageGeneruj.Controls.Add(this.textBoxPeselGen);
            this.tabPageGeneruj.Controls.Add(this.labelPeselGen);
            this.tabPageGeneruj.Controls.Add(this.buttonSubmitGen);
            this.tabPageGeneruj.Controls.Add(this.textBoxPlecGen);
            this.tabPageGeneruj.Controls.Add(this.textBoxDataGen);
            this.tabPageGeneruj.Controls.Add(this.labelPlecGen);
            this.tabPageGeneruj.Controls.Add(this.labelDataUrGen);
            this.tabPageGeneruj.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneruj.Name = "tabPageGeneruj";
            this.tabPageGeneruj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneruj.Size = new System.Drawing.Size(482, 266);
            this.tabPageGeneruj.TabIndex = 1;
            this.tabPageGeneruj.Text = "Generuj";
            this.tabPageGeneruj.UseVisualStyleBackColor = true;
            // 
            // textBoxPeselGen
            // 
            this.textBoxPeselGen.Location = new System.Drawing.Point(212, 168);
            this.textBoxPeselGen.Name = "textBoxPeselGen";
            this.textBoxPeselGen.ReadOnly = true;
            this.textBoxPeselGen.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeselGen.TabIndex = 6;
            // 
            // labelPeselGen
            // 
            this.labelPeselGen.AutoSize = true;
            this.labelPeselGen.Location = new System.Drawing.Point(127, 168);
            this.labelPeselGen.Name = "labelPeselGen";
            this.labelPeselGen.Size = new System.Drawing.Size(44, 13);
            this.labelPeselGen.TabIndex = 5;
            this.labelPeselGen.Text = "PESEL:";
            // 
            // buttonSubmitGen
            // 
            this.buttonSubmitGen.Location = new System.Drawing.Point(212, 114);
            this.buttonSubmitGen.Name = "buttonSubmitGen";
            this.buttonSubmitGen.Size = new System.Drawing.Size(100, 23);
            this.buttonSubmitGen.TabIndex = 4;
            this.buttonSubmitGen.Text = "Zatwierdź";
            this.buttonSubmitGen.UseVisualStyleBackColor = true;
            this.buttonSubmitGen.Click += new System.EventHandler(this.buttonSubmitGen_Click);
            // 
            // textBoxPlecGen
            // 
            this.textBoxPlecGen.Location = new System.Drawing.Point(212, 87);
            this.textBoxPlecGen.Name = "textBoxPlecGen";
            this.textBoxPlecGen.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlecGen.TabIndex = 3;
            this.textBoxPlecGen.Enter += new System.EventHandler(this.textBoxPlecGen_Enter);
            this.textBoxPlecGen.Leave += new System.EventHandler(this.textBoxPlecGen_Leave);
            // 
            // textBoxDataGen
            // 
            this.textBoxDataGen.Location = new System.Drawing.Point(212, 55);
            this.textBoxDataGen.Name = "textBoxDataGen";
            this.textBoxDataGen.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataGen.TabIndex = 2;
            this.textBoxDataGen.Enter += new System.EventHandler(this.textBoxDataGen_Enter);
            this.textBoxDataGen.Leave += new System.EventHandler(this.textBoxDataGen_Leave);
            // 
            // labelPlecGen
            // 
            this.labelPlecGen.AutoSize = true;
            this.labelPlecGen.Location = new System.Drawing.Point(127, 87);
            this.labelPlecGen.Name = "labelPlecGen";
            this.labelPlecGen.Size = new System.Drawing.Size(33, 13);
            this.labelPlecGen.TabIndex = 1;
            this.labelPlecGen.Text = "Płeć:";
            // 
            // labelDataUrGen
            // 
            this.labelDataUrGen.AutoSize = true;
            this.labelDataUrGen.Location = new System.Drawing.Point(127, 58);
            this.labelDataUrGen.Name = "labelDataUrGen";
            this.labelDataUrGen.Size = new System.Drawing.Size(82, 13);
            this.labelDataUrGen.TabIndex = 0;
            this.labelDataUrGen.Text = "Data urodzenia:";
            // 
            // labelUdane
            // 
            this.labelUdane.AutoSize = true;
            this.labelUdane.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelUdane.Location = new System.Drawing.Point(133, 187);
            this.labelUdane.Name = "labelUdane";
            this.labelUdane.Size = new System.Drawing.Size(42, 13);
            this.labelUdane.TabIndex = 8;
            this.labelUdane.Text = "Udane!";
            this.labelUdane.Visible = false;
            // 
            // labelBladPlecGen
            // 
            this.labelBladPlecGen.AutoSize = true;
            this.labelBladPlecGen.ForeColor = System.Drawing.Color.Red;
            this.labelBladPlecGen.Location = new System.Drawing.Point(318, 87);
            this.labelBladPlecGen.Name = "labelBladPlecGen";
            this.labelBladPlecGen.Size = new System.Drawing.Size(98, 13);
            this.labelBladPlecGen.TabIndex = 7;
            this.labelBladPlecGen.Text = "Niepoprawna płeć!";
            this.labelBladPlecGen.Visible = false;
            // 
            // labelBladDataGen
            // 
            this.labelBladDataGen.AutoSize = true;
            this.labelBladDataGen.ForeColor = System.Drawing.Color.Red;
            this.labelBladDataGen.Location = new System.Drawing.Point(318, 58);
            this.labelBladDataGen.Name = "labelBladDataGen";
            this.labelBladDataGen.Size = new System.Drawing.Size(97, 13);
            this.labelBladDataGen.TabIndex = 8;
            this.labelBladDataGen.Text = "Niepoprawna data!";
            this.labelBladDataGen.Visible = false;
            // 
            // labelUdaneGen
            // 
            this.labelUdaneGen.AutoSize = true;
            this.labelUdaneGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelUdaneGen.Location = new System.Drawing.Point(321, 174);
            this.labelUdaneGen.Name = "labelUdaneGen";
            this.labelUdaneGen.Size = new System.Drawing.Size(42, 13);
            this.labelUdaneGen.TabIndex = 9;
            this.labelUdaneGen.Text = "Udane!";
            this.labelUdaneGen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 353);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSprawdz.ResumeLayout(false);
            this.tabPageSprawdz.PerformLayout();
            this.tabPageGeneruj.ResumeLayout(false);
            this.tabPageGeneruj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label PESEL;
        private System.Windows.Forms.Label labelDataUrodzenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxPlec;
        private System.Windows.Forms.Label labelBlad;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSprawdz;
        private System.Windows.Forms.TabPage tabPageGeneruj;
        private System.Windows.Forms.TextBox textBoxPlecGen;
        private System.Windows.Forms.TextBox textBoxDataGen;
        private System.Windows.Forms.Label labelPlecGen;
        private System.Windows.Forms.Label labelDataUrGen;
        private System.Windows.Forms.Button buttonSubmitGen;
        private System.Windows.Forms.Label labelPeselGen;
        private System.Windows.Forms.TextBox textBoxPeselGen;
        private System.Windows.Forms.Label labelUdane;
        private System.Windows.Forms.Label labelBladDataGen;
        private System.Windows.Forms.Label labelBladPlecGen;
        private System.Windows.Forms.Label labelUdaneGen;
    }
}

