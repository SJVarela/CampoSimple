namespace UserInterface
{
    partial class ReservasForm
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
            form = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Schedualer = new Braincase.GanttChart.Chart();
            this.SuspendLayout();
            // 
            // Schedualer
            // 
            this.Schedualer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schedualer.Location = new System.Drawing.Point(0, 0);
            this.Schedualer.Margin = new System.Windows.Forms.Padding(0);
            this.Schedualer.Name = "Schedualer";
            this.Schedualer.Size = new System.Drawing.Size(800, 450);
            this.Schedualer.TabIndex = 0;
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Schedualer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasForm";
            this.Text = "ReservasForm";
            this.Load += new System.EventHandler(this.ReservasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Braincase.GanttChart.Chart Schedualer;
    }
}