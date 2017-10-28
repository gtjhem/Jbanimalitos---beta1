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
            ir_a_buscar();
        }

       
        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ir_a_buscar();

        }

        public void ir_a_buscar()
        {
            decimal? ttv = 0, ttp = 0, stt = 0, pven = 0, ttg = 0;
            //bsq.sr_buscar_totales(ref ttv, ref ttp, ref stt, dtdesde, dthasta);               
            bsq.sr_stp_totales(ref ttv, ref ttp, ref stt, dtdesde, dthasta);

            lbltotalventa.Text = Convert.ToDouble(ttv).ToString("###,##0.00");
            lbltotalapagar.Text = Convert.ToDouble(ttp).ToString("###,##0.00");
            lblsubtotal.Text = Convert.ToDouble(stt).ToString("###,##0.00");
            ttg = stt - pven;
            lbltotalgeneral.Text = Convert.ToDouble(ttg).ToString("###,##0.00");
        }

        private void frm_ganyper_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
