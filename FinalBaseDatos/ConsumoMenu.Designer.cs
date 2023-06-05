namespace FinalBaseDatos
{
    partial class ConsumoMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.NroMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Ver = new System.Windows.Forms.Button();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NroMatricula
            // 
            this.NroMatricula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NroMatricula.Location = new System.Drawing.Point(289, 167);
            this.NroMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NroMatricula.Name = "NroMatricula";
            this.NroMatricula.Size = new System.Drawing.Size(138, 22);
            this.NroMatricula.TabIndex = 1;
            this.NroMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el Nro. de Matricula:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el Nro. de Menu:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(635, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ver
            // 
            this.Ver.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Ver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ver.Location = new System.Drawing.Point(162, 167);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(108, 32);
            this.Ver.TabIndex = 6;
            this.Ver.Text = "Ver lista";
            this.Ver.UseVisualStyleBackColor = false;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // cmbMenu
            // 
            this.cmbMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Items.AddRange(new object[] {
            "Men1",
            "Men2",
            "Men3",
            "Men4",
            "Men5",
            "Men6",
            "Men7"});
            this.cmbMenu.Location = new System.Drawing.Point(289, 273);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(199, 24);
            this.cmbMenu.TabIndex = 7;
            // 
            // ConsumoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalBaseDatos.Properties.Resources.fondoMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NroMatricula);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsumoMenu";
            this.Text = "ConsumoMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NroMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Ver;
        private System.Windows.Forms.ComboBox cmbMenu;
    }
}