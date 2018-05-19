namespace UserInterface.Forms
{
    partial class PermisosForm
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
            this.lstPermisos = new System.Windows.Forms.ListBox();
            this.lstFamilias = new System.Windows.Forms.ListBox();
            this.lstPatentes = new System.Windows.Forms.ListBox();
            this.btnAsignarPat = new System.Windows.Forms.Button();
            this.btnRemoverPat = new System.Windows.Forms.Button();
            this.btnAsignarFamilia = new System.Windows.Forms.Button();
            this.btnRemoverFamilia = new System.Windows.Forms.Button();
            this.btnAdmFamilias = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnNegarPat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPermisos
            // 
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(6, 12);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(205, 446);
            this.lstPermisos.TabIndex = 0;
            // 
            // lstFamilias
            // 
            this.lstFamilias.FormattingEnabled = true;
            this.lstFamilias.Location = new System.Drawing.Point(87, 11);
            this.lstFamilias.Name = "lstFamilias";
            this.lstFamilias.Size = new System.Drawing.Size(186, 212);
            this.lstFamilias.TabIndex = 1;
            // 
            // lstPatentes
            // 
            this.lstPatentes.FormattingEnabled = true;
            this.lstPatentes.Location = new System.Drawing.Point(87, 19);
            this.lstPatentes.Name = "lstPatentes";
            this.lstPatentes.Size = new System.Drawing.Size(186, 212);
            this.lstPatentes.TabIndex = 2;
            // 
            // btnAsignarPat
            // 
            this.btnAsignarPat.Location = new System.Drawing.Point(6, 19);
            this.btnAsignarPat.Name = "btnAsignarPat";
            this.btnAsignarPat.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarPat.TabIndex = 3;
            this.btnAsignarPat.Text = "Asignar";
            this.btnAsignarPat.UseVisualStyleBackColor = true;
            // 
            // btnRemoverPat
            // 
            this.btnRemoverPat.Location = new System.Drawing.Point(6, 48);
            this.btnRemoverPat.Name = "btnRemoverPat";
            this.btnRemoverPat.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverPat.TabIndex = 4;
            this.btnRemoverPat.Text = "Remover";
            this.btnRemoverPat.UseVisualStyleBackColor = true;
            // 
            // btnAsignarFamilia
            // 
            this.btnAsignarFamilia.Location = new System.Drawing.Point(6, 19);
            this.btnAsignarFamilia.Name = "btnAsignarFamilia";
            this.btnAsignarFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarFamilia.TabIndex = 5;
            this.btnAsignarFamilia.Text = "Asignar";
            this.btnAsignarFamilia.UseVisualStyleBackColor = true;
            // 
            // btnRemoverFamilia
            // 
            this.btnRemoverFamilia.Location = new System.Drawing.Point(5, 50);
            this.btnRemoverFamilia.Name = "btnRemoverFamilia";
            this.btnRemoverFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFamilia.TabIndex = 6;
            this.btnRemoverFamilia.Text = "Remover";
            this.btnRemoverFamilia.UseVisualStyleBackColor = true;
            // 
            // btnAdmFamilias
            // 
            this.btnAdmFamilias.Location = new System.Drawing.Point(279, 19);
            this.btnAdmFamilias.Name = "btnAdmFamilias";
            this.btnAdmFamilias.Size = new System.Drawing.Size(75, 23);
            this.btnAdmFamilias.TabIndex = 7;
            this.btnAdmFamilias.Text = "Administrar";
            this.btnAdmFamilias.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverFamilia);
            this.groupBox1.Controls.Add(this.btnAdmFamilias);
            this.groupBox1.Controls.Add(this.btnAsignarFamilia);
            this.groupBox1.Controls.Add(this.lstFamilias);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familias";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNegarPat);
            this.groupBox2.Controls.Add(this.btnRemoverPat);
            this.groupBox2.Controls.Add(this.btnAsignarPat);
            this.groupBox2.Controls.Add(this.lstPatentes);
            this.groupBox2.Location = new System.Drawing.Point(247, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patentes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstPermisos);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 462);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos";
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.Location = new System.Drawing.Point(18, 12);
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.ReadOnly = true;
            this.tboxNombreUsuario.Size = new System.Drawing.Size(211, 20);
            this.tboxNombreUsuario.TabIndex = 11;
            // 
            // btnNegarPat
            // 
            this.btnNegarPat.Location = new System.Drawing.Point(6, 77);
            this.btnNegarPat.Name = "btnNegarPat";
            this.btnNegarPat.Size = new System.Drawing.Size(75, 23);
            this.btnNegarPat.TabIndex = 5;
            this.btnNegarPat.Text = "Negar";
            this.btnNegarPat.UseVisualStyleBackColor = true;
            // 
            // PermisosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 512);
            this.Controls.Add(this.tboxNombreUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PermisosForm";
            this.Text = "PermisosForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPermisos;
        private System.Windows.Forms.ListBox lstFamilias;
        private System.Windows.Forms.ListBox lstPatentes;
        private System.Windows.Forms.Button btnAsignarPat;
        private System.Windows.Forms.Button btnRemoverPat;
        private System.Windows.Forms.Button btnAsignarFamilia;
        private System.Windows.Forms.Button btnRemoverFamilia;
        private System.Windows.Forms.Button btnAdmFamilias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNegarPat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboxNombreUsuario;
    }
}