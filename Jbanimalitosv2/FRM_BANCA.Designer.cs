namespace Jbanimalitosv2
{
    partial class FRM_BANCA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldetalleticket = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreagencia = new System.Windows.Forms.TextBox();
            this.txtpagarpor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbtiempo = new System.Windows.Forms.ComboBox();
            this.cmbcomision = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 349);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Controls.Add(this.lbldetalleticket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(14, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 48);
            this.panel2.TabIndex = 1;
            // 
            // lbldetalleticket
            // 
            this.lbldetalleticket.AutoSize = true;
            this.lbldetalleticket.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lbldetalleticket.ForeColor = System.Drawing.Color.White;
            this.lbldetalleticket.Location = new System.Drawing.Point(3, 9);
            this.lbldetalleticket.Margin = new System.Windows.Forms.Padding(0);
            this.lbldetalleticket.Name = "lbldetalleticket";
            this.lbldetalleticket.Size = new System.Drawing.Size(326, 32);
            this.lbldetalleticket.TabIndex = 20;
            this.lbldetalleticket.Text = "Configuracion Banca";
            // 
            // Cerrar
            // 
            this.Cerrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(52)))));
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.Cerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cerrar.LinkColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(566, 0);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(27, 26);
            this.Cerrar.TabIndex = 21;
            this.Cerrar.TabStop = true;
            this.Cerrar.Text = "x";
            this.Cerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.Cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cerrar_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(36, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nombre Agencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(36, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pagar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Caducidad de Tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(36, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Comision Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre Impresora:";
            // 
            // txtnombreagencia
            // 
            this.txtnombreagencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreagencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtnombreagencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.txtnombreagencia.Location = new System.Drawing.Point(292, 72);
            this.txtnombreagencia.MaxLength = 0;
            this.txtnombreagencia.Name = "txtnombreagencia";
            this.txtnombreagencia.Size = new System.Drawing.Size(282, 27);
            this.txtnombreagencia.TabIndex = 28;
            this.txtnombreagencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpagarpor
            // 
            this.txtpagarpor.BackColor = System.Drawing.SystemColors.Window;
            this.txtpagarpor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtpagarpor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.txtpagarpor.Location = new System.Drawing.Point(292, 109);
            this.txtpagarpor.MaxLength = 0;
            this.txtpagarpor.Name = "txtpagarpor";
            this.txtpagarpor.Size = new System.Drawing.Size(282, 27);
            this.txtpagarpor.TabIndex = 29;
            this.txtpagarpor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.textBox4.Location = new System.Drawing.Point(292, 227);
            this.textBox4.MaxLength = 0;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 27);
            this.textBox4.TabIndex = 32;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbtiempo
            // 
            this.cmbtiempo.DropDownHeight = 150;
            this.cmbtiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtiempo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbtiempo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbtiempo.FormattingEnabled = true;
            this.cmbtiempo.IntegralHeight = false;
            this.cmbtiempo.Location = new System.Drawing.Point(292, 151);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(282, 26);
            this.cmbtiempo.TabIndex = 33;
            // 
            // cmbcomision
            // 
            this.cmbcomision.DropDownHeight = 150;
            this.cmbcomision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcomision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcomision.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cmbcomision.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbcomision.FormattingEnabled = true;
            this.cmbcomision.IntegralHeight = false;
            this.cmbcomision.Location = new System.Drawing.Point(292, 190);
            this.cmbcomision.Name = "cmbcomision";
            this.cmbcomision.Size = new System.Drawing.Size(282, 26);
            this.cmbcomision.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(192, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 52);
            this.button3.TabIndex = 35;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FRM_BANCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbcomision);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtpagarpor);
            this.Controls.Add(this.txtnombreagencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BANCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_BANCA";
            this.Load += new System.EventHandler(this.FRM_BANCA_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbldetalleticket;
        private System.Windows.Forms.LinkLabel Cerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreagencia;
        private System.Windows.Forms.TextBox txtpagarpor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmbtiempo;
        private System.Windows.Forms.ComboBox cmbcomision;
        private System.Windows.Forms.Button button3;
    }
}