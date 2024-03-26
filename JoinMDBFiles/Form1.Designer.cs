namespace JoinMDBFiles {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOriginFile = new System.Windows.Forms.TextBox();
            this.txtTargetFile = new System.Windows.Forms.TextBox();
            this.btnJoinMDBs = new System.Windows.Forms.Button();
            this.btnOriginFile = new System.Windows.Forms.Button();
            this.btnTargetFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo de Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Archivo de Destino:";
            // 
            // txtOriginFile
            // 
            this.txtOriginFile.Location = new System.Drawing.Point(155, 25);
            this.txtOriginFile.Name = "txtOriginFile";
            this.txtOriginFile.Size = new System.Drawing.Size(262, 22);
            this.txtOriginFile.TabIndex = 2;
            // 
            // txtTargetFile
            // 
            this.txtTargetFile.Location = new System.Drawing.Point(155, 70);
            this.txtTargetFile.Name = "txtTargetFile";
            this.txtTargetFile.Size = new System.Drawing.Size(262, 22);
            this.txtTargetFile.TabIndex = 3;
            // 
            // btnJoinMDBs
            // 
            this.btnJoinMDBs.Location = new System.Drawing.Point(231, 110);
            this.btnJoinMDBs.Name = "btnJoinMDBs";
            this.btnJoinMDBs.Size = new System.Drawing.Size(109, 33);
            this.btnJoinMDBs.TabIndex = 4;
            this.btnJoinMDBs.Text = "Unir MDB\'s";
            this.btnJoinMDBs.UseVisualStyleBackColor = true;
            this.btnJoinMDBs.Click += new System.EventHandler(this.btnJoinMDBs_Click);
            // 
            // btnOriginFile
            // 
            this.btnOriginFile.Location = new System.Drawing.Point(423, 24);
            this.btnOriginFile.Name = "btnOriginFile";
            this.btnOriginFile.Size = new System.Drawing.Size(87, 24);
            this.btnOriginFile.TabIndex = 5;
            this.btnOriginFile.Text = "Examinar";
            this.btnOriginFile.UseVisualStyleBackColor = true;
            this.btnOriginFile.Click += new System.EventHandler(this.btnOriginFile_Click);
            // 
            // btnTargetFile
            // 
            this.btnTargetFile.Location = new System.Drawing.Point(423, 70);
            this.btnTargetFile.Name = "btnTargetFile";
            this.btnTargetFile.Size = new System.Drawing.Size(87, 23);
            this.btnTargetFile.TabIndex = 6;
            this.btnTargetFile.Text = "Examinar";
            this.btnTargetFile.UseVisualStyleBackColor = true;
            this.btnTargetFile.Click += new System.EventHandler(this.btnTargetFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(560, 165);
            this.Controls.Add(this.btnTargetFile);
            this.Controls.Add(this.btnOriginFile);
            this.Controls.Add(this.btnJoinMDBs);
            this.Controls.Add(this.txtTargetFile);
            this.Controls.Add(this.txtOriginFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Join MDB :.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginFile;
        private System.Windows.Forms.TextBox txtTargetFile;
        private System.Windows.Forms.Button btnJoinMDBs;
        private System.Windows.Forms.Button btnOriginFile;
        private System.Windows.Forms.Button btnTargetFile;
    }
}

