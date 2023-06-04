namespace FinalBaseDatos
{
    partial class InsertarAlergia
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nro = new System.Windows.Forms.Label();
            this.NroMatricula = new System.Windows.Forms.TextBox();
            this.Conf = new System.Windows.Forms.Button();
            this.volv = new System.Windows.Forms.Button();
            this.cmbingre = new System.Windows.Forms.ComboBox();
            this.dataGridInfantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediente al que le tiene alergia";
            // 
            // Nro
            // 
            this.Nro.AutoSize = true;
            this.Nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nro.Location = new System.Drawing.Point(106, 173);
            this.Nro.Name = "Nro";
            this.Nro.Size = new System.Drawing.Size(247, 20);
            this.Nro.TabIndex = 2;
            this.Nro.Text = "Numero de matricula del infante";
            // 
            // NroMatricula
            // 
            this.NroMatricula.Location = new System.Drawing.Point(108, 194);
            this.NroMatricula.Name = "NroMatricula";
            this.NroMatricula.Size = new System.Drawing.Size(242, 22);
            this.NroMatricula.TabIndex = 3;
            // 
            // Conf
            // 
            this.Conf.BackColor = System.Drawing.Color.DarkOrange;
            this.Conf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf.Location = new System.Drawing.Point(122, 258);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(206, 62);
            this.Conf.TabIndex = 4;
            this.Conf.Text = "Confirmar Alergia";
            this.Conf.UseVisualStyleBackColor = false;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // volv
            // 
            this.volv.Location = new System.Drawing.Point(28, 415);
            this.volv.Name = "volv";
            this.volv.Size = new System.Drawing.Size(92, 23);
            this.volv.TabIndex = 5;
            this.volv.Text = "Volver";
            this.volv.UseVisualStyleBackColor = true;
            this.volv.Click += new System.EventHandler(this.volv_Click);
            // 
            // cmbingre
            // 
            this.cmbingre.FormattingEnabled = true;
            this.cmbingre.Items.AddRange(new object[] {
            "Pollo",
            "Arroz",
            "Papa",
            "Salchicha",
            "Zanahoria",
            "Tomate",
            "Zapallo",
            "Queso",
            "Harina",
            "Fideo"});
            this.cmbingre.Location = new System.Drawing.Point(108, 108);
            this.cmbingre.Name = "cmbingre";
            this.cmbingre.Size = new System.Drawing.Size(242, 24);
            this.cmbingre.TabIndex = 6;
            // 
            // dataGridInfantes
            // 
            this.dataGridInfantes.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridInfantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridInfantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfantes.Location = new System.Drawing.Point(436, 88);
            this.dataGridInfantes.Name = "dataGridInfantes";
            this.dataGridInfantes.RowHeadersWidth = 51;
            this.dataGridInfantes.RowTemplate.Height = 24;
            this.dataGridInfantes.Size = new System.Drawing.Size(336, 232);
            this.dataGridInfantes.TabIndex = 7;
            this.dataGridInfantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInfantes_CellContentClick);
            // 
            // InsertarAlergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridInfantes);
            this.Controls.Add(this.cmbingre);
            this.Controls.Add(this.volv);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.NroMatricula);
            this.Controls.Add(this.Nro);
            this.Controls.Add(this.label1);
            this.Name = "InsertarAlergia";
            this.Text = "Nueva Alergia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nro;
        private System.Windows.Forms.TextBox NroMatricula;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Button volv;
        private System.Windows.Forms.ComboBox cmbingre;
        private System.Windows.Forms.DataGridView dataGridInfantes;
    }
}