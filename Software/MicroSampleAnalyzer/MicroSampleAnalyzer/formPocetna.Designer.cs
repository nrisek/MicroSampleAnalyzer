namespace MicroSampleAnalyzer
{
    partial class formPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPocetna));
            this.btnUzorci = new System.Windows.Forms.Button();
            this.btnNoviUzorak = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUnosPacijenta = new System.Windows.Forms.Button();
            this.btnPregledPacijenata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUzorci
            // 
            this.btnUzorci.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUzorci.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUzorci.Location = new System.Drawing.Point(50, 34);
            this.btnUzorci.Name = "btnUzorci";
            this.btnUzorci.Size = new System.Drawing.Size(216, 55);
            this.btnUzorci.TabIndex = 0;
            this.btnUzorci.Text = "Uzorci";
            this.btnUzorci.UseVisualStyleBackColor = false;
            this.btnUzorci.Click += new System.EventHandler(this.btnUzorci_Click);
            // 
            // btnNoviUzorak
            // 
            this.btnNoviUzorak.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNoviUzorak.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviUzorak.Location = new System.Drawing.Point(262, 34);
            this.btnNoviUzorak.Name = "btnNoviUzorak";
            this.btnNoviUzorak.Size = new System.Drawing.Size(79, 55);
            this.btnNoviUzorak.TabIndex = 1;
            this.btnNoviUzorak.Text = "+";
            this.btnNoviUzorak.UseVisualStyleBackColor = false;
            this.btnNoviUzorak.Click += new System.EventHandler(this.btnNoviUzorak_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(392, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Radni nalozi";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnUnosPacijenta
            // 
            this.btnUnosPacijenta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUnosPacijenta.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosPacijenta.Location = new System.Drawing.Point(949, 34);
            this.btnUnosPacijenta.Name = "btnUnosPacijenta";
            this.btnUnosPacijenta.Size = new System.Drawing.Size(79, 55);
            this.btnUnosPacijenta.TabIndex = 5;
            this.btnUnosPacijenta.Text = "+";
            this.btnUnosPacijenta.UseVisualStyleBackColor = false;
            this.btnUnosPacijenta.Click += new System.EventHandler(this.btnUnosPacijenta_Click);
            // 
            // btnPregledPacijenata
            // 
            this.btnPregledPacijenata.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPregledPacijenata.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledPacijenata.Location = new System.Drawing.Point(737, 34);
            this.btnPregledPacijenata.Name = "btnPregledPacijenata";
            this.btnPregledPacijenata.Size = new System.Drawing.Size(216, 55);
            this.btnPregledPacijenata.TabIndex = 4;
            this.btnPregledPacijenata.Text = "Pacijenti";
            this.btnPregledPacijenata.UseVisualStyleBackColor = false;
            this.btnPregledPacijenata.Click += new System.EventHandler(this.btnPregledPacijenata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 381);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aktivni radni nalozi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1078, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUnosPacijenta);
            this.Controls.Add(this.btnPregledPacijenata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNoviUzorak);
            this.Controls.Add(this.btnUzorci);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formPocetna";
            this.Text = "MicroSampleAnalyzer";
            this.Load += new System.EventHandler(this.formPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUzorci;
        private System.Windows.Forms.Button btnNoviUzorak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUnosPacijenta;
        private System.Windows.Forms.Button btnPregledPacijenata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

