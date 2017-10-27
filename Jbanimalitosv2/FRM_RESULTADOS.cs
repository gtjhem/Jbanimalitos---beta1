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
        public FRM_RESULTADOS()
        {
            InitializeComponent();
        }

        private void FRM_RESULTADOS_Load(object sender, EventArgs e)
        {
            CN.sr_llenar_loteria(ref cmbloteria, true);


            if (this.cmbloteria.Items.Count > 0)
            {
                this.cmbloteria.SelectedIndex = 0;
                string[] v = cmbloteria.Text.Split('-');
                sr_sorteos(int.Parse(v[1]));
            }

            sr_resultados();
        }

        public void sr_resultados ()
        {
            utilidades_reportes ur = new utilidades_reportes();

            ur.sr_llenar_resultados(ref this.dgr);
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
    }
}
