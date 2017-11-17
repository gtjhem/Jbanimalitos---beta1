namespace Jbanimalitosv2
{
    partial class FRM_JUGADAS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.lblloteria = new System.Windows.Forms.Label();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.dtdesde = new System.Windows.Forms.DateTimePicker();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbloteria = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbsorteo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbjugadas = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Controls.Add(this.lblloteria);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 56);
            this.panel2.TabIndex = 46;
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
            this.Cerrar.TabIndex = 18;
            this.Cerrar.TabStop = true;
            this.Cerrar.Text = "x";
            this.Cerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.Cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cerrar_LinkClicked);
            // 
            // lblloteria
            // 
            this.lblloteria.AutoSize = true;
            this.lblloteria.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblloteria.ForeColor = System.Drawing.Color.White;
            this.lblloteria.Location = new System.Drawing.Point(10, 13);
            this.lblloteria.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lblloteria.Name = "lblloteria";
            this.lblloteria.Size = new System.Drawing.Size(488, 32);
            this.lblloteria.TabIndex = 17;
            this.lblloteria.Text = "Reporte de Jugadas por Animal";
            // 
            // dthasta
            // 
            this.dthasta.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dthasta.Font = new System.Drawing.Font("Verdana", 12F);
            this.dthasta.Location = new System.Drawing.Point(379, 58);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(135, 27);
            this.dthasta.TabIndex = 54;
            // 
            // dtdesde
            // 
            this.dtdesde.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdesde.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtdesde.Location = new System.Drawing.Point(152, 58);
            this.dtdesde.Name = "dtdesde";
            this.dtdesde.Size = new System.Drawing.Size(135, 27);
            this.dtdesde.TabIndex = 53;
            // 
            // dgr
            // 
            this.dgr.AllowUserToAddRows = false;
            this.dgr.AllowUserToDeleteRows = false;
            this.dgr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.dgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgr.Location = new System.Drawing.Point(22, 200);
            this.dgr.Margin = new System.Windows.Forms.Padding(0);
            this.dgr.Name = "dgr";
            this.dgr.ReadOnly = true;
            this.dgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr.Size = new System.Drawing.Size(933, 283);
            this.dgr.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Loteria...:";
            // 
            // cmbloteria
            // 
            this.cmbloteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbloteria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbloteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbloteria.FormattingEnabled = true;
            this.cmbloteria.Location = new System.Drawing.Point(150, 98);
            this.cmbloteria.Name = "cmbloteria";
            this.cmbloteria.Size = new System.Drawing.Size(367, 26);
            this.cmbloteria.TabIndex = 50;
            this.cmbloteria.SelectedIndexChanged += new System.EventHandler(this.cmbloteria_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(661, 81);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(223, 91);
            this.Buscar.TabIndex = 49;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(293, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hasta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(33, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 47;
            this.label12.Text = "Desde....:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 492);
            this.panel1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Sorteo....:";
            // 
            // cmbsorteo
            // 
            this.cmbsorteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsorteo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbsorteo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbsorteo.FormattingEnabled = true;
            this.cmbsorteo.Location = new System.Drawing.Point(150, 130);
            this.cmbsorteo.Name = "cmbsorteo";
            this.cmbsorteo.Size = new System.Drawing.Size(367, 26);
            this.cmbsorteo.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Jugada...:";
            // 
            // cmbjugadas
            // 
            this.cmbjugadas.DropDownHeight = 150;
            this.cmbjugadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjugadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbjugadas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbjugadas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbjugadas.FormattingEnabled = true;
            this.cmbjugadas.IntegralHeight = false;
            this.cmbjugadas.Location = new System.Drawing.Point(150, 162);
            this.cmbjugadas.Name = "cmbjugadas";
            this.cmbjugadas.Size = new System.Drawing.Size(367, 26);
            this.cmbjugadas.TabIndex = 57;
            // 
            // FRM_JUGADAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbjugadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbsorteo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtdesde);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbloteria);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_JUGADAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_JUGADAS";
            this.Load += new System.EventHandler(this.FRM_JUGADAS_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label lblloteria;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.DateTimePicker dtdesde;
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbloteria;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsorteo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbjugadas;
    }
}