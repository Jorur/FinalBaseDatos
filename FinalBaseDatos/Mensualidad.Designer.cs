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
            this.menus = new System.Windows.Forms.Button();
            this.servicios = new System.Windows.Forms.Button();
            this.Tienda = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puede encontrar todo consumo que el infante halla realizado en el mes indicado";
            // 
            // infante
            // 
            this.infante.BackColor = System.Drawing.SystemColors.HighlightText;
            this.infante.Location = new System.Drawing.Point(177, 98);
            this.infante.Name = "infante";
            this.infante.Size = new System.Drawing.Size(100, 22);
            this.infante.TabIndex = 1;
            // 
            // mes
            // 
            this.mes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mes.Location = new System.Drawing.Point(348, 98);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 22);
            this.mes.TabIndex = 2;
            // 
            // año
            // 
            this.año.BackColor = System.Drawing.SystemColors.HighlightText;
            this.año.Location = new System.Drawing.Point(526, 98);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(100, 22);
            this.año.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año";
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
            this.pagar.Location = new System.Drawing.Point(667, 379);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(105, 59);
            this.pagar.TabIndex = 8;
            this.pagar.Text = "Pagar";
            this.pagar.UseVisualStyleBackColor = false;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // menus
            // 
            this.menus.BackColor = System.Drawing.Color.PaleGreen;
            this.menus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menus.Location = new System.Drawing.Point(24, 159);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(75, 23);
            this.menus.TabIndex = 11;
            this.menus.Text = "Menus";
            this.menus.UseVisualStyleBackColor = false;
            this.menus.Click += new System.EventHandler(this.menus_Click);
            // 
            // servicios
            // 
            this.servicios.BackColor = System.Drawing.Color.PaleGreen;
            this.servicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.servicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicios.Location = new System.Drawing.Point(24, 231);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(75, 23);
            this.servicios.TabIndex = 12;
            this.servicios.Text = "Servicios Ad";
            this.servicios.UseVisualStyleBackColor = false;
            this.servicios.Click += new System.EventHandler(this.servicios_Click);
            // 
            // Tienda
            // 
            this.Tienda.BackColor = System.Drawing.Color.PaleGreen;
            this.Tienda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tienda.Location = new System.Drawing.Point(24, 305);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(75, 23);
            this.Tienda.TabIndex = 13;
            this.Tienda.Text = "Tienda";
            this.Tienda.UseVisualStyleBackColor = false;
            this.Tienda.Click += new System.EventHandler(this.Tienda_Click);
            // 
            // go
            // 
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.go.Location = new System.Drawing.Point(667, 98);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(105, 22);
            this.go.TabIndex = 14;
            this.go.Text = "Buscar";
            this.go.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(177, 136);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidth = 51;
            this.Datos.RowTemplate.Height = 24;
            this.Datos.Size = new System.Drawing.Size(449, 192);
            this.Datos.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(174, 408);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 16);
            this.Total.TabIndex = 16;
            this.Total.Text = "label6";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // Mensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.go);
            this.Controls.Add(this.Tienda);
            this.Controls.Add(this.servicios);
            this.Controls.Add(this.menus);
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
        private System.Windows.Forms.Button menus;
        private System.Windows.Forms.Button servicios;
        private System.Windows.Forms.Button Tienda;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label Total;
    }
}