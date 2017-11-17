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
    public partial class FRM_JUGADAS : Form
    {
        Utilidades CN = new Utilidades();
        utilidades_reportes ur = new utilidades_reportes();
        public FRM_JUGADAS()
        {
            InitializeComponent();
        }

        private void FRM_JUGADAS_Load(object sender, EventArgs e)
        {

            ur.Formatear_fechas(ref dtdesde); //formatea fecha desde 
            ur.Formatear_fechas(ref dthasta); //formatea fecha hasta
            CN.sr_llenar_loteria(ref cmbloteria, true);

            this.cmbloteria.SelectedIndex = 0;
        }

        private void cmbloteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] v = cmbloteria.Text.Split('-');

            sr_animalitos(int.Parse(v[1]));

            sr_sorteos(int.Parse(v[1]));

            if (this.cmbsorteo.Items.Count > 0)
            {                
                this.cmbsorteo.SelectedIndex = 0;
            }
        }

        public void sr_animalitos(int vr_key_loteria)
        {

            CN.sr_llenar_animales_cmb(ref this.cmbjugadas, vr_key_loteria);

        }

        public void sr_sorteos(int vr_key_codigo)
        {

            CN.sr_llenar_sorteos_cmb(ref this.cmbsorteo, vr_key_codigo);

        }

        public void sr_llenar()
        {
            string[] lt = cmbloteria.Text.Split('-');
            string[] sr = this.cmbsorteo.Text.Split('-');
            string[] an = this.cmbjugadas.Text.Split('-');
            DateTime desde, hasta;

            desde = dtdesde.Value;
            hasta = dthasta.Value;

            ur.sr_llenar_grid_jugadas(ref dgr, long.Parse(lt[1]), long.Parse(sr[2]), an[0], desde, hasta);
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            sr_llenar();
        }

    }
}
