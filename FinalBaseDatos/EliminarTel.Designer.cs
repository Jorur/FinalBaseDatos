namespace FinalBaseDatos
{
    partial class EliminarTel
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
            this.Carnet = new System.Windows.Forms.Label();
            this.Ci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Carnet
            // 
            this.Carnet.AutoSize = true;
            this.Carnet.Location = new System.Drawing.Point(159, 79);
            this.Carnet.Name = "Carnet";
            this.Carnet.Size = new System.Drawing.Size(215, 16);
            this.Carnet.TabIndex = 0;
            this.Carnet.Text = "Carnet de identidad del encargado";
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(162, 111);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(250, 22);
            this.Ci.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de telefono a eliminar";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(162, 196);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(250, 22);
            this.Telefono.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.Location = new System.Drawing.Point(284, 291);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(219, 23);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar";
            this.Conf.UseVisualStyleBackColor = true;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // EliminarTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.Carnet);
            this.Name = "EliminarTel";
            this.Text = "EliminarTel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Carnet;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Button Conf;
    }
}