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

        private void dgr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(
               dgr.Rows[e.RowIndex].Cells[0].Value.ToString()
              , "Se guardo creo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (MessageBox.Show ("Desea revisar el ticket: " + 
                dgr.Rows[e.RowIndex].Cells[0].Value.ToString(), "Mensaje", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information ) == DialogResult.Yes)
            {
                frm_detalle  fd = new frm_detalle ();
                fd.ID_TICKET = long.Parse(dgr.Rows[e.RowIndex].Cells[0].Value.ToString()); //obtener ID ticket
                fd.vr_horario = dgr.Rows[e.RowIndex].Cells[2].Value.ToString();
                fd.vr_loteria = dgr.Rows[e.RowIndex].Cells[1].Value.ToString();
                fd.vr_fecha = dgr.Rows[e.RowIndex].Cells[7].Value.ToString();
                fd.vr_monto = float.Parse(dgr.Rows[e.RowIndex].Cells[3].Value.ToString());
                fd.vr_horas = dgr.Rows[e.RowIndex].Cells[8].Value.ToString();
                fd.ShowDialog();

            }
        }
    }
}
