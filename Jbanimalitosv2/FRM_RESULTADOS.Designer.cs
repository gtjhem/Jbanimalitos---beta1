namespace Jbanimalitosv2
{
    partial class FRM_RESULTADOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.lbldetalleticket = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbloteria = new System.Windows.Forms.ComboBox();
            this.Animales = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstSorteos = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbldia = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 608);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Controls.Add(this.lbldetalleticket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(23, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 50);
            this.panel2.TabIndex = 1;
            // 
            // Cerrar
            // 
            this.Cerrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(52)))));
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.Cerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cerrar.LinkColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(909, 0);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(27, 26);
            this.Cerrar.TabIndex = 20;
            this.Cerrar.TabStop = true;
            this.Cerrar.Text = "x";
            this.Cerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.Cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cerrar_LinkClicked);
            // 
            // lbldetalleticket
            // 
            this.lbldetalleticket.AutoSize = true;
            this.lbldetalleticket.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lbldetalleticket.ForeColor = System.Drawing.Color.White;
            this.lbldetalleticket.Location = new System.Drawing.Point(3, 9);
            this.lbldetalleticket.Margin = new System.Windows.Forms.Padding(0);
            this.lbldetalleticket.Name = "lbldetalleticket";
            this.lbldetalleticket.Size = new System.Drawing.Size(378, 32);
            this.lbldetalleticket.TabIndex = 19;
            this.lbldetalleticket.Text = "CARGA DE RESULTADOS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label12.Location = new System.Drawing.Point(27, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Loteria....:";
            // 
            // cmbloteria
            // 
            this.cmbloteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbloteria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbloteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbloteria.FormattingEnabled = true;
            this.cmbloteria.Location = new System.Drawing.Point(32, 82);
            this.cmbloteria.Name = "cmbloteria";
            this.cmbloteria.Size = new System.Drawing.Size(313, 26);
            this.cmbloteria.TabIndex = 23;
            this.cmbloteria.SelectedIndexChanged += new System.EventHandler(this.cmbloteria_SelectedIndexChanged);
            // 
            // Animales
            // 
            this.Animales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.Animales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animales.CheckOnClick = true;
            this.Animales.ColumnWidth = 150;
            this.Animales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animales.ForeColor = System.Drawing.Color.White;
            this.Animales.FormattingEnabled = true;
            this.Animales.Location = new System.Drawing.Point(31, 274);
            this.Animales.MultiColumn = true;
            this.Animales.Name = "Animales";
            this.Animales.Size = new System.Drawing.Size(313, 322);
            this.Animales.TabIndex = 24;
            this.Animales.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Animales_ItemCheck);
            this.Animales.SelectedIndexChanged += new System.EventHandler(this.Animales_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(577, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 52);
            this.button2.TabIndex = 26;
            this.button2.Text = "Asignar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lstSorteos
            // 
            this.lstSorteos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.lstSorteos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSorteos.CheckOnClick = true;
            this.lstSorteos.ColumnWidth = 150;
            this.lstSorteos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSorteos.ForeColor = System.Drawing.Color.White;
            this.lstSorteos.FormattingEnabled = true;
            this.lstSorteos.Location = new System.Drawing.Point(31, 145);
            this.lstSorteos.Name = "lstSorteos";
            this.lstSorteos.Size = new System.Drawing.Size(313, 98);
            this.lstSorteos.TabIndex = 27;
            this.lstSorteos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSorteos_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label7.Location = new System.Drawing.Point(28, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sorteos...:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(27, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ganador..:";
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Nombre.Location = new System.Drawing.Point(658, 184);
            this.Nombre.MaxLength = 20;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Size = new System.Drawing.Size(255, 59);
            this.Nombre.TabIndex = 30;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(358, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 52);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre.....:";
            // 
            // dgr
            // 
            this.dgr.AllowUserToAddRows = false;
            this.dgr.AllowUserToDeleteRows = false;
            this.dgr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.dgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgr.Location = new System.Drawing.Point(359, 304);
            this.dgr.Margin = new System.Windows.Forms.Padding(0);
            this.dgr.Name = "dgr";
            this.dgr.ReadOnly = true;
            this.dgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr.Size = new System.Drawing.Size(591, 292);
            this.dgr.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(357, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 52);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero.....:";
            // 
            // Numero
            // 
            this.Numero.BackColor = System.Drawing.SystemColors.Window;
            this.Numero.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold);
            this.Numero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Numero.Location = new System.Drawing.Point(658, 113);
            this.Numero.MaxLength = 20;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Size = new System.Drawing.Size(255, 59);
            this.Numero.TabIndex = 34;
            this.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(357, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 38);
            this.label2.TabIndex = 35;
            this.label2.Text = "GANADOR DIA.:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(359, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 36;
            this.button1.Text = "- 1 Dia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(821, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 52);
            this.button3.TabIndex = 37;
            this.button3.Text = "+ 1 Dia";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold);
            this.lbldia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.lbldia.Location = new System.Drawing.Point(651, 56);
            this.lbldia.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(266, 42);
            this.lbldia.TabIndex = 38;
            this.lbldia.Text = "27/10/2017";
            this.lbldia.DoubleClick += new System.EventHandler(this.lbldia_DoubleClick);
            // 
            // FRM_RESULTADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSorteos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbloteria);
            this.Controls.Add(this.Animales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FRM_RESULTADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_RESULTADOS";
            this.Load += new System.EventHandler(this.FRM_RESULTADOS_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_RESULTADOS_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbldetalleticket;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbloteria;
        private System.Windows.Forms.CheckedListBox Animales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox lstSorteos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbldia;
    }
}