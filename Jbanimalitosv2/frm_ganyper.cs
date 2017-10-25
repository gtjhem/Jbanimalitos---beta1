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
    public partial class frm_ganyper : Form
    {

        Busquedas bsq = new Busquedas();
        utilidades_reportes  ur = new utilidades_reportes ();


        public frm_ganyper()
        {
            InitializeComponent();
        }

        private void frm_ganyper_Load(object sender, EventArgs e)
        {
            ur.Formatear_fechas(ref dtdesde); //formatea fecha desde 
            ur.Formatear_fechas(ref dthasta); //formatea fecha hasta
        }

       
        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            float ttv = 0, ttp = 0, stt = 0, pven = 0, ttg = 0;
            bsq.sr_buscar_totales(ref ttv, ref ttp, ref stt, dtdesde, dthasta);

            
            lbltotalventa.Text = ttv.ToString("###,##0.00");
            lbltotalapagar.Text = ttp.ToString("###,##0.00");
            lblsubtotal.Text = stt.ToString("###,##0.00");
            ttg = stt - pven;
            lbltotalgeneral.Text  = ttg.ToString("###,##0.00");
            
        }
    }
}
