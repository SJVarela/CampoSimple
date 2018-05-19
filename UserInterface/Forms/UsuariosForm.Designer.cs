namespace UserInterface.Forms
{
    partial class UsuariosForm
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
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnAltaUsr = new System.Windows.Forms.Button();
            this.btnModificarUsr = new System.Windows.Forms.Button();
            this.btnBajaUsr = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(13, 13);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(219, 277);
            this.lstUsuarios.TabIndex = 0;
            // 
            // btnAltaUsr
            // 
            this.btnAltaUsr.Location = new System.Drawing.Point(239, 13);
            this.btnAltaUsr.Name = "btnAltaUsr";
            this.btnAltaUsr.Size = new System.Drawing.Size(75, 23);
            this.btnAltaUsr.TabIndex = 1;
            this.btnAltaUsr.Text = "Alta";
            this.btnAltaUsr.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsr
            // 
            this.btnModificarUsr.Location = new System.Drawing.Point(239, 43);
            this.btnModificarUsr.Name = "btnModificarUsr";
            this.btnModificarUsr.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUsr.TabIndex = 2;
            this.btnModificarUsr.Text = "Modificar";
            this.btnModificarUsr.UseVisualStyleBackColor = true;
            // 
            // btnBajaUsr
            // 
            this.btnBajaUsr.Location = new System.Drawing.Point(239, 73);
            this.btnBajaUsr.Name = "btnBajaUsr";
            this.btnBajaUsr.Size = new System.Drawing.Size(75, 23);
            this.btnBajaUsr.TabIndex = 3;
            this.btnBajaUsr.Text = "Baja";
            this.btnBajaUsr.UseVisualStyleBackColor = true;
            // 
            // btnPermisos
            // 
            this.btnPermisos.Location = new System.Drawing.Point(239, 127);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(75, 23);
            this.btnPermisos.TabIndex = 4;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 309);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnBajaUsr);
            this.Controls.Add(this.btnModificarUsr);
            this.Controls.Add(this.btnAltaUsr);
            this.Controls.Add(this.lstUsuarios);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnAltaUsr;
        private System.Windows.Forms.Button btnModificarUsr;
        private System.Windows.Forms.Button btnBajaUsr;
        private System.Windows.Forms.Button btnPermisos;
    }
}