namespace FinalBaseDatos
{
    partial class Finanzas
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
            this.volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sueldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(23, 415);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(97, 23);
            this.volver.TabIndex = 0;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 155);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mensualidad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sueldos
            // 
            this.sueldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sueldos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sueldos.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldos.Location = new System.Drawing.Point(461, 138);
            this.sueldos.Name = "sueldos";
            this.sueldos.Size = new System.Drawing.Size(129, 155);
            this.sueldos.TabIndex = 2;
            this.sueldos.Text = "Sueldos";
            this.sueldos.UseVisualStyleBackColor = false;
            this.sueldos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sueldos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volver);
            this.Name = "Finanzas";
            this.Text = "Finanzas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sueldos;
    }
}