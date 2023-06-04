namespace FinalBaseDatos
{
    partial class TodaBaja
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
            this.Baja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Baja)).BeginInit();
            this.SuspendLayout();
            // 
            // Baja
            // 
            this.Baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Baja.Location = new System.Drawing.Point(-2, -3);
            this.Baja.Name = "Baja";
            this.Baja.RowHeadersWidth = 51;
            this.Baja.RowTemplate.Height = 24;
            this.Baja.Size = new System.Drawing.Size(782, 204);
            this.Baja.TabIndex = 0;
            // 
            // TodaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 201);
            this.Controls.Add(this.Baja);
            this.Name = "TodaBaja";
            this.Text = "TodaBaja";
            ((System.ComponentModel.ISupportInitialize)(this.Baja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Baja;
    }
}