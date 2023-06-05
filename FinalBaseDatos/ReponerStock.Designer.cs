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
            this.label2 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbarticulo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Reposición:";
            // 
            // Cantidad
            // 
            this.Cantidad.BackColor = System.Drawing.Color.PeachPuff;
            this.Cantidad.Location = new System.Drawing.Point(59, 254);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(177, 22);
            this.Cantidad.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.BackColor = System.Drawing.Color.DodgerBlue;
            this.Conf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf.Location = new System.Drawing.Point(640, 364);
            this.Conf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(123, 70);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar";
            this.Conf.UseVisualStyleBackColor = false;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.DodgerBlue;
            this.Volver.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(28, 389);
            this.Volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(79, 38);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.ConsTienda;
            this.pictureBox1.Location = new System.Drawing.Point(441, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbarticulo
            // 
            this.cmbarticulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbarticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbarticulo.FormattingEnabled = true;
            this.cmbarticulo.Items.AddRange(new object[] {
            "Pañales",
            "Mamaderas",
            "Caja Pañitos",
            "Talco",
            "Juguetes",
            "Dulces",
            "Chupete",
            "Hipoglos",
            "Pichica",
            "Ropa interior"});
            this.cmbarticulo.Location = new System.Drawing.Point(59, 149);
            this.cmbarticulo.Name = "cmbarticulo";
            this.cmbarticulo.Size = new System.Drawing.Size(177, 24);
            this.cmbarticulo.TabIndex = 7;
            // 
            // ReponerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbarticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReponerStock";
            this.Text = "Reponer Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbarticulo;
    }
}