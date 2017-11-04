using System;
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
    public partial class FRM_PAGAR : Form
    {
        public long vr_ticket; // ticket buscado
        public string vr_serial; // serial buscado

        Utilidades CN = new Utilidades();
        public FRM_PAGAR()
        {
            InitializeComponent();
        }

        private void FRM_PAGAR_Load(object sender, EventArgs e)
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
            double? total = 0 , premio = 0;

            CN.sr_buscar_ticket_para_pagar(long.Parse(this.NTicket.Text.ToString()) , this.txtserial.Text.ToString(),
                ref loteria, ref sorteo,
                ref total, ref fecha, ref hora, ref premio, ref estatus); // ir a buscar el ticket a pagar


            if (loteria != "")
            {
                double t = 0, p = 0;
                t = Convert.ToDouble(total);
                p = Convert.ToDouble(premio);

                vr_serial = this.txtserial.Text.Trim();
                vr_ticket = long.Parse(this.NTicket.Text.ToString());
                this.txtloteria.Text = loteria;
                this.txttotal.Text = t.ToString("###,##0.00");

                this.txtfechor.Text = fecha.Substring(0, 10) + " " + hora.Substring(0, 8).ToString();
                this.txthorario.Text = sorteo;
                this.txtestatus.Text = estatus;
                this.txtpremio.Text = p.ToString("###,##0.00");
                
                if (t == 0 && this.txtestatus.Text.Trim() != "PENDIENTE POR PAGAR")
                {
                    sr_inhabilito();

                }else if (t > 0 && this.txtestatus.Text.Trim() == "PENDIENTE POR PAGAR")
                {
                    sr_habilito(); // desbloquea boton de pagar
                }
                else
                {
                    sr_inhabilito();
                }

                sr_llenar();

            }
            else
            {
                vr_ticket = 0;
                vr_serial = "";
                this.txtloteria.Text = "";
                this.txttotal.Text = "";

                this.txtfechor.Text = "";
                this.txthorario.Text = "";
                this.txtestatus.Text = "";
                this.txtpremio.Text = "";
                sr_inhabilito(); // bloquea el boton de pagar
            }
        }

        private void sr_habilito()
        {
            this.button1.Enabled = true;
            this.button1.Visible = true;
        }

        private void sr_inhabilito()
        {
            this.button1.Enabled = false;
            this.button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (func_validar(ref msg ) == true ) { 
            CN.sr_pagar_ticket(vr_ticket, vr_serial);
            MessageBox.Show("El Ticket Nº:" + vr_ticket + Environment.NewLine
                     + "Identificado con el Serial: " + vr_serial.ToUpper()  + Environment.NewLine
                    + "Se ha pagado Correctamente"
                    , "Ticket pagado ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            }
            else
            {
                MessageBox.Show(msg, "Errores al intentar Pagar ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } 


        }

        private Boolean func_validar(ref string msg)
        {


            int cont = 0;

            if (this.txtfechor.Text != "")
            {

                string[] v = this.txtfechor.Text.Split(' ');
                DateTime hoy = DateTime.Now;
                DateTime Ticket = DateTime.Parse(v[0] + " " + v[1]);
                TimeSpan diferencias = hoy.Subtract(Ticket);

                if (diferencias.Days > MiBanca.VR_TIEMPO)
                {
                    cont += 1;
                    msg = msg + " " + cont + " - No se puede anular un ticket que tiene mas de " + MiBanca.VR_TIEMPO  + " dias de emitido" + Environment.NewLine;
                }
            }

            if (vr_ticket  == 0) // validacion de seguridad
            {
                cont += 1;
                msg = msg + " " + cont + " - El numero de ticket ha cambiado o no se ha buscado, busque nuevamente antes de intentar pagar el ticket" + Environment.NewLine;

            }

            if (vr_serial == "")
            {
                cont += 1;
                msg = msg + " " + cont + " - El numero de serial ha cambiado o no se ha buscado, busque nuevamente antes de intentar pagar el ticket" + Environment.NewLine;
            }

            if (msg == "")
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }


}
