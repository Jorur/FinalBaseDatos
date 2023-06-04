namespace FinalBaseDatos
{
    partial class TablasAR
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
            this.alerRes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alerRes)).BeginInit();
            this.SuspendLayout();
            // 
            // alerRes
            // 
            this.alerRes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(154)))));
            this.alerRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alerRes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(154)))));
            this.alerRes.Location = new System.Drawing.Point(1, 1);
            this.alerRes.Name = "alerRes";
            this.alerRes.RowHeadersWidth = 51;
            this.alerRes.RowTemplate.Height = 24;
            this.alerRes.Size = new System.Drawing.Size(658, 272);
            this.alerRes.TabIndex = 0;
            // 
            // TablasAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 273);
            this.Controls.Add(this.alerRes);
            this.Name = "TablasAR";
            this.Text = "TablasAR";
            ((System.ComponentModel.ISupportInitialize)(this.alerRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alerRes;
    }
}