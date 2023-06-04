namespace FinalBaseDatos
{
    partial class EncargadoEx
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ci = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Label();
            this.Parentesco = new System.Windows.Forms.TextBox();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet de Identidad";
            // 
            // Ci
            // 
            this.Ci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(225)))));
            this.Ci.Location = new System.Drawing.Point(257, 142);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(246, 22);
            this.Ci.TabIndex = 1;
            this.Ci.TextChanged += new System.EventHandler(this.Ci_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Aceptar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(312, 303);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(140, 71);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Relacion
            // 
            this.Relacion.AutoSize = true;
            this.Relacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relacion.Location = new System.Drawing.Point(253, 212);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(199, 20);
            this.Relacion.TabIndex = 3;
            this.Relacion.Text = "Parentezco con el infante";
            // 
            // Parentesco
            // 
            this.Parentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(225)))));
            this.Parentesco.Location = new System.Drawing.Point(257, 235);
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.Size = new System.Drawing.Size(246, 22);
            this.Parentesco.TabIndex = 4;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(12, 415);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(108, 23);
            this.volver.TabIndex = 5;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // EncargadoEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.Parentesco);
            this.Controls.Add(this.Relacion);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.label1);
            this.Name = "EncargadoEx";
            this.Text = "Datos del Encargado";
            this.Load += new System.EventHandler(this.EncargadoEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label Relacion;
        private System.Windows.Forms.TextBox Parentesco;
        private System.Windows.Forms.Button volver;
    }
}