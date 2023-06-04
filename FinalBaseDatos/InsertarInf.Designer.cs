namespace FinalBaseDatos
{
    partial class InsertarInf
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
            this.NombreInf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tarifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Volver = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreInf
            // 
            this.NombreInf.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NombreInf.Location = new System.Drawing.Point(109, 86);
            this.NombreInf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreInf.Name = "NombreInf";
            this.NombreInf.Size = new System.Drawing.Size(153, 22);
            this.NombreInf.TabIndex = 0;
            this.NombreInf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.FechaNacimiento.Location = new System.Drawing.Point(109, 191);
            this.FechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(151, 22);
            this.FechaNacimiento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.FechaIngreso.Location = new System.Drawing.Point(444, 86);
            this.FechaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(147, 22);
            this.FechaIngreso.TabIndex = 4;
            this.FechaIngreso.TextChanged += new System.EventHandler(this.FechaIngreso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Ingreso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Tarifa
            // 
            this.Tarifa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Tarifa.Location = new System.Drawing.Point(444, 191);
            this.Tarifa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Size = new System.Drawing.Size(151, 22);
            this.Tarifa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarifa Mensual";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.PhotoRoom_20230531_181445;
            this.pictureBox1.Location = new System.Drawing.Point(67, 235);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(795, 494);
            this.Volver.Margin = new System.Windows.Forms.Padding(4);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(116, 33);
            this.Volver.TabIndex = 9;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 23);
            this.back.TabIndex = 10;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(109, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "AA-MM-DD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(441, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "AA-MM-DD";
            // 
            // InsertarInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tarifa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreInf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertarInf";
            this.Text = "Nuevo Infante";
            this.Load += new System.EventHandler(this.InsertarInf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FechaNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}