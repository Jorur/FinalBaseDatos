namespace FinalBaseDatos
{
    partial class Mensualidad
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
            this.infante = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.TextBox();
            this.año = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.pagar = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.radioMenu = new System.Windows.Forms.RadioButton();
            this.radioServicios = new System.Windows.Forms.RadioButton();
            this.radiotienda = new System.Windows.Forms.RadioButton();
            this.combomes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puede encontrar todo consumo que el infante halla realizado en el mes indicado";
            // 
            // infante
            // 
            this.infante.BackColor = System.Drawing.SystemColors.HighlightText;
            this.infante.Location = new System.Drawing.Point(141, 101);
            this.infante.Name = "infante";
            this.infante.Size = new System.Drawing.Size(100, 22);
            this.infante.TabIndex = 1;
            // 
            // mes
            // 
            this.mes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mes.Location = new System.Drawing.Point(15, 49);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 22);
            this.mes.TabIndex = 2;
            // 
            // año
            // 
            this.año.BackColor = System.Drawing.SystemColors.HighlightText;
            this.año.Location = new System.Drawing.Point(490, 101);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(100, 22);
            this.año.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año [ AAAA]";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(24, 405);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(91, 23);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // pagar
            // 
            this.pagar.BackColor = System.Drawing.Color.Pink;
            this.pagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pagar.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar.Location = new System.Drawing.Point(655, 376);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(117, 62);
            this.pagar.TabIndex = 8;
            this.pagar.Text = "Pagar";
            this.pagar.UseVisualStyleBackColor = false;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(225)))));
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.go.Location = new System.Drawing.Point(631, 88);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(105, 35);
            this.go.TabIndex = 14;
            this.go.Text = "Buscar";
            this.go.UseVisualStyleBackColor = false;
            // 
            // Datos
            // 
            this.Datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(144, 136);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidth = 51;
            this.Datos.RowTemplate.Height = 24;
            this.Datos.Size = new System.Drawing.Size(517, 192);
            this.Datos.TabIndex = 15;
            this.Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellContentClick);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(174, 408);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 16);
            this.Total.TabIndex = 16;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // radioMenu
            // 
            this.radioMenu.AutoSize = true;
            this.radioMenu.Location = new System.Drawing.Point(12, 183);
            this.radioMenu.Name = "radioMenu";
            this.radioMenu.Size = new System.Drawing.Size(68, 20);
            this.radioMenu.TabIndex = 18;
            this.radioMenu.TabStop = true;
            this.radioMenu.Text = "Menús";
            this.radioMenu.UseVisualStyleBackColor = true;
            this.radioMenu.CheckedChanged += new System.EventHandler(this.radioMenu_CheckedChanged);
            // 
            // radioServicios
            // 
            this.radioServicios.AutoSize = true;
            this.radioServicios.Location = new System.Drawing.Point(12, 225);
            this.radioServicios.Name = "radioServicios";
            this.radioServicios.Size = new System.Drawing.Size(84, 20);
            this.radioServicios.TabIndex = 19;
            this.radioServicios.TabStop = true;
            this.radioServicios.Text = "Servicios";
            this.radioServicios.UseVisualStyleBackColor = true;
            this.radioServicios.CheckedChanged += new System.EventHandler(this.radioServicios_CheckedChanged);
            // 
            // radiotienda
            // 
            this.radiotienda.AutoSize = true;
            this.radiotienda.Location = new System.Drawing.Point(12, 265);
            this.radiotienda.Name = "radiotienda";
            this.radiotienda.Size = new System.Drawing.Size(71, 20);
            this.radiotienda.TabIndex = 20;
            this.radiotienda.TabStop = true;
            this.radiotienda.Text = "Tienda";
            this.radiotienda.UseVisualStyleBackColor = true;
            this.radiotienda.CheckedChanged += new System.EventHandler(this.radiotienda_CheckedChanged);
            // 
            // combomes
            // 
            this.combomes.FormattingEnabled = true;
            this.combomes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.combomes.Location = new System.Drawing.Point(312, 101);
            this.combomes.Name = "combomes";
            this.combomes.Size = new System.Drawing.Size(121, 24);
            this.combomes.TabIndex = 21;
            // 
            // Mensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combomes);
            this.Controls.Add(this.radiotienda);
            this.Controls.Add(this.radioServicios);
            this.Controls.Add(this.radioMenu);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.go);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.infante);
            this.Controls.Add(this.label1);
            this.Name = "Mensualidad";
            this.Text = "Mensualidad";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infante;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.TextBox año;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button pagar;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.RadioButton radioMenu;
        private System.Windows.Forms.RadioButton radioServicios;
        private System.Windows.Forms.RadioButton radiotienda;
        private System.Windows.Forms.ComboBox combomes;
    }
}