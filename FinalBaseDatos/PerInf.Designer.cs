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
            this.NewPer = new System.Windows.Forms.Button();
            this.ModificarPerInf = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegInf
            // 
            this.RegInf.BackColor = System.Drawing.Color.Khaki;
            this.RegInf.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegInf.Location = new System.Drawing.Point(303, 91);
            this.RegInf.Name = "RegInf";
            this.RegInf.Size = new System.Drawing.Size(219, 83);
            this.RegInf.TabIndex = 0;
            this.RegInf.Text = "Nuevo Infante";
            this.RegInf.UseVisualStyleBackColor = false;
            this.RegInf.Click += new System.EventHandler(this.RegInf_Click);
            // 
            // NewPer
            // 
            this.NewPer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewPer.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPer.Location = new System.Drawing.Point(303, 243);
            this.NewPer.Name = "NewPer";
            this.NewPer.Size = new System.Drawing.Size(219, 85);
            this.NewPer.TabIndex = 1;
            this.NewPer.Text = "Nuevo Responsable";
            this.NewPer.UseVisualStyleBackColor = false;
            // 
            // ModificarPerInf
            // 
            this.ModificarPerInf.BackColor = System.Drawing.Color.LavenderBlush;
            this.ModificarPerInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificarPerInf.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarPerInf.Location = new System.Drawing.Point(598, 398);
            this.ModificarPerInf.Name = "ModificarPerInf";
            this.ModificarPerInf.Size = new System.Drawing.Size(95, 40);
            this.ModificarPerInf.TabIndex = 2;
            this.ModificarPerInf.Text = "Cambios";
            this.ModificarPerInf.UseVisualStyleBackColor = false;
            this.ModificarPerInf.Click += new System.EventHandler(this.ModificarPerInf_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(12, 407);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(88, 23);
            this.atras.TabIndex = 3;
            this.atras.Text = "Volver";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // PerInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalBaseDatos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.ModificarPerInf);
            this.Controls.Add(this.NewPer);
            this.Controls.Add(this.RegInf);
            this.Name = "PerInf";
            this.Text = "Admisiones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegInf;
        private System.Windows.Forms.Button NewPer;
        private System.Windows.Forms.Button ModificarPerInf;
        private System.Windows.Forms.Button atras;
    }
}