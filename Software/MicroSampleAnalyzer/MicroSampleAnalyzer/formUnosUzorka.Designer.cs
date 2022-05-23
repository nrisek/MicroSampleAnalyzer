namespace MicroSampleAnalyzer
{
    partial class formUnosUzorka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUnosUzorka));
            this.tbZaprimio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesiIGenerirajQR = new System.Windows.Forms.Button();
            this.cmbPacijenti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPacijent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbZaprimio
            // 
            this.tbZaprimio.Enabled = false;
            this.tbZaprimio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZaprimio.Location = new System.Drawing.Point(31, 58);
            this.tbZaprimio.Name = "tbZaprimio";
            this.tbZaprimio.Size = new System.Drawing.Size(499, 30);
            this.tbZaprimio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zaprimio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "OIB Pacijenta:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(31, 210);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(499, 142);
            this.tbOpis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opis:";
            // 
            // btnUnesiIGenerirajQR
            // 
            this.btnUnesiIGenerirajQR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUnesiIGenerirajQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiIGenerirajQR.Location = new System.Drawing.Point(202, 373);
            this.btnUnesiIGenerirajQR.Name = "btnUnesiIGenerirajQR";
            this.btnUnesiIGenerirajQR.Size = new System.Drawing.Size(171, 97);
            this.btnUnesiIGenerirajQR.TabIndex = 11;
            this.btnUnesiIGenerirajQR.Text = "Unesi i generiraj QR kod";
            this.btnUnesiIGenerirajQR.UseVisualStyleBackColor = false;
            this.btnUnesiIGenerirajQR.Click += new System.EventHandler(this.btnUnesiIGenerirajQR_Click);
            // 
            // cmbPacijenti
            // 
            this.cmbPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacijenti.FormattingEnabled = true;
            this.cmbPacijenti.Location = new System.Drawing.Point(32, 138);
            this.cmbPacijenti.Name = "cmbPacijenti";
            this.cmbPacijenti.Size = new System.Drawing.Size(239, 33);
            this.cmbPacijenti.TabIndex = 12;
            this.cmbPacijenti.SelectedIndexChanged += new System.EventHandler(this.cmbPacijenti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pacijent:";
            // 
            // tbPacijent
            // 
            this.tbPacijent.Enabled = false;
            this.tbPacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPacijent.Location = new System.Drawing.Point(287, 138);
            this.tbPacijent.Name = "tbPacijent";
            this.tbPacijent.Size = new System.Drawing.Size(243, 30);
            this.tbPacijent.TabIndex = 14;
            // 
            // formUnosUzorka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(557, 490);
            this.Controls.Add(this.tbPacijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPacijenti);
            this.Controls.Add(this.btnUnesiIGenerirajQR);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbZaprimio);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formUnosUzorka";
            this.Text = "Unos uzorka";
            this.Load += new System.EventHandler(this.formUnosUzorka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbZaprimio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesiIGenerirajQR;
        private System.Windows.Forms.ComboBox cmbPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPacijent;
    }
}