﻿namespace FinalBaseDatos
{
    partial class InsertarPer
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
            this.NombreEncargado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ci = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Parentesco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NombreEncargado
            // 
            this.NombreEncargado.Location = new System.Drawing.Point(13, 34);
            this.NombreEncargado.Name = "NombreEncargado";
            this.NombreEncargado.Size = new System.Drawing.Size(209, 22);
            this.NombreEncargado.TabIndex = 0;
            this.NombreEncargado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(12, 159);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(209, 22);
            this.Direccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet de Identidad";
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(12, 95);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(206, 22);
            this.Ci.TabIndex = 5;
            this.Ci.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Completar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parentesco";
            // 
            // Parentesco
            // 
            this.Parentesco.Location = new System.Drawing.Point(12, 219);
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.Size = new System.Drawing.Size(210, 22);
            this.Parentesco.TabIndex = 8;
            this.Parentesco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // InsertarPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Parentesco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreEncargado);
            this.Name = "InsertarPer";
            this.Text = "Nuevo Encargado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreEncargado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Parentesco;
    }
}