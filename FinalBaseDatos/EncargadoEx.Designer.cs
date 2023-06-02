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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet de Identidad";
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(235, 121);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(246, 22);
            this.Ci.TabIndex = 1;
            this.Ci.TextChanged += new System.EventHandler(this.Ci_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(643, 399);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(107, 23);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Relacion
            // 
            this.Relacion.AutoSize = true;
            this.Relacion.Location = new System.Drawing.Point(232, 194);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(61, 16);
            this.Relacion.TabIndex = 3;
            this.Relacion.Text = "Relacion";
            // 
            // Parentesco
            // 
            this.Parentesco.Location = new System.Drawing.Point(235, 214);
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.Size = new System.Drawing.Size(246, 22);
            this.Parentesco.TabIndex = 4;
            // 
            // EncargadoEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}