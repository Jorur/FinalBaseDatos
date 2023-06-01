namespace FinalBaseDatos
{
    partial class CambiosPi
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
            this.CamInf = new System.Windows.Forms.Button();
            this.CamPer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volver1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CamInf
            // 
            this.CamInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CamInf.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamInf.Location = new System.Drawing.Point(175, 174);
            this.CamInf.Name = "CamInf";
            this.CamInf.Size = new System.Drawing.Size(163, 88);
            this.CamInf.TabIndex = 0;
            this.CamInf.Text = "Infante";
            this.CamInf.UseVisualStyleBackColor = false;
            this.CamInf.Click += new System.EventHandler(this.CamInf_Click);
            // 
            // CamPer
            // 
            this.CamPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CamPer.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamPer.Location = new System.Drawing.Point(455, 174);
            this.CamPer.Name = "CamPer";
            this.CamPer.Size = new System.Drawing.Size(173, 88);
            this.CamPer.TabIndex = 1;
            this.CamPer.Text = "Persona";
            this.CamPer.UseVisualStyleBackColor = false;
            this.CamPer.Click += new System.EventHandler(this.CamPer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(181, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dar de baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(463, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cambiar su telefono";
            // 
            // volver1
            // 
            this.volver1.BackColor = System.Drawing.Color.LightGray;
            this.volver1.Location = new System.Drawing.Point(25, 404);
            this.volver1.Name = "volver1";
            this.volver1.Size = new System.Drawing.Size(95, 23);
            this.volver1.TabIndex = 4;
            this.volver1.Text = "Volver";
            this.volver1.UseVisualStyleBackColor = false;
            this.volver1.Click += new System.EventHandler(this.volver1_Click);
            // 
            // CambiosPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CamPer);
            this.Controls.Add(this.CamInf);
            this.Name = "CambiosPi";
            this.Text = "CambiosPi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CamInf;
        private System.Windows.Forms.Button CamPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button volver1;
    }
}