namespace FinalBaseDatos
{
    partial class ReponerStock
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
            this.CodArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Articulo";
            // 
            // CodArt
            // 
            this.CodArt.Location = new System.Drawing.Point(28, 53);
            this.CodArt.Name = "CodArt";
            this.CodArt.Size = new System.Drawing.Size(180, 22);
            this.CodArt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Reposicion";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(31, 141);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(177, 22);
            this.Cantidad.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.Location = new System.Drawing.Point(675, 404);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(75, 23);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar";
            this.Conf.UseVisualStyleBackColor = true;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(28, 404);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ReponerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodArt);
            this.Controls.Add(this.label1);
            this.Name = "ReponerStock";
            this.Text = "Reponer Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Button Volver;
    }
}