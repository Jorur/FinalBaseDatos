﻿namespace FinalBaseDatos
{
    partial class ConsumosSA
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
            this.CodServ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.ConfirmarConsumoSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 383);
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
            this.label1.Location = new System.Drawing.Point(160, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Nro. de Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NroMatricula
            // 
            this.NroMatricula.Location = new System.Drawing.Point(163, 74);
            this.NroMatricula.Name = "NroMatricula";
            this.NroMatricula.Size = new System.Drawing.Size(100, 22);
            this.NroMatricula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el codigo de servicio";
            // 
            // CodServ
            // 
            this.CodServ.Location = new System.Drawing.Point(163, 158);
            this.CodServ.Name = "CodServ";
            this.CodServ.Size = new System.Drawing.Size(100, 22);
            this.CodServ.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la descripcion";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(166, 244);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(164, 22);
            this.Descripcion.TabIndex = 6;
            // 
            // ConfirmarConsumoSA
            // 
            this.ConfirmarConsumoSA.Location = new System.Drawing.Point(613, 382);
            this.ConfirmarConsumoSA.Name = "ConfirmarConsumoSA";
            this.ConfirmarConsumoSA.Size = new System.Drawing.Size(84, 36);
            this.ConfirmarConsumoSA.TabIndex = 7;
            this.ConfirmarConsumoSA.Text = "Confirmar";
            this.ConfirmarConsumoSA.UseVisualStyleBackColor = true;
            this.ConfirmarConsumoSA.Click += new System.EventHandler(this.ConfirmarConsumoSA_Click);
            // 
            // ConsumosSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmarConsumoSA);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NroMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ConsumosSA";
            this.Text = "ConsumosSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NroMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodServ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Button ConfirmarConsumoSA;
    }
}