namespace FinalBaseDatos
{
    partial class Sueldos
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
            this.Volver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.año = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.TextBox();
            this.infante = new System.Windows.Forms.TextBox();
            this.busca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(23, 407);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Encargado";
            // 
            // año
            // 
            this.año.BackColor = System.Drawing.SystemColors.HighlightText;
            this.año.Location = new System.Drawing.Point(507, 107);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(100, 22);
            this.año.TabIndex = 9;
            // 
            // mes
            // 
            this.mes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mes.Location = new System.Drawing.Point(329, 107);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 22);
            this.mes.TabIndex = 8;
            // 
            // infante
            // 
            this.infante.BackColor = System.Drawing.SystemColors.HighlightText;
            this.infante.Location = new System.Drawing.Point(158, 107);
            this.infante.Name = "infante";
            this.infante.Size = new System.Drawing.Size(100, 22);
            this.infante.TabIndex = 7;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.Color.HotPink;
            this.busca.Location = new System.Drawing.Point(659, 107);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(75, 23);
            this.busca.TabIndex = 13;
            this.busca.Text = "Buscar";
            this.busca.UseVisualStyleBackColor = false;
            // 
            // Sueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.infante);
            this.Controls.Add(this.Volver);
            this.Name = "Sueldos";
            this.Text = "Sueldos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox año;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.TextBox infante;
        private System.Windows.Forms.Button busca;
    }
}