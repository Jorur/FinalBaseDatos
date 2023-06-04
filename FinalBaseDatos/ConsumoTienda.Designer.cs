namespace FinalBaseDatos
{
    partial class ConsumoTienda
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NroMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Nro de Matricula";
            // 
            // NroMatricula
            // 
            this.NroMatricula.Location = new System.Drawing.Point(162, 82);
            this.NroMatricula.Name = "NroMatricula";
            this.NroMatricula.Size = new System.Drawing.Size(100, 22);
            this.NroMatricula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el ID del articulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdArticulo
            // 
            this.IdArticulo.Location = new System.Drawing.Point(162, 168);
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.Size = new System.Drawing.Size(100, 22);
            this.IdArticulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la cantidad";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(162, 257);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 22);
            this.Cantidad.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsumoTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NroMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ConsumoTienda";
            this.Text = "ConsumoTienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NroMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button button2;
    }
}