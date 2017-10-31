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
    public partial class FRM_BANCA : Form
    {
        public FRM_BANCA()
        {
            InitializeComponent();
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void FRM_BANCA_Load(object sender, EventArgs e)
        {

            

            sr_llenar_comision(ref this.cmbcomision);
            sr_llenar_caducidad(ref this.cmbtiempo);

            this.txtnombreagencia.Text = MiBanca.nom_banca;
            this.txtpagarpor.Text = MiBanca.VR_MULTIPLICADOR.ToString();
            this.cmbcomision.Text = MiBanca.VR_COMISION.ToString() + "%";
            
        }
        public void sr_llenar_comision(ref ComboBox cmb)
        {
            for (int i = 5; i <= 100; i += 5 )
            {
                cmb.Items.Add(i + "%");
            }
        }

        public void sr_llenar_caducidad(ref ComboBox cmb)
        {
            for (int i = 3; i <= 15; i ++)
            {
                cmb.Items.Add(i + " - Dias");
            }
        }
    }
}
