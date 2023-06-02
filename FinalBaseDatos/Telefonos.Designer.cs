namespace FinalBaseDatos
{
    partial class Telefonos
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
            this.Cambiar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cambiar
            // 
            this.Cambiar.Location = new System.Drawing.Point(56, 111);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(165, 48);
            this.Cambiar.TabIndex = 0;
            this.Cambiar.Text = "Cambiar Telefono";
            this.Cambiar.UseVisualStyleBackColor = true;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(491, 112);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(181, 47);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar Telefono";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Telefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Cambiar);
            this.Name = "Telefonos";
            this.Text = "Telefonos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cambiar;
        private System.Windows.Forms.Button Eliminar;
    }
}