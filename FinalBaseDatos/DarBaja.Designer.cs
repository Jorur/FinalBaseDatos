namespace FinalBaseDatos
{
    partial class DarBaja
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
            this.MatriInf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrarInf = new System.Windows.Forms.DataGridView();
            this.confi = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInf)).BeginInit();
            this.SuspendLayout();
            // 
            // MatriInf
            // 
            this.MatriInf.Location = new System.Drawing.Point(229, 344);
            this.MatriInf.Name = "MatriInf";
            this.MatriInf.Size = new System.Drawing.Size(241, 22);
            this.MatriInf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(229, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar el numero de matricula";
            // 
            // mostrarInf
            // 
            this.mostrarInf.BackgroundColor = System.Drawing.Color.MistyRose;
            this.mostrarInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarInf.Location = new System.Drawing.Point(229, 48);
            this.mostrarInf.Name = "mostrarInf";
            this.mostrarInf.RowHeadersWidth = 51;
            this.mostrarInf.RowTemplate.Height = 24;
            this.mostrarInf.Size = new System.Drawing.Size(350, 200);
            this.mostrarInf.TabIndex = 2;
            // 
            // confi
            // 
            this.confi.BackColor = System.Drawing.Color.LightCyan;
            this.confi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confi.Location = new System.Drawing.Point(229, 382);
            this.confi.Name = "confi";
            this.confi.Size = new System.Drawing.Size(92, 31);
            this.confi.TabIndex = 3;
            this.confi.Text = "Confirmar";
            this.confi.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            // 
            // DarBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.confi);
            this.Controls.Add(this.mostrarInf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatriInf);
            this.Name = "DarBaja";
            this.Text = "DarBaja";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MatriInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mostrarInf;
        private System.Windows.Forms.Button confi;
        private System.Windows.Forms.Button back;
    }
}