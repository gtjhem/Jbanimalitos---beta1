namespace Jbanimalitosv2
{
    partial class FRM_PAGAR
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
            this.lbldatosticket = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.NTicket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.lbldetalleticket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfechor = new System.Windows.Forms.TextBox();
            this.txtloteria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpremio = new System.Windows.Forms.TextBox();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldatosticket
            // 
            this.lbldatosticket.AutoSize = true;
            this.lbldatosticket.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.lbldatosticket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbldatosticket.Location = new System.Drawing.Point(44, 146);
            this.lbldatosticket.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lbldatosticket.Name = "lbldatosticket";
            this.lbldatosticket.Size = new System.Drawing.Size(214, 23);
            this.lbldatosticket.TabIndex = 64;
            this.lbldatosticket.Text = "Pagar el Ticket Nº:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(487, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 57);
            this.button1.TabIndex = 63;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(319, 73);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(162, 57);
            this.Buscar.TabIndex = 62;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // NTicket
            // 
            this.NTicket.BackColor = System.Drawing.SystemColors.Window;
            this.NTicket.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.NTicket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NTicket.Location = new System.Drawing.Point(141, 74);
            this.NTicket.MaxLength = 20;
            this.NTicket.Name = "NTicket";
            this.NTicket.Size = new System.Drawing.Size(163, 27);
            this.NTicket.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(41, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ticket:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Controls.Add(this.lbldetalleticket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(21, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 58);
            this.panel2.TabIndex = 50;
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
            // 
            // lbldetalleticket
            // 
            this.lbldetalleticket.AutoSize = true;
            this.lbldetalleticket.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.lbldetalleticket.ForeColor = System.Drawing.Color.White;
            this.lbldetalleticket.Location = new System.Drawing.Point(13, 15);
            this.lbldetalleticket.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.lbldetalleticket.Name = "lbldetalleticket";
            this.lbldetalleticket.Size = new System.Drawing.Size(136, 22);
            this.lbldetalleticket.TabIndex = 18;
            this.lbldetalleticket.Text = "Pagar Ticket";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 648);
            this.panel1.TabIndex = 49;
            // 
            // txtfechor
            // 
            this.txtfechor.BackColor = System.Drawing.SystemColors.Window;
            this.txtfechor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtfechor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtfechor.Location = new System.Drawing.Point(455, 220);
            this.txtfechor.MaxLength = 0;
            this.txtfechor.Multiline = true;
            this.txtfechor.Name = "txtfechor";
            this.txtfechor.ReadOnly = true;
            this.txtfechor.Size = new System.Drawing.Size(193, 27);
            this.txtfechor.TabIndex = 59;
            // 
            // txtloteria
            // 
            this.txtloteria.BackColor = System.Drawing.SystemColors.Window;
            this.txtloteria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtloteria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtloteria.Location = new System.Drawing.Point(141, 184);
            this.txtloteria.MaxLength = 0;
            this.txtloteria.Multiline = true;
            this.txtloteria.Name = "txtloteria";
            this.txtloteria.ReadOnly = true;
            this.txtloteria.Size = new System.Drawing.Size(211, 27);
            this.txtloteria.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(294, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha y Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Total...:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(356, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Sorteo.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(41, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Loteria:";
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
            this.dgr.Location = new System.Drawing.Point(33, 343);
            this.dgr.Margin = new System.Windows.Forms.Padding(0);
            this.dgr.Name = "dgr";
            this.dgr.ReadOnly = true;
            this.dgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr.Size = new System.Drawing.Size(622, 293);
            this.dgr.TabIndex = 51;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Window;
            this.txttotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txttotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txttotal.Location = new System.Drawing.Point(141, 221);
            this.txttotal.MaxLength = 0;
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(140, 27);
            this.txttotal.TabIndex = 58;
            // 
            // txthorario
            // 
            this.txthorario.BackColor = System.Drawing.SystemColors.Window;
            this.txthorario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txthorario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txthorario.Location = new System.Drawing.Point(455, 186);
            this.txthorario.MaxLength = 0;
            this.txthorario.Multiline = true;
            this.txthorario.Name = "txthorario";
            this.txthorario.ReadOnly = true;
            this.txthorario.Size = new System.Drawing.Size(193, 27);
            this.txthorario.TabIndex = 55;
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.SystemColors.Window;
            this.txtserial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtserial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtserial.Location = new System.Drawing.Point(141, 107);
            this.txtserial.MaxLength = 20;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(163, 27);
            this.txtserial.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(41, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Serial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(44, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "Monto Premio:";
            // 
            // txtpremio
            // 
            this.txtpremio.BackColor = System.Drawing.SystemColors.Window;
            this.txtpremio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtpremio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.txtpremio.Location = new System.Drawing.Point(218, 256);
            this.txtpremio.MaxLength = 0;
            this.txtpremio.Multiline = true;
            this.txtpremio.Name = "txtpremio";
            this.txtpremio.ReadOnly = true;
            this.txtpremio.Size = new System.Drawing.Size(234, 27);
            this.txtpremio.TabIndex = 68;
            // 
            // txtestatus
            // 
            this.txtestatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtestatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtestatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.txtestatus.Location = new System.Drawing.Point(218, 299);
            this.txtestatus.MaxLength = 0;
            this.txtestatus.Multiline = true;
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.ReadOnly = true;
            this.txtestatus.Size = new System.Drawing.Size(234, 27);
            this.txtestatus.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(44, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 69;
            this.label7.Text = "Estatus..........:";
            // 
            // FRM_PAGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 648);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpremio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldatosticket);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.NTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtfechor);
            this.Controls.Add(this.txtloteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txthorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PAGAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_PAGAR";
            this.Load += new System.EventHandler(this.FRM_PAGAR_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatosticket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox NTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label lbldetalleticket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfechor;
        private System.Windows.Forms.TextBox txtloteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpremio;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.Label label7;
    }
}