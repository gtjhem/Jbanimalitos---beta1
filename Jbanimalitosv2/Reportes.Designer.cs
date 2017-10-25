namespace Jbanimalitosv2
{
    partial class Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dtdesde = new System.Windows.Forms.DateTimePicker();
            this.dthasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.lblloteria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbloteria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NTicket = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 492);
            this.panel1.TabIndex = 0;
            // 
            // dgr
            // 
            this.dgr.AllowUserToAddRows = false;
            this.dgr.AllowUserToDeleteRows = false;
            this.dgr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.dgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgr.Location = new System.Drawing.Point(22, 123);
            this.dgr.Margin = new System.Windows.Forms.Padding(0);
            this.dgr.Name = "dgr";
            this.dgr.ReadOnly = true;
            this.dgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr.Size = new System.Drawing.Size(933, 335);
            this.dgr.TabIndex = 1;
            this.dgr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(31, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Desde:";
            // 
            // dtdesde
            // 
            this.dtdesde.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtdesde.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtdesde.CustomFormat = "d, M, yyyy";
            this.dtdesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtdesde.Location = new System.Drawing.Point(121, 62);
            this.dtdesde.Name = "dtdesde";
            this.dtdesde.Size = new System.Drawing.Size(141, 21);
            this.dtdesde.TabIndex = 25;
            // 
            // dthasta
            // 
            this.dthasta.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dthasta.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dthasta.CustomFormat = "";
            this.dthasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.dthasta.Location = new System.Drawing.Point(373, 62);
            this.dthasta.Name = "dthasta";
            this.dthasta.Size = new System.Drawing.Size(141, 21);
            this.dthasta.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(275, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hasta:";
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(795, 64);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(160, 55);
            this.Buscar.TabIndex = 28;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
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
            this.panel2.TabIndex = 29;
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
            this.lblloteria.Location = new System.Drawing.Point(10, 15);
            this.lblloteria.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lblloteria.Name = "lblloteria";
            this.lblloteria.Size = new System.Drawing.Size(305, 32);
            this.lblloteria.TabIndex = 17;
            this.lblloteria.Text = "Reporte de Ventas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Loteria...:";
            // 
            // cmbloteria
            // 
            this.cmbloteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbloteria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbloteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbloteria.FormattingEnabled = true;
            this.cmbloteria.Location = new System.Drawing.Point(152, 94);
            this.cmbloteria.Name = "cmbloteria";
            this.cmbloteria.Size = new System.Drawing.Size(362, 26);
            this.cmbloteria.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(527, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ticket:";
            // 
            // NTicket
            // 
            this.NTicket.BackColor = System.Drawing.SystemColors.Window;
            this.NTicket.Enabled = false;
            this.NTicket.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.NTicket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NTicket.Location = new System.Drawing.Point(617, 92);
            this.NTicket.MaxLength = 20;
            this.NTicket.Name = "NTicket";
            this.NTicket.Size = new System.Drawing.Size(131, 27);
            this.NTicket.TabIndex = 33;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(959, 492);
            this.Controls.Add(this.NTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbloteria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtdesde);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtdesde;
        private System.Windows.Forms.DateTimePicker dthasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblloteria;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbloteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NTicket;
    }
}