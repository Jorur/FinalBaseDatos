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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.DeepPink;
            label2.Location = new System.Drawing.Point(366, 9);
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
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Titulo.Location = new System.Drawing.Point(378, 69);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(152, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Guarderia ";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistroInfante
            // 
            this.RegistroInfante.BackColor = System.Drawing.Color.HotPink;
            this.RegistroInfante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegistroInfante.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroInfante.Location = new System.Drawing.Point(376, 212);
            this.RegistroInfante.Name = "RegistroInfante";
            this.RegistroInfante.Size = new System.Drawing.Size(130, 183);
            this.RegistroInfante.TabIndex = 2;
            this.RegistroInfante.Text = "Admisiones";
            this.RegistroInfante.UseVisualStyleBackColor = false;
            this.RegistroInfante.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 183);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consumos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(789, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 183);
            this.button2.TabIndex = 5;
            this.button2.Text = "Finanzas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.LightCyan;
            this.Buscar.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(789, 69);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(133, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.treechildrens;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(939, 500);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegistroInfante);
            this.Controls.Add(label2);
            this.Controls.Add(this.Titulo);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Buscar;
    }
}

