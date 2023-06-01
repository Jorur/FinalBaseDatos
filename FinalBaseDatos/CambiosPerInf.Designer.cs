namespace FinalBaseDatos
{
    partial class CambiosPerInf
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
            this.AltaInf = new System.Windows.Forms.Button();
            this.CambiarTel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AltaInf
            // 
            this.AltaInf.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AltaInf.AutoSize = true;
            this.AltaInf.BackColor = System.Drawing.Color.SlateBlue;
            this.AltaInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AltaInf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaInf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AltaInf.Location = new System.Drawing.Point(178, 197);
            this.AltaInf.Name = "AltaInf";
            this.AltaInf.Size = new System.Drawing.Size(144, 54);
            this.AltaInf.TabIndex = 0;
            this.AltaInf.Text = "Infante";
            this.AltaInf.UseVisualStyleBackColor = false;
            // 
            // CambiarTel
            // 
            this.CambiarTel.BackColor = System.Drawing.Color.SlateBlue;
            this.CambiarTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CambiarTel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CambiarTel.Location = new System.Drawing.Point(460, 197);
            this.CambiarTel.Name = "CambiarTel";
            this.CambiarTel.Size = new System.Drawing.Size(144, 54);
            this.CambiarTel.TabIndex = 1;
            this.CambiarTel.Text = "Persona";
            this.CambiarTel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(178, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dar de baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(460, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cambiar numero de celular";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Location = new System.Drawing.Point(21, 404);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 25);
            this.back.TabIndex = 4;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = false;
            // 
            // CambiosPerInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CambiarTel);
            this.Controls.Add(this.AltaInf);
            this.Name = "CambiosPerInf";
            this.Text = "CambiosPerInf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AltaInf;
        private System.Windows.Forms.Button CambiarTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
    }
}