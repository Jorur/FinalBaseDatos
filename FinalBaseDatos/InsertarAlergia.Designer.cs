namespace FinalBaseDatos
{
    partial class InsertarAlergia
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
            this.Ingrediente = new System.Windows.Forms.TextBox();
            this.Nro = new System.Windows.Forms.Label();
            this.NroMatricula = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.volv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediente al que le tiene alergia";
            // 
            // Ingrediente
            // 
            this.Ingrediente.Location = new System.Drawing.Point(130, 104);
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.Size = new System.Drawing.Size(192, 22);
            this.Ingrediente.TabIndex = 1;
            // 
            // Nro
            // 
            this.Nro.AutoSize = true;
            this.Nro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nro.Location = new System.Drawing.Point(108, 171);
            this.Nro.Name = "Nro";
            this.Nro.Size = new System.Drawing.Size(228, 18);
            this.Nro.TabIndex = 2;
            this.Nro.Text = "Numero de matricula del infante";
            // 
            // NroMatricula
            // 
            this.NroMatricula.Location = new System.Drawing.Point(130, 204);
            this.NroMatricula.Name = "NroMatricula";
            this.NroMatricula.Size = new System.Drawing.Size(192, 22);
            this.NroMatricula.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.BackColor = System.Drawing.Color.DarkOrange;
            this.Conf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf.Location = new System.Drawing.Point(130, 278);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(206, 62);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar Alergia";
            this.Conf.UseVisualStyleBackColor = false;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // volv
            // 
            this.volv.Location = new System.Drawing.Point(28, 415);
            this.volv.Name = "volv";
            this.volv.Size = new System.Drawing.Size(92, 23);
            this.volv.TabIndex = 5;
            this.volv.Text = "Volver";
            this.volv.UseVisualStyleBackColor = true;
            this.volv.Click += new System.EventHandler(this.volv_Click);
            // 
            // InsertarAlergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volv);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.NroMatricula);
            this.Controls.Add(this.Nro);
            this.Controls.Add(this.Ingrediente);
            this.Controls.Add(this.label1);
            this.Name = "InsertarAlergia";
            this.Text = "Nueva Alergia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ingrediente;
        private System.Windows.Forms.Label Nro;
        private System.Windows.Forms.TextBox NroMatricula;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Button volv;
    }
}