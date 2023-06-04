namespace FinalBaseDatos
{
    partial class Buscando
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
            this.radioNiño = new System.Windows.Forms.RadioButton();
            this.radioAdulto = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.busca = new System.Windows.Forms.Button();
            this.datosGenerales = new System.Windows.Forms.DataGridView();
            this.Alergias = new System.Windows.Forms.Button();
            this.Responsables = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bajas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosGenerales)).BeginInit();
            this.SuspendLayout();
            // 
            // radioNiño
            // 
            this.radioNiño.AutoSize = true;
            this.radioNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNiño.Location = new System.Drawing.Point(489, 55);
            this.radioNiño.Name = "radioNiño";
            this.radioNiño.Size = new System.Drawing.Size(144, 24);
            this.radioNiño.TabIndex = 0;
            this.radioNiño.TabStop = true;
            this.radioNiño.Text = "Nombre Infante";
            this.radioNiño.UseVisualStyleBackColor = true;
            // 
            // radioAdulto
            // 
            this.radioAdulto.AutoSize = true;
            this.radioAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdulto.Location = new System.Drawing.Point(656, 55);
            this.radioAdulto.Name = "radioAdulto";
            this.radioAdulto.Size = new System.Drawing.Size(132, 24);
            this.radioAdulto.TabIndex = 1;
            this.radioAdulto.TabStop = true;
            this.radioAdulto.Text = "Carnet Adulto";
            this.radioAdulto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Una vez elegido un parámetro de búsqueda, ingresar el dato necesario";
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.Color.Silver;
            this.busca.Location = new System.Drawing.Point(26, 90);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(116, 38);
            this.busca.TabIndex = 4;
            this.busca.Text = "Buscar";
            this.busca.UseVisualStyleBackColor = false;
            this.busca.Click += new System.EventHandler(this.busca_Click);
            // 
            // datosGenerales
            // 
            this.datosGenerales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.datosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosGenerales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.datosGenerales.Location = new System.Drawing.Point(26, 155);
            this.datosGenerales.Name = "datosGenerales";
            this.datosGenerales.RowHeadersWidth = 51;
            this.datosGenerales.RowTemplate.Height = 24;
            this.datosGenerales.Size = new System.Drawing.Size(743, 156);
            this.datosGenerales.TabIndex = 5;
            // 
            // Alergias
            // 
            this.Alergias.BackColor = System.Drawing.Color.Silver;
            this.Alergias.Location = new System.Drawing.Point(255, 347);
            this.Alergias.Name = "Alergias";
            this.Alergias.Size = new System.Drawing.Size(124, 41);
            this.Alergias.TabIndex = 6;
            this.Alergias.Text = "Alergias";
            this.Alergias.UseVisualStyleBackColor = false;
            this.Alergias.Click += new System.EventHandler(this.Alergias_Click);
            // 
            // Responsables
            // 
            this.Responsables.BackColor = System.Drawing.Color.Silver;
            this.Responsables.Location = new System.Drawing.Point(427, 347);
            this.Responsables.Name = "Responsables";
            this.Responsables.Size = new System.Drawing.Size(125, 41);
            this.Responsables.TabIndex = 7;
            this.Responsables.Text = "Responsables";
            this.Responsables.UseVisualStyleBackColor = false;
            this.Responsables.Click += new System.EventHandler(this.Responsables_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(13, 415);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(77, 23);
            this.Volver.TabIndex = 8;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // matricula
            // 
            this.matricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(30, 356);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(150, 27);
            this.matricula.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingresar el numero de matrícula si desea ver más infomación";
            // 
            // Bajas
            // 
            this.Bajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.Bajas.Location = new System.Drawing.Point(689, 403);
            this.Bajas.Name = "Bajas";
            this.Bajas.Size = new System.Drawing.Size(99, 40);
            this.Bajas.TabIndex = 11;
            this.Bajas.Text = "Bajas";
            this.Bajas.UseVisualStyleBackColor = false;
            this.Bajas.Click += new System.EventHandler(this.Bajas_Click);
            // 
            // Buscando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.Bajas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Responsables);
            this.Controls.Add(this.Alergias);
            this.Controls.Add(this.datosGenerales);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioAdulto);
            this.Controls.Add(this.radioNiño);
            this.Name = "Buscando";
            this.Text = "Buscando";
            ((System.ComponentModel.ISupportInitialize)(this.datosGenerales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNiño;
        private System.Windows.Forms.RadioButton radioAdulto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button busca;
        private System.Windows.Forms.DataGridView datosGenerales;
        private System.Windows.Forms.Button Alergias;
        private System.Windows.Forms.Button Responsables;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bajas;
    }
}