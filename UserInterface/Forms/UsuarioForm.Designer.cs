namespace UserInterface.Forms
{
    partial class UsuarioForm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tboxAlias = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxRepPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 171);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tboxAlias
            // 
            this.tboxAlias.Location = new System.Drawing.Point(114, 12);
            this.tboxAlias.Name = "tboxAlias";
            this.tboxAlias.Size = new System.Drawing.Size(100, 20);
            this.tboxAlias.TabIndex = 1;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(114, 39);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(100, 20);
            this.tboxPassword.TabIndex = 2;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(114, 92);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 3;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(114, 118);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(100, 20);
            this.tboxApellido.TabIndex = 4;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(114, 145);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(100, 20);
            this.tboxEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // tboxRepPassword
            // 
            this.tboxRepPassword.Location = new System.Drawing.Point(114, 66);
            this.tboxRepPassword.Name = "tboxRepPassword";
            this.tboxRepPassword.Size = new System.Drawing.Size(100, 20);
            this.tboxRepPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repetir Contraseña";
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 234);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxRepPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxAlias);
            this.Controls.Add(this.btnGuardar);
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tboxAlias;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxRepPassword;
        private System.Windows.Forms.Label label6;
    }
}