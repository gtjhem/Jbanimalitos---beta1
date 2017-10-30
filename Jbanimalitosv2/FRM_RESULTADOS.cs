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
  
    public partial class FRM_RESULTADOS : Form
    {
        Utilidades CN = new Utilidades();
        private DateTime hoy;

        public FRM_RESULTADOS()
        {
            InitializeComponent();
        }

        private void FRM_RESULTADOS_Load(object sender, EventArgs e)
        {
            CN.sr_llenar_loteria(ref cmbloteria, true);

            hoy = DateTime.Now;
            sr_fecha();

            sr_cambiar_horarios(true);

            sr_resultados();
        }
        public void sr_fecha()
        {
            lbldia.Text = hoy.ToString("dd/MM/yyyy");
        }


        public void sr_cambiar_horarios(Boolean load)
        {
             
            if (this.cmbloteria.Items.Count > 0)
            {
                if (load == true) this.cmbloteria.SelectedIndex = 0;
                string[] v = cmbloteria.Text.Split('-');
                sr_sorteos(int.Parse(v[1]));
            }   
            
        }
        public void sr_resultados ()
        {
            utilidades_reportes ur = new utilidades_reportes();
            string[] v = cmbloteria.Text.Split('-');
            if (Convert.ToDateTime(hoy.ToString("dd/MM/yyyy")) != Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                CN.sr_resultados_del_dia_otros(Convert.ToDateTime(hoy.ToString("dd/MM/yyyy")));   // llama al STORE PROCEDURE para cargar los dias pendientes por incluir resultados

            ur.sr_llenar_resultados(ref this.dgr, int.Parse(v[1]), hoy);
        }

        public void sr_sorteos(int vr_key_codigo)
        {

            CN.sr_llenar_sorteos_resultados(ref lstSorteos, vr_key_codigo);

        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmbloteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] v = cmbloteria.Text.Split('-');

            sr_animalitos(int.Parse(v[1]));
            sr_resultados();
            sr_cambiar_horarios(false);
        }

        public void sr_animalitos(int vr_key_loteria)
        {

            CN.sr_llenar_animales(ref Animales, vr_key_loteria);

        }

        private void Animales_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (Animales.CheckedItems.Count == 1)
            {

                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = Animales.CheckedIndices[0];
                    Animales.ItemCheck -= Animales_ItemCheck;
                    Animales.SetItemChecked(checkedItemIndex, false);
                    Animales.ItemCheck += Animales_ItemCheck;
                }
              

                return;
            }
        }

        private void lstSorteos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstSorteos.CheckedItems.Count == 1)
            {

                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = lstSorteos.CheckedIndices[0];
                    lstSorteos.ItemCheck -= lstSorteos_ItemCheck;
                    lstSorteos.SetItemChecked(checkedItemIndex, false);
                    lstSorteos.ItemCheck += lstSorteos_ItemCheck;
                }

                return;
            }
        }

        private void Animales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] v;

            foreach (object itemChecked in Animales.CheckedItems) // obtengo el ID horario seleccionado 
            {

                v = itemChecked.ToString().Split('-');
                this.Nombre.Text = v[1];
                this.Numero.Text = v[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoy = hoy.AddDays(-1);
            sr_fecha();
            sr_resultados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hoy = hoy.AddDays(+1);
            sr_fecha();
            sr_resultados();
        }

        private void lbldia_DoubleClick(object sender, EventArgs e)
        {
            hoy = DateTime.Now;
            sr_fecha();
        }

        private void FRM_RESULTADOS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lbldia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hoy = DateTime.Now;
            sr_fecha();
            sr_resultados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string[] v = cmbloteria.Text.Split('-');
            int ids = 0;
            string b = "";
            obtener_sorteo(ref ids, ref b);

            if (MessageBox.Show("Desea cargar como ganador la siguiente jugada: " + this.Numero.Text.ToUpper () + " - " +
               this.Nombre.Text.ToUpper() + " Para la loteria " + v[0] + " en el sorteo de " + b, " EPA CUIDADO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand ) == DialogResult.Yes) {

                CN.sr_guardar_ganador(int.Parse(v[1]), ids ,hoy, this.Numero.Text );

                MessageBox.Show(
                    " El " + this.Nombre.Text  + " - " + this.Numero.Text  + "Fue Cargado para la loteria de "
                    + v[0] + " para el Sorteo de las " + b 
                   , "Resultado Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sr_resultados();
                sr_actualizar_ganador();
            }
        }

        public void  obtener_sorteo(ref int ids, ref string sorteohora)
        {
            string[] v;
            string x = "", b = "";
            
            foreach (object itemChecked in lstSorteos.CheckedItems) // obtengo el ID horario seleccionado 
            {

                v = itemChecked.ToString().Split('-');
                x = v[2];
                b = v[0];
               
            }


            ids = int.Parse(x);
            sorteohora = b;
        }

        public void sr_actualizar_ganador()
        {

          CN.sr_ganador(Convert.ToDateTime(hoy.ToString("dd/MM/yyyy")));
        }

    }
}
