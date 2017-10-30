namespace Jbanimalitosv2
{
    partial class frm_detalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.lbldetalleticket = new System.Windows.Forms.Label();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtloteria = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtfechor = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 436);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Controls.Add(this.lbldetalleticket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(21, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 58);
            this.panel2.TabIndex = 1;
            // 
            // Cerrar
            // 
            this.Cerrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(52)))));
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.Cerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cerrar.LinkColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(607, 0);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(27, 26);
            this.Cerrar.TabIndex = 19;
            this.Cerrar.TabStop = true;
            this.Cerrar.Text = "x";
            this.Cerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.Cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cerrar_LinkClicked);
            // 
            // lbldetalleticket
            // 
            this.lbldetalleticket.AutoSize = true;
            this.lbldetalleticket.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.lbldetalleticket.ForeColor = System.Drawing.Color.White;
            this.lbldetalleticket.Location = new System.Drawing.Point(13, 15);
            this.lbldetalleticket.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lbldetalleticket.Name = "lbldetalleticket";
            this.lbldetalleticket.Size = new System.Drawing.Size(148, 22);
            this.lbldetalleticket.TabIndex = 18;
            this.lbldetalleticket.Text = "Detalle Ticket";
            // 
            // dgr
            // 
            this.dgr.AllowUserToAddRows = false;
            this.dgr.AllowUserToDeleteRows = false;
            this.dgr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.dgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgr.Location = new System.Drawing.Point(24, 134);
            this.dgr.Margin = new System.Windows.Forms.Padding(0);
            this.dgr.Name = "dgr";
            this.dgr.ReadOnly = true;
            this.dgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr.Size = new System.Drawing.Size(622, 293);
            this.dgr.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(36, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Loteria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(351, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sorteo.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total...:";
            // 
            // txthorario
            // 
            this.txthorario.BackColor = System.Drawing.SystemColors.Window;
            this.txthorario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txthorario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txthorario.Location = new System.Drawing.Point(450, 64);
            this.txthorario.MaxLength = 0;
            this.txthorario.Multiline = true;
            this.txthorario.Name = "txthorario";
            this.txthorario.ReadOnly = true;
            this.txthorario.Size = new System.Drawing.Size(193, 27);
            this.txthorario.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(289, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha y Hora:";
            // 
            // txtloteria
            // 
            this.txtloteria.BackColor = System.Drawing.SystemColors.Window;
            this.txtloteria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtloteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtloteria.Location = new System.Drawing.Point(136, 62);
            this.txtloteria.MaxLength = 0;
            this.txtloteria.Multiline = true;
            this.txtloteria.Name = "txtloteria";
            this.txtloteria.ReadOnly = true;
            this.txtloteria.Size = new System.Drawing.Size(211, 27);
            this.txtloteria.TabIndex = 30;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Window;
            this.txttotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txttotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txttotal.Location = new System.Drawing.Point(136, 99);
            this.txttotal.MaxLength = 0;
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(140, 27);
            this.txttotal.TabIndex = 31;
            // 
            // txtfechor
            // 
            this.txtfechor.BackColor = System.Drawing.SystemColors.Window;
            this.txtfechor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtfechor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtfechor.Location = new System.Drawing.Point(450, 98);
            this.txtfechor.MaxLength = 0;
            this.txtfechor.Multiline = true;
            this.txtfechor.Name = "txtfechor";
            this.txtfechor.ReadOnly = true;
            this.txtfechor.Size = new System.Drawing.Size(193, 27);
            this.txtfechor.TabIndex = 32;
            // 
            // frm_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 436);
            this.Controls.Add(this.txtfechor);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtloteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_detalle";
            this.Load += new System.EventHandler(this.frm_detalle_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_detalle_KeyUp);
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
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtloteria;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtfechor;
    }
}