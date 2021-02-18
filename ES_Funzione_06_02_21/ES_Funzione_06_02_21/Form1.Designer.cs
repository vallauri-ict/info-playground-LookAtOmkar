namespace ES_Funzione_06_02_21
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnFunzione1 = new System.Windows.Forms.Button();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblFunzioni = new System.Windows.Forms.Label();
            this.btnFunzione2 = new System.Windows.Forms.Button();
            this.btnFunzione3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(16, 150);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(776, 224);
            this.dgvDriver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ES FUNZIONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA:   06-02-2021";
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(35, 80);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(75, 23);
            this.btnDB.TabIndex = 3;
            this.btnDB.Text = "DRIVER";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnFunzione1
            // 
            this.btnFunzione1.Location = new System.Drawing.Point(473, 80);
            this.btnFunzione1.Name = "btnFunzione1";
            this.btnFunzione1.Size = new System.Drawing.Size(75, 23);
            this.btnFunzione1.TabIndex = 4;
            this.btnFunzione1.Text = "1";
            this.btnFunzione1.UseVisualStyleBackColor = true;
            this.btnFunzione1.Click += new System.EventHandler(this.btnFunzione1_Click);
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(32, 51);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(67, 13);
            this.lblDB.TabIndex = 5;
            this.lblDB.Text = "DATABASE:";
            // 
            // lblFunzioni
            // 
            this.lblFunzioni.AutoSize = true;
            this.lblFunzioni.Location = new System.Drawing.Point(470, 51);
            this.lblFunzioni.Name = "lblFunzioni";
            this.lblFunzioni.Size = new System.Drawing.Size(58, 13);
            this.lblFunzioni.TabIndex = 6;
            this.lblFunzioni.Text = "FUNZIONI";
            // 
            // btnFunzione2
            // 
            this.btnFunzione2.Location = new System.Drawing.Point(631, 80);
            this.btnFunzione2.Name = "btnFunzione2";
            this.btnFunzione2.Size = new System.Drawing.Size(75, 23);
            this.btnFunzione2.TabIndex = 7;
            this.btnFunzione2.Text = "2";
            this.btnFunzione2.UseVisualStyleBackColor = true;
            this.btnFunzione2.Click += new System.EventHandler(this.btnFunzione2_Click);
            // 
            // btnFunzione3
            // 
            this.btnFunzione3.Location = new System.Drawing.Point(554, 111);
            this.btnFunzione3.Name = "btnFunzione3";
            this.btnFunzione3.Size = new System.Drawing.Size(75, 23);
            this.btnFunzione3.TabIndex = 8;
            this.btnFunzione3.Text = "3";
            this.btnFunzione3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnFunzione3);
            this.Controls.Add(this.btnFunzione2);
            this.Controls.Add(this.lblFunzioni);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.btnFunzione1);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnFunzione1;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblFunzioni;
        private System.Windows.Forms.Button btnFunzione2;
        private System.Windows.Forms.Button btnFunzione3;
    }
}

