﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jbanimalitosv2
{
    public partial class FRM_ANULA : Form
    {
        public long ticket;
        public string vr_estatus;

        Utilidades CN = new Utilidades();
        public FRM_ANULA()
        {
            InitializeComponent();
        }

        private void FRM_ANULA_Load(object sender, EventArgs e)
        {

            this.button1.Enabled = false;
            this.button1.Visible = false;
        }

        private void sr_llenar()
        {
            utilidades_reportes ur = new utilidades_reportes();
            ur.sr_llenar_grid_detalle(ref this.dgr, long.Parse(this.NTicket.Text.ToString()));
            ur.sr_columnas_cambiar(ref this.dgr, "T");
            ur.sr_ganador_ticket(ref this.dgr, 5);
            this.dgr.ClearSelection();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
           
            string loteria = "", sorteo = "", fecha = "", hora = "", estatus = "";
            double ? total = 0;

            CN.sr_buscar_ticket_para_anular(long.Parse(this.NTicket.Text.ToString()), ref loteria, ref sorteo,
                ref total, ref fecha, ref hora, ref estatus );

            if (loteria != "")
            {
                ticket = long.Parse(this.NTicket.Text.ToString());
                vr_estatus = estatus;
                this.lbldatosticket.Text = "Anular el Ticket Nº: " + NTicket.Text.ToString();
                this.txtloteria.Text = loteria;
                double t = 0;
                t = Convert.ToDouble(total);
                this.txttotal.Text = t.ToString("###,##0.00");
                this.txthorario.Text = sorteo;
                this.txtfechor.Text = fecha.Substring(0, 10) + " " + hora.Substring(0, 8).ToString();
                this.button1.Enabled = true;
                this.button1.Visible = true;

                sr_llenar();

            }
            else
            {
                ticket = 0;
                vr_estatus = "";
                this.lbldatosticket.Text = "Anular el Ticket Nº:";
                this.txtloteria.Text = "";
                this.txttotal.Text = "";
                this.txthorario.Text = "";
                this.txtfechor.Text = "";
                this.button1.Enabled = false;
                this.button1.Visible = false;
                this.dgr.DataSource = null;
            }

            
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (func_validar(ref msg ) == true)
            {
                CN.sr_anular_ticket(ticket);
                MessageBox.Show("El Ticket Nº:" + ticket + Environment.NewLine 
                    + "Se ha anulado Correctamente"
                    , "Anulacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(msg, "Errores al intentar anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean func_validar (ref string msg)
        {


            int cont = 0;

            if (this.txtfechor.Text != "")
            {

                string[] v = this.txtfechor.Text.Split(' ');
                DateTime hoy = DateTime.Now;
                DateTime Ticket = DateTime.Parse(v[0] + " " + v[1]);
                TimeSpan diferencias = hoy.Subtract(Ticket);

                if (diferencias.TotalMinutes > 10)
                {
                    cont += 1;
                    msg = msg + " " + cont + " - No se puede anular un ticket que tiene mas de 10 minutos de emitido" + Environment.NewLine;
                }
            }

            if (ticket == 0) // validacion de seguridad
            {
                cont += 1;
                msg = msg + " " + cont + " - El numero de ticket ha cambiado o no se ha buscado, busque nuevamente antes de intentar anular otra vez" + Environment.NewLine;

            }

            if (ticket != 0)
            {
                if (vr_estatus != "")
                {
                    var TAGESTATUS = new string[] { "PAGADO", "ANULADO MANUAL", "PENDIENTE POR PAGAR" };
                    if ( TAGESTATUS.Contains(vr_estatus))
                    {
                        cont += 1;
                        msg = msg + " " + cont + " - No se puede anular ticket con estatus PAGADO, ANULADO MANUAL ó PENDIENTE POR PAGAR" + Environment.NewLine;
                    }
                }
            }

            if (msg == "") {
                return true;
            }
            else
            {
                return false;
            }

             
        }
    }
}
