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
            string loteria = "", sorteo = "", fecha = "", hora = "";
            double? total = 0;

            CN.sr_buscar_ticket_para_anular(long.Parse(this.NTicket.Text.ToString()), ref loteria, ref sorteo,
                ref total, ref fecha, ref hora);
        }
    }


}
