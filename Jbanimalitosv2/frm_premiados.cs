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
    public partial class frm_premiados : Form
    {
        Utilidades CN = new Utilidades();
        utilidades_reportes ur = new utilidades_reportes();
        public frm_premiados()
        {
            InitializeComponent();
        }

        private void frm_premiados_Load(object sender, EventArgs e)
        {
            cmbloteria.Items.Add("TODOS");
            CN.sr_llenar_loteria(ref cmbloteria, false);
            this.cmbloteria.SelectedIndex = 0;

            ur.Formatear_fechas(ref dtdesde); //formatea fecha desde 
            ur.Formatear_fechas(ref dthasta); //formatea fecha hasta

            sr_buscar();
        }

        private void sr_buscar()
        {
            

           
                if (this.cmbloteria.Text == "TODOS") //Buscar en todas las loterias del dia 
                {
                    ur.sr_llenar_grid_pagados (ref this.dgr, this.dtdesde, this.dthasta); // llenar grid reportes

                }
                else if (this.cmbloteria.Text != "TODOS")// buscar por la loteria indicada
                {
                    ur.sr_llenar_grid_FILTRADO_pagados (ref this.dgr, this.dtdesde, this.dthasta, this.cmbloteria);

                }
            
          
            ur.sr_columnas_cambiar(ref this.dgr, "D");
            ur.sr_ganador_ticket(ref this.dgr, 6); // le indico la posicion donde esta la celda
            this.dgr.ClearSelection();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            sr_buscar();
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Desea revisar el ticket: " +
               dgr.Rows[e.RowIndex].Cells[0].Value.ToString(), "Mensaje",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frm_detalle fd = new frm_detalle();
                fd.ID_TICKET = long.Parse(dgr.Rows[e.RowIndex].Cells[0].Value.ToString()); //obtener ID ticket
                fd.vr_horario = dgr.Rows[e.RowIndex].Cells[2].Value.ToString();
                fd.vr_loteria = dgr.Rows[e.RowIndex].Cells[1].Value.ToString();
                fd.vr_fecha = dgr.Rows[e.RowIndex].Cells[7].Value.ToString();
                fd.vr_monto = float.Parse(dgr.Rows[e.RowIndex].Cells[3].Value.ToString());
                fd.vr_horas = dgr.Rows[e.RowIndex].Cells[8].Value.ToString();
                fd.ShowDialog();

            }
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frm_premiados_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}
