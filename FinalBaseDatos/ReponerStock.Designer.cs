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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Artículo:";
            // 
            // CodArt
            // 
            this.CodArt.BackColor = System.Drawing.Color.PeachPuff;
            this.CodArt.Location = new System.Drawing.Point(44, 116);
            this.CodArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodArt.Name = "CodArt";
            this.CodArt.Size = new System.Drawing.Size(136, 20);
            this.CodArt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Reposición:";
            // 
            // Cantidad
            // 
            this.Cantidad.BackColor = System.Drawing.Color.PeachPuff;
            this.Cantidad.Location = new System.Drawing.Point(44, 206);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(134, 20);
            this.Cantidad.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.BackColor = System.Drawing.Color.DodgerBlue;
            this.Conf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf.Location = new System.Drawing.Point(480, 296);
            this.Conf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(92, 57);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar";
            this.Conf.UseVisualStyleBackColor = false;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.DodgerBlue;
            this.Volver.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(21, 316);
            this.Volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(59, 31);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.ConsTienda;
            this.pictureBox1.Location = new System.Drawing.Point(331, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ReponerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodArt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReponerStock";
            this.Text = "Reponer Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}