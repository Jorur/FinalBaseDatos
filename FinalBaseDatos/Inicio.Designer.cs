namespace FinalBaseDatos
{
    partial class Inicio
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
            System.Windows.Forms.Label label2;
            this.Titulo = new System.Windows.Forms.Label();
            this.RegistroInfante = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menus = new System.Windows.Forms.Button();
            this.Servicios = new System.Windows.Forms.Button();
            this.Tienda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Turquoise;
            label2.Location = new System.Drawing.Point(311, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(316, 60);
            label2.TabIndex = 1;
            label2.Text = "ARCO IRIS";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Titulo
            // 
            this.Titulo.AccessibleName = "Titulo";
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.IndianRed;
            this.Titulo.Location = new System.Drawing.Point(394, 86);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(152, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Guarderia ";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistroInfante
            // 
            this.RegistroInfante.BackColor = System.Drawing.Color.Thistle;
            this.RegistroInfante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegistroInfante.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroInfante.Location = new System.Drawing.Point(399, 349);
            this.RegistroInfante.Name = "RegistroInfante";
            this.RegistroInfante.Size = new System.Drawing.Size(123, 62);
            this.RegistroInfante.TabIndex = 2;
            this.RegistroInfante.Text = "Registo Infante";
            this.RegistroInfante.UseVisualStyleBackColor = false;
            this.RegistroInfante.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.rainbowglitter;
            this.pictureBox1.Location = new System.Drawing.Point(131, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menus
            // 
            this.Menus.Location = new System.Drawing.Point(50, 110);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(75, 23);
            this.Menus.TabIndex = 4;
            this.Menus.Text = "Menús";
            this.Menus.UseVisualStyleBackColor = true;
            this.Menus.Click += new System.EventHandler(this.button2_Click);
            // 
            // Servicios
            // 
            this.Servicios.Location = new System.Drawing.Point(50, 222);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(75, 23);
            this.Servicios.TabIndex = 5;
            this.Servicios.Text = "Servicios ";
            this.Servicios.UseVisualStyleBackColor = true;
            // 
            // Tienda
            // 
            this.Tienda.Location = new System.Drawing.Point(50, 333);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(75, 23);
            this.Tienda.TabIndex = 6;
            this.Tienda.Text = "Tienda";
            this.Tienda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(131, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "new";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(131, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "new";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(939, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tienda);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.RegistroInfante);
            this.Controls.Add(label2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inicio";
            this.Text = "Guarderia Arco Iris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button RegistroInfante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Menus;
        private System.Windows.Forms.Button Servicios;
        private System.Windows.Forms.Button Tienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

