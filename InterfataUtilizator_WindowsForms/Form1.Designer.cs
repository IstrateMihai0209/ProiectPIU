using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    partial class FormularAplicatie
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblAdaugareTranzactieInfo = new System.Windows.Forms.Label();
            this.lblDataTranzactieNoua = new System.Windows.Forms.Label();
            this.lblSumaTranzactieNoua = new System.Windows.Forms.Label();
            this.lblTipTranzactieNoua = new System.Windows.Forms.Label();
            this.lblCategorieTranzactieNoua = new System.Windows.Forms.Label();
            this.lblDescriereTranzactieNoua = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.categoriiTranzactii = new System.Windows.Forms.ComboBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.btnAdaugareTranzactie = new System.Windows.Forms.Button();
            this.tipVenit = new System.Windows.Forms.RadioButton();
            this.tipCheltuiala = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cautareTxtBox = new System.Windows.Forms.TextBox();
            this.butonCautare = new System.Windows.Forms.Button();
            this.butonNext = new System.Windows.Forms.Button();
            this.butonInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(415, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAdaugareTranzactieInfo
            // 
            this.lblAdaugareTranzactieInfo.AutoSize = true;
            this.lblAdaugareTranzactieInfo.Location = new System.Drawing.Point(127, 9);
            this.lblAdaugareTranzactieInfo.Name = "lblAdaugareTranzactieInfo";
            this.lblAdaugareTranzactieInfo.Size = new System.Drawing.Size(106, 13);
            this.lblAdaugareTranzactieInfo.TabIndex = 1;
            this.lblAdaugareTranzactieInfo.Text = "Adaugare Tranzactie";
            this.lblAdaugareTranzactieInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataTranzactieNoua
            // 
            this.lblDataTranzactieNoua.AutoSize = true;
            this.lblDataTranzactieNoua.Location = new System.Drawing.Point(34, 30);
            this.lblDataTranzactieNoua.Name = "lblDataTranzactieNoua";
            this.lblDataTranzactieNoua.Size = new System.Drawing.Size(30, 13);
            this.lblDataTranzactieNoua.TabIndex = 2;
            this.lblDataTranzactieNoua.Text = "Data";
            // 
            // lblSumaTranzactieNoua
            // 
            this.lblSumaTranzactieNoua.AutoSize = true;
            this.lblSumaTranzactieNoua.Location = new System.Drawing.Point(34, 55);
            this.lblSumaTranzactieNoua.Name = "lblSumaTranzactieNoua";
            this.lblSumaTranzactieNoua.Size = new System.Drawing.Size(34, 13);
            this.lblSumaTranzactieNoua.TabIndex = 3;
            this.lblSumaTranzactieNoua.Text = "Suma";
            // 
            // lblTipTranzactieNoua
            // 
            this.lblTipTranzactieNoua.AutoSize = true;
            this.lblTipTranzactieNoua.Location = new System.Drawing.Point(38, 80);
            this.lblTipTranzactieNoua.Name = "lblTipTranzactieNoua";
            this.lblTipTranzactieNoua.Size = new System.Drawing.Size(22, 13);
            this.lblTipTranzactieNoua.TabIndex = 4;
            this.lblTipTranzactieNoua.Text = "Tip";
            // 
            // lblCategorieTranzactieNoua
            // 
            this.lblCategorieTranzactieNoua.AutoSize = true;
            this.lblCategorieTranzactieNoua.Location = new System.Drawing.Point(29, 105);
            this.lblCategorieTranzactieNoua.Name = "lblCategorieTranzactieNoua";
            this.lblCategorieTranzactieNoua.Size = new System.Drawing.Size(52, 13);
            this.lblCategorieTranzactieNoua.TabIndex = 5;
            this.lblCategorieTranzactieNoua.Text = "Categorie";
            // 
            // lblDescriereTranzactieNoua
            // 
            this.lblDescriereTranzactieNoua.AutoSize = true;
            this.lblDescriereTranzactieNoua.Location = new System.Drawing.Point(29, 130);
            this.lblDescriereTranzactieNoua.Name = "lblDescriereTranzactieNoua";
            this.lblDescriereTranzactieNoua.Size = new System.Drawing.Size(52, 13);
            this.lblDescriereTranzactieNoua.TabIndex = 6;
            this.lblDescriereTranzactieNoua.Text = "Descriere";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(87, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(87, 55);
            this.txtSuma.MaxLength = 15;
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(200, 20);
            this.txtSuma.TabIndex = 8;
            this.txtSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // categoriiTranzactii
            // 
            this.categoriiTranzactii.FormattingEnabled = true;
            this.categoriiTranzactii.Location = new System.Drawing.Point(87, 105);
            this.categoriiTranzactii.Name = "categoriiTranzactii";
            this.categoriiTranzactii.Size = new System.Drawing.Size(200, 21);
            this.categoriiTranzactii.TabIndex = 10;
            this.categoriiTranzactii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoriiTranzactii_KeyPress);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(87, 130);
            this.txtDescriere.MaxLength = 20;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(200, 20);
            this.txtDescriere.TabIndex = 11;
            // 
            // btnAdaugareTranzactie
            // 
            this.btnAdaugareTranzactie.Location = new System.Drawing.Point(139, 156);
            this.btnAdaugareTranzactie.Name = "btnAdaugareTranzactie";
            this.btnAdaugareTranzactie.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugareTranzactie.TabIndex = 12;
            this.btnAdaugareTranzactie.Text = "Adauga";
            this.btnAdaugareTranzactie.UseVisualStyleBackColor = true;
            this.btnAdaugareTranzactie.Click += new System.EventHandler(this.btnAdaugareTranzactie_Click);
            // 
            // tipVenit
            // 
            this.tipVenit.AutoSize = true;
            this.tipVenit.Location = new System.Drawing.Point(87, 81);
            this.tipVenit.Name = "tipVenit";
            this.tipVenit.Size = new System.Drawing.Size(49, 17);
            this.tipVenit.TabIndex = 14;
            this.tipVenit.TabStop = true;
            this.tipVenit.Text = "Venit";
            this.tipVenit.UseVisualStyleBackColor = true;
            this.tipVenit.CheckedChanged += new System.EventHandler(this.tipVenit_CheckedChanged);
            // 
            // tipCheltuiala
            // 
            this.tipCheltuiala.AutoSize = true;
            this.tipCheltuiala.Location = new System.Drawing.Point(200, 82);
            this.tipCheltuiala.Name = "tipCheltuiala";
            this.tipCheltuiala.Size = new System.Drawing.Size(71, 17);
            this.tipCheltuiala.TabIndex = 15;
            this.tipCheltuiala.TabStop = true;
            this.tipCheltuiala.Text = "Cheltuiala";
            this.tipCheltuiala.UseVisualStyleBackColor = true;
            this.tipCheltuiala.CheckedChanged += new System.EventHandler(this.tipCheltuiala_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cautare tranzactie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descriere";
            // 
            // cautareTxtBox
            // 
            this.cautareTxtBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cautareTxtBox.Location = new System.Drawing.Point(120, 261);
            this.cautareTxtBox.MaxLength = 20;
            this.cautareTxtBox.Name = "cautareTxtBox";
            this.cautareTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cautareTxtBox.TabIndex = 18;
            // 
            // butonCautare
            // 
            this.butonCautare.Location = new System.Drawing.Point(130, 287);
            this.butonCautare.Name = "butonCautare";
            this.butonCautare.Size = new System.Drawing.Size(75, 23);
            this.butonCautare.TabIndex = 19;
            this.butonCautare.Text = "Cauta";
            this.butonCautare.UseVisualStyleBackColor = true;
            this.butonCautare.Click += new System.EventHandler(this.butonCautare_Click);
            // 
            // butonNext
            // 
            this.butonNext.Location = new System.Drawing.Point(509, 261);
            this.butonNext.Name = "butonNext";
            this.butonNext.Size = new System.Drawing.Size(75, 23);
            this.butonNext.TabIndex = 20;
            this.butonNext.Text = "Next";
            this.butonNext.UseVisualStyleBackColor = true;
            this.butonNext.Click += new System.EventHandler(this.butonNext_Click);
            // 
            // butonInapoi
            // 
            this.butonInapoi.Location = new System.Drawing.Point(605, 261);
            this.butonInapoi.Name = "butonInapoi";
            this.butonInapoi.Size = new System.Drawing.Size(75, 23);
            this.butonInapoi.TabIndex = 21;
            this.butonInapoi.Text = "Back";
            this.butonInapoi.UseVisualStyleBackColor = true;
            this.butonInapoi.Click += new System.EventHandler(this.butonInapoi_Click);
            // 
            // FormularAplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butonInapoi);
            this.Controls.Add(this.butonNext);
            this.Controls.Add(this.butonCautare);
            this.Controls.Add(this.cautareTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipCheltuiala);
            this.Controls.Add(this.tipVenit);
            this.Controls.Add(this.btnAdaugareTranzactie);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.categoriiTranzactii);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDescriereTranzactieNoua);
            this.Controls.Add(this.lblCategorieTranzactieNoua);
            this.Controls.Add(this.lblTipTranzactieNoua);
            this.Controls.Add(this.lblSumaTranzactieNoua);
            this.Controls.Add(this.lblDataTranzactieNoua);
            this.Controls.Add(this.lblAdaugareTranzactieInfo);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormularAplicatie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAdaugareTranzactieInfo;
        private System.Windows.Forms.Label lblDataTranzactieNoua;
        private System.Windows.Forms.Label lblSumaTranzactieNoua;
        private System.Windows.Forms.Label lblTipTranzactieNoua;
        private System.Windows.Forms.Label lblCategorieTranzactieNoua;
        private System.Windows.Forms.Label lblDescriereTranzactieNoua;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.ComboBox categoriiTranzactii;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Button btnAdaugareTranzactie;
        private RadioButton tipVenit;
        private RadioButton tipCheltuiala;
        private Label label1;
        private Label label2;
        private TextBox cautareTxtBox;
        private Button butonCautare;
        private Button butonNext;
        private Button butonInapoi;
    }
}

