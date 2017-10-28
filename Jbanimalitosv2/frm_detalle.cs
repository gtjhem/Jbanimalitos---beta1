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
    public partial class frm_detalle : Form
    {
        public long ID_TICKET;
        public string vr_horario;
        public string vr_loteria;
        public float vr_monto;
        public string vr_fecha;
        public string vr_horas;

        public frm_detalle()
        {
            InitializeComponent();
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frm_detalle_Load(object sender, EventArgs e)
        {
            utilidades_reportes ur = new utilidades_reportes();

            lbldetalleticket.Text  = "Detalle Ticket N°: " +  ID_TICKET;
            txtloteria.Text = vr_loteria;
            txthorario.Text = vr_horario;

            txttotal.Text = vr_monto.ToString("###,##0.00");
            txtfechor.Text = vr_fecha.Substring(0,10) + " " + vr_horas.Substring(0,8).ToString ();

            ur.sr_llenar_grid_detalle(ref this.dgr, ID_TICKET);
            ur.sr_columnas_cambiar(ref this.dgr, "T");
            ur.sr_ganador_ticket(ref this.dgr, 5);
        }

        private void frm_detalle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
