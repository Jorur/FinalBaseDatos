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
            this.tablaniños = new System.Windows.Forms.DataGridView();
            this.ingresarnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conf = new System.Windows.Forms.Button();
            this.volver1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaniños)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaniños
            // 
            this.tablaniños.BackgroundColor = System.Drawing.Color.LightGray;
            this.tablaniños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaniños.Location = new System.Drawing.Point(201, 12);
            this.tablaniños.Name = "tablaniños";
            this.tablaniños.RowHeadersWidth = 51;
            this.tablaniños.RowTemplate.Height = 24;
            this.tablaniños.Size = new System.Drawing.Size(424, 225);
            this.tablaniños.TabIndex = 0;
            this.tablaniños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaniños_CellContentClick);
            // 
            // ingresarnm
            // 
            this.ingresarnm.BackColor = System.Drawing.Color.RosyBrown;
            this.ingresarnm.Location = new System.Drawing.Point(221, 315);
            this.ingresarnm.Name = "ingresarnm";
            this.ingresarnm.Size = new System.Drawing.Size(321, 22);
            this.ingresarnm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar numero de matricula";
            // 
            // conf
            // 
            this.conf.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf.Location = new System.Drawing.Point(548, 300);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(86, 50);
            this.conf.TabIndex = 3;
            this.conf.Text = "Confirmar";
            this.conf.UseVisualStyleBackColor = true;
            this.conf.Click += new System.EventHandler(this.conf_Click);
            // 
            // volver1
            // 
            this.volver1.BackColor = System.Drawing.Color.LightGray;
            this.volver1.Location = new System.Drawing.Point(12, 415);
            this.volver1.Name = "volver1";
            this.volver1.Size = new System.Drawing.Size(95, 23);
            this.volver1.TabIndex = 5;
            this.volver1.Text = "Volver";
            this.volver1.UseVisualStyleBackColor = false;
            this.volver1.Click += new System.EventHandler(this.volver1_Click);
            // 
            // DarBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver1);
            this.Controls.Add(this.conf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresarnm);
            this.Controls.Add(this.tablaniños);
            this.Name = "DarBaja";
            this.Text = "DarBaja";
            this.Load += new System.EventHandler(this.DarBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaniños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaniños;
        private System.Windows.Forms.TextBox ingresarnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conf;
        private System.Windows.Forms.Button volver1;
    }
}