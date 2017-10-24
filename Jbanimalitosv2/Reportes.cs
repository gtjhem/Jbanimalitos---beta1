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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            utilidades_reportes ur = new utilidades_reportes();

            Formatear_fechas();

            ur.sr_llenar_grid(ref this.dgr , this.dtdesde, this.dthasta ); // llenar grid reportes
            ur.sr_columnas_cambiar(ref this.dgr, "V");

        }

        public void Formatear_fechas()
        {
            // Set the Format type and the CustomFormat string.
            dtdesde.Format = DateTimePickerFormat.Custom;
            dtdesde.CustomFormat = "dd/MM/yyyy";

            dthasta.Format = DateTimePickerFormat.Custom;
            dthasta.CustomFormat = "dd/MM/yyyy";

            dtdesde.Value = DateTime.Today;
            dthasta.Value = DateTime.Today;
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
