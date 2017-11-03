using System;

using System.Windows.Forms;

namespace Jbanimalitosv2
{
    public partial class FRM_BANCA : Form
    {
        public double? comi;
        public int? cadu;
        public double? mult;   


        Utilidades CN = new Utilidades();
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
            sr_llenar_impresoras(ref this.cmbimpresoras);

           

            this.txtnombreagencia.Text = MiBanca.nom_banca;
            this.txtpagarpor.Text = MiBanca.VR_MULTIPLICADOR.ToString();
            this.cmbcomision.Text = MiBanca.VR_COMISION.ToString() + "%";
            this.cmbtiempo.Text = MiBanca.VR_TIEMPO.ToString () + " - Dias";
            this.cmbimpresoras.Text = MiBanca.impresora;


        }
        public void sr_llenar_comision(ref ComboBox cmb)
        {
            for (int i = 0; i <= 100; i += 5 )
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

        public void sr_llenar_impresoras(ref ComboBox cmb)
        {
            string nombre_impresora;
            for (int i = 0; i < System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count; i++)
            {
                nombre_impresora = System.Drawing.Printing.PrinterSettings.InstalledPrinters[i];
                cmb.Items.Add(nombre_impresora);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (func_validar(ref msg) == true)
            {
                sr_convertir_variables();
                CN.sr_actualizar_BANCA(comi, cadu,mult, this.cmbimpresoras.Text.ToString(), this.txtnombreagencia.Text.ToString() );
                MessageBox.Show("Se actualizo la informacion de la Banca Correctamente", "Informacion Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MiBanca.sr_llenar();
                this.Close();
            }
            else
            {
                MessageBox.Show(msg, "Error al intentar Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void sr_convertir_variables()
        {
            comi = double.Parse (this.cmbcomision.Text.Replace("%", ""));
            string[] v = this.cmbtiempo.Text.Split('-');
            cadu = int.Parse(v[0]);
            mult = double.Parse(this.txtpagarpor.Text);
        }

        private Boolean  func_validar(ref string msg)
        {
            int cont = 0;
            if (this.txtnombreagencia.Text.Trim () == "")
            {
                cont += 1;
                msg = msg + cont + " - Debe Ingresar el Nombre de la Agencia" + Environment.NewLine;

            }

            if (this.txtpagarpor.Text == "")
            {
                cont += 1;
                msg = msg + cont + " - Debe ingresar el multiplicador de la ganancia" + Environment.NewLine;    
            }

            if (this.cmbtiempo.Text == "")
            {
                cont += 1;
                msg = msg + cont + " - Debe ingresar el tiempo en que el ticket pierde su validez" + Environment.NewLine;
            }

            if (this.cmbcomision.Text == ""){
                cont += 1;
                msg = msg + cont + " - Indique el porcentaje de Comision que se desea desde 0 - 100" + Environment.NewLine;
            }

            if (this.cmbimpresoras.Text == "")
            {
                cont += 1;
                msg = msg + cont + " - Indique el nombre de la impresora por donde se va a imprimir " + Environment.NewLine;

            }else if (this.cmbimpresoras.Text != ""){
                int x = 0;
                for (int i = 0; i < System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count; i++)
                {
                    if (this.cmbimpresoras.Text.Trim() == System.Drawing.Printing.PrinterSettings.InstalledPrinters[i])
                    {
                        x += 1;
                    }                        
                }

                if (x == 0)
                {
                    cont += 1;
                    msg = msg + cont + " - La impresora indicada no esta instalada cambie el nombre o seleccione uno de la lista" + Environment.NewLine;
                }

            }

            if (msg == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
