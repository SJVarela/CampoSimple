namespace UserInterface.Forms
{
    partial class BackupForm
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
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAgregarDest = new System.Windows.Forms.Button();
            this.lstDestinos = new System.Windows.Forms.ListBox();
            this.btnQuitarDest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearBackup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(62, 6);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(120, 20);
            this.tboxNombre.TabIndex = 0;
            // 
            // btnAgregarDest
            // 
            this.btnAgregarDest.Location = new System.Drawing.Point(132, 19);
            this.btnAgregarDest.Name = "btnAgregarDest";
            this.btnAgregarDest.Size = new System.Drawing.Size(75, 46);
            this.btnAgregarDest.TabIndex = 1;
            this.btnAgregarDest.Text = "Agregar Destino";
            this.btnAgregarDest.UseVisualStyleBackColor = true;
            // 
            // lstDestinos
            // 
            this.lstDestinos.FormattingEnabled = true;
            this.lstDestinos.Location = new System.Drawing.Point(6, 19);
            this.lstDestinos.Name = "lstDestinos";
            this.lstDestinos.Size = new System.Drawing.Size(120, 199);
            this.lstDestinos.TabIndex = 2;
            // 
            // btnQuitarDest
            // 
            this.btnQuitarDest.Location = new System.Drawing.Point(132, 71);
            this.btnQuitarDest.Name = "btnQuitarDest";
            this.btnQuitarDest.Size = new System.Drawing.Size(75, 46);
            this.btnQuitarDest.TabIndex = 3;
            this.btnQuitarDest.Text = "Quitar Destino";
            this.btnQuitarDest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarDest);
            this.groupBox1.Controls.Add(this.lstDestinos);
            this.groupBox1.Controls.Add(this.btnAgregarDest);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // btnCrearBackup
            // 
            this.btnCrearBackup.Location = new System.Drawing.Point(86, 276);
            this.btnCrearBackup.Name = "btnCrearBackup";
            this.btnCrearBackup.Size = new System.Drawing.Size(75, 42);
            this.btnCrearBackup.TabIndex = 6;
            this.btnCrearBackup.Text = "Crear Backup";
            this.btnCrearBackup.UseVisualStyleBackColor = true;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 335);
            this.Controls.Add(this.btnCrearBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxNombre);
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAgregarDest;
        private System.Windows.Forms.ListBox lstDestinos;
        private System.Windows.Forms.Button btnQuitarDest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearBackup;
    }
}