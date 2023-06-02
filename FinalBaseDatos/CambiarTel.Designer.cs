namespace FinalBaseDatos
{
    partial class CambiarTel
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
            this.carnet = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volver1 = new System.Windows.Forms.Button();
            this.confi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Telant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carnet
            // 
            this.carnet.BackColor = System.Drawing.Color.Linen;
            this.carnet.Location = new System.Drawing.Point(248, 104);
            this.carnet.Name = "carnet";
            this.carnet.Size = new System.Drawing.Size(251, 22);
            this.carnet.TabIndex = 0;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.Linen;
            this.telefono.Location = new System.Drawing.Point(248, 238);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(251, 22);
            this.telefono.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(248, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar el carnet de identidad de quien se hará el cambio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(251, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo numero de telefono";
            // 
            // volver1
            // 
            this.volver1.BackColor = System.Drawing.Color.LightGray;
            this.volver1.Location = new System.Drawing.Point(24, 415);
            this.volver1.Name = "volver1";
            this.volver1.Size = new System.Drawing.Size(95, 23);
            this.volver1.TabIndex = 5;
            this.volver1.Text = "Volver";
            this.volver1.UseVisualStyleBackColor = false;
            this.volver1.Click += new System.EventHandler(this.volver1_Click);
            // 
            // confi
            // 
            this.confi.BackColor = System.Drawing.Color.Green;
            this.confi.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confi.Location = new System.Drawing.Point(251, 308);
            this.confi.Name = "confi";
            this.confi.Size = new System.Drawing.Size(196, 43);
            this.confi.TabIndex = 6;
            this.confi.Text = "Confirmar cambio";
            this.confi.UseVisualStyleBackColor = false;
            this.confi.Click += new System.EventHandler(this.confi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(248, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de Telefono antiguo";
            // 
            // Telant
            // 
            this.Telant.Location = new System.Drawing.Point(251, 177);
            this.Telant.Name = "Telant";
            this.Telant.Size = new System.Drawing.Size(248, 22);
            this.Telant.TabIndex = 8;
            // 
            // CambiarTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Telant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confi);
            this.Controls.Add(this.volver1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.carnet);
            this.Name = "CambiarTel";
            this.Text = "CambiarTel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carnet;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button volver1;
        private System.Windows.Forms.Button confi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Telant;
    }
}