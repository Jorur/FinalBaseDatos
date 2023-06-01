namespace FinalBaseDatos
{
    partial class PerInf
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
            this.RegInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegInf
            // 
            this.RegInf.Location = new System.Drawing.Point(32, 38);
            this.RegInf.Name = "RegInf";
            this.RegInf.Size = new System.Drawing.Size(75, 23);
            this.RegInf.TabIndex = 0;
            this.RegInf.Text = "Registrar Infante";
            this.RegInf.UseVisualStyleBackColor = true;
            this.RegInf.Click += new System.EventHandler(this.RegInf_Click);
            // 
            // PerInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegInf);
            this.Name = "PerInf";
            this.Text = "Admisiones";
            this.Load += new System.EventHandler(this.PerInf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegInf;
    }
}