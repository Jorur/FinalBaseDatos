namespace FinalBaseDatos
{
    partial class EliminarTel
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
            this.Carnet = new System.Windows.Forms.Label();
            this.Ci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Carnet
            // 
            this.Carnet.AutoSize = true;
            this.Carnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Carnet.Location = new System.Drawing.Point(116, 109);
            this.Carnet.Name = "Carnet";
            this.Carnet.Size = new System.Drawing.Size(217, 18);
            this.Carnet.TabIndex = 0;
            this.Carnet.Text = "Carnet de identidad del encargado";
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(380, 109);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(250, 22);
            this.Ci.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(116, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de telefono a eliminar";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(380, 161);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(250, 22);
            this.Telefono.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.BackColor = System.Drawing.Color.Gold;
            this.Conf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Conf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf.Location = new System.Drawing.Point(286, 247);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(188, 62);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar eliminación";
            this.Conf.UseVisualStyleBackColor = false;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(28, 400);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // EliminarTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.Carnet);
            this.Name = "EliminarTel";
            this.Text = "EliminarTel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Carnet;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Button back;
    }
}