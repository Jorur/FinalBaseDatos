namespace FinalBaseDatos
{
    partial class Factura
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
            this.Recibo = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.menus = new System.Windows.Forms.Label();
            this.servicios = new System.Windows.Forms.Label();
            this.tienda = new System.Windows.Forms.Label();
            this.todo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.Label();
            this.Articulo = new System.Windows.Forms.Label();
            this.Servicio = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.Label();
            this.año = new System.Windows.Forms.Label();
            this.fech = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recibo
            // 
            this.Recibo.AutoSize = true;
            this.Recibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recibo.Location = new System.Drawing.Point(58, 52);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(271, 25);
            this.Recibo.TabIndex = 0;
            this.Recibo.Text = "-------------- Recibo -------------";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(46, 120);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(53, 18);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Fecha:";
            // 
            // menus
            // 
            this.menus.AutoSize = true;
            this.menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menus.Location = new System.Drawing.Point(46, 261);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(176, 18);
            this.menus.TabIndex = 4;
            this.menus.Text = "Total menús + tarifa mes:";
            // 
            // servicios
            // 
            this.servicios.AutoSize = true;
            this.servicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicios.Location = new System.Drawing.Point(49, 301);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(108, 18);
            this.servicios.TabIndex = 5;
            this.servicios.Text = "Total servicios:";
            // 
            // tienda
            // 
            this.tienda.AutoSize = true;
            this.tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienda.Location = new System.Drawing.Point(49, 344);
            this.tienda.Name = "tienda";
            this.tienda.Size = new System.Drawing.Size(88, 18);
            this.tienda.TabIndex = 6;
            this.tienda.Text = "Total tienda:";
            // 
            // todo
            // 
            this.todo.AutoSize = true;
            this.todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo.Location = new System.Drawing.Point(49, 385);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(98, 18);
            this.todo.TabIndex = 7;
            this.todo.Text = "Total a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "--------------------------------------";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Periodo:";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(86, 192);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(34, 16);
            this.year.TabIndex = 10;
            this.year.Text = "Año:";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(86, 228);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(36, 16);
            this.month.TabIndex = 11;
            this.month.Text = "Mes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.rainbowglitter;
            this.pictureBox1.Location = new System.Drawing.Point(156, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(153, 387);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 16);
            this.Total.TabIndex = 13;
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Location = new System.Drawing.Point(143, 346);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(0, 16);
            this.Articulo.TabIndex = 14;
            // 
            // Servicio
            // 
            this.Servicio.AutoSize = true;
            this.Servicio.Location = new System.Drawing.Point(164, 301);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(0, 16);
            this.Servicio.TabIndex = 15;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Location = new System.Drawing.Point(242, 334);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(0, 16);
            this.Menu.TabIndex = 16;
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(128, 228);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(0, 16);
            this.Mes.TabIndex = 17;
            // 
            // año
            // 
            this.año.AutoSize = true;
            this.año.Location = new System.Drawing.Point(131, 192);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(0, 16);
            this.año.TabIndex = 18;
            // 
            // fech
            // 
            this.fech.AutoSize = true;
            this.fech.Location = new System.Drawing.Point(103, 122);
            this.fech.Name = "fech";
            this.fech.Size = new System.Drawing.Size(0, 16);
            this.fech.TabIndex = 19;
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(242, 263);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(0, 16);
            this.men.TabIndex = 20;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 537);
            this.Controls.Add(this.men);
            this.Controls.Add(this.fech);
            this.Controls.Add(this.año);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Servicio);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.todo);
            this.Controls.Add(this.tienda);
            this.Controls.Add(this.servicios);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Recibo);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recibo;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label menus;
        private System.Windows.Forms.Label servicios;
        private System.Windows.Forms.Label tienda;
        private System.Windows.Forms.Label todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.Label Servicio;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Mes;
        private System.Windows.Forms.Label año;
        private System.Windows.Forms.Label fech;
        private System.Windows.Forms.Label men;
    }
}