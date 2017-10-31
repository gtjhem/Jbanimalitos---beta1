


using Jbanimalitosv2;
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
     

    public partial class INICIO : Form
    {
        Utilidades CN = new Utilidades();


        public INICIO()
        {
            InitializeComponent();
        }

        //
        // Declaraciones del API de Windows (y constantes usadas para mover el form)
        //
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;
        //
        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Form1_Load(object sender, EventArgs e)
        {

            sr_loteria();

            if (this.cmbloteria.Items.Count > 0){
                this.cmbloteria.SelectedIndex = 0;
                string[] v = cmbloteria.Text.Split('-');
                sr_sorteos(int.Parse(v[1]));
            }

            if (this.lstSorteos.Items.Count > 0 ){
                this.lstSorteos.SetItemChecked(0, true);
            }

            this.Animal.Focus();
            ver_ticket();
            sr_antiquiebre();
            CN.sr_resultados_del_dia(); // llama al STORE PROCEDURE para cargar los dias pendientes por incluir resultados
        }

         public void sr_sorteos (int vr_key_codigo)
        {

            CN.sr_llenar_sorteos(ref lstSorteos, vr_key_codigo);            

        }
        public void sr_loteria()
        {
           
            CN.sr_llenar_loteria(ref cmbloteria, true );
        }

        public void sr_animalitos(int vr_key_loteria)
        {

            CN.sr_llenar_animales(ref Animales, vr_key_loteria);
                    
        }


        private void Minz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close ();
        }

        private void Relog_Tick(object sender, EventArgs e)
        {
            this.Hora.Text = DateTime.Now.ToString("G");
            
        }
        private void ver_ticket()
        {
            this.NTicket.Text = CN.sr_ticket().ToString();
        }

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sr_agregar();
                   }

        public void sr_agregar() {

            string msg = "";

            msg = validar();

            ver_ticket();

            if (msg == "")
            {
                if (Ticket.Items.Count <= 0)
                {

                    foreach (object itemChecked in lstSorteos.CheckedItems) // obtengo el valor seleccionado 
                    {
                        this.Ticket.Items.Add(itemChecked.ToString());
                    }

                }

                if (Animales.CheckedItems.Count > 0)
                {
                    this.Animal.Text = "";
                    this.Nombre.Text = "";
                    
                    foreach (object seleccionados in Animales.CheckedItems)
                    {
                        this.Ticket.Items.Add(seleccionados.ToString() + " - " + this.Monto.Text);
                    }
                }
                else
                {
                    this.Ticket.Items.Add(this.Animal.Text + " - " + this.Nombre.Text + " - " + this.Monto.Text);
                    
                }

                this.Animal.Text = "";
                this.Nombre.Text = "";
                this.Monto.Text = "";
                Calcular();
                deseleccionar();
            }
            else
            {
                MessageBox.Show(msg, "Faltan Campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public void sr_antiquiebre()
        {
            DateTime desde, hasta;


            int IDH = 0, IDS = 0;

            string[] v;
            foreach (object itemChecked in lstSorteos.CheckedItems) // obtengo el ID horario seleccionado 
            { 
                v = itemChecked.ToString().Split('-');
                IDH = int.Parse(v[2]);
            }

            v = cmbloteria.Text.Split('-'); // obtengo el ID SORTEO
            IDS = int.Parse(v[1]);
            
        
            desde = DateTime.Today;
            hasta = DateTime.Today;

            Antiquiebre ATQ = new Antiquiebre();
            ATQ.sr_anti_quiebre(desde, hasta, ref this.AntiQuiebre, IDS, IDH );
        }
        public void deseleccionar ()
        {
            for (int i = 0; i < Animales.Items.Count; i++)
                Animales.SetItemCheckState(i, (false  ? CheckState.Checked : CheckState.Unchecked));
        }

        public string validar()
        {
            string msg = "";
            int cont = 0;

            if (Animales.CheckedItems.Count > 0 )
            {

                if (this.Monto.Text == "") {
                    cont += 1;
                    msg = msg + " Debe Ingresar el monto " + Environment.NewLine;
                }
             
            }
            else
            {
                if (this.Animal.Text == "")
                {
                    cont += 1;
                    msg = msg + " Indique el numero de la jugada" + Environment.NewLine;
                }
                
                if (this.Monto.Text == "")
                {
                    cont += 1;
                    msg = msg + " Indique el monto de la jugada" + Environment.NewLine;
                    this.Monto.Focus();
                }
            }


            if (lstSorteos.CheckedItems.Count == 0) {

                cont += 1;
                msg = msg + " Selecciona la hora del Sorteo" + Environment.NewLine;
            }
            

            

            return msg;

            
        }

        public void Calcular()
        {
            int vrtotal;
            string[] Matriz = new string[Ticket.Items.Count];
            vrtotal = 0;
            for (int i = 1; i < Ticket.Items.Count; i++) { 
                Matriz[i] = Ticket.Items[i].ToString();
                string[] picados = Ticket.Items[i].ToString().Split('-');
                vrtotal = vrtotal + int.Parse(picados[2]);
            }
            this.Total.Text = vrtotal.ToString ();
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == '\r')

                {
                    this.Animal.Focus();
                    e.Handled = true;

                }else{
                    e.Handled = false;
                }
                
            }
            //SI lo activas permite usar el espacio
            //else if (Char.IsSeparator(e.KeyChar))
            //{
             //   e.Handled = false;
            //}
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
               
                sr_agregar();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Ticket.SelectedIndex > -1  && this.Ticket.SelectedIndex != 0)
            {
                this.Ticket.Items.RemoveAt(this.Ticket.SelectedIndex);
            }
            Calcular();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Ticket.Items.Clear();
            Calcular();
        }
        

        private void Animales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Animal.Text = "";
            this.Nombre.Text = "";
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

                // Indica que sorteo es en el ticket
                if (Ticket.Items.Count > 0)
                {
                    if (Ticket.Items[0].ToString() != "")
                    {
                        Ticket.Items.RemoveAt(0);
                        Ticket.Items.Insert(0, lstSorteos.SelectedItem);
                        

                    }
                }
                
                return;
            }

        }

        private void cmbloteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //private string[] v;

            string [] v = cmbloteria.Text.Split('-');

            sr_animalitos( int.Parse(v[1]));

            sr_sorteos(int.Parse(v[1]));

            if (this.lstSorteos.Items.Count > 0)
            {
                this.lstSorteos.SetItemChecked(0, true);
            }
            sr_antiquiebre();


        }

        private void Animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == '\r')

                {
                    this.Monto.Focus();
                    e.Handled = true;

                }else
                {
                    e.Handled = false;
                }
            }
            //SI lo activas permite usar el espacio
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //   e.Handled = false;
            //}
            else
            {
                e.Handled = true;
            }

        }

        public void sr_nombre_Animalito(string vr_key_codigo, int vr_key_sorteo)
        {
            CN.sr_nombre_animalitos(ref this.Nombre , vr_key_sorteo, vr_key_codigo );
            
           if (this.Nombre.Text  == "" && this.Animal.Text != ""){
                MessageBox.Show(
                    "El Numero: " + this.Animal.Text  + " No Existe Intente con otro..."
                    , "Error en el numero de la jugada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Animal_TextChanged(object sender, EventArgs e)
        {
            
            string[] v = cmbloteria.Text.Split('-');
            sr_nombre_Animalito(Animal.Text.ToString(), int.Parse(v[1]));
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

            sr_iniciar_impresion();
        }

        private void sr_iniciar_impresion()
        {
            Calcular();
            if (this.Total.Text != "0" )
            {
                CN.sr_guardar_ticket(ref this.Ticket, ref this.Total, ref this.cmbloteria);


                //Rutina para imprimir falta realizar ajustes de alineacion  
                //sr_imprimir();

                MessageBox.Show(
                   " Ticket Impreso: " + this.NTicket.Text + " " + Environment.NewLine +
                   " - - - - - - - - - - - - - - - - -" + Environment.NewLine +
                   CN.func_linea(ref this.Ticket) +
                   " - - - - - - - - - - - - - - - - -" +
                   this.Total.Text
                  , "Impresion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ver_ticket();
                sr_antiquiebre();
                this.Ticket.Items.Clear();
                this.Animal.Focus();
                this.Monto.Text = "";
                this.Total.Text = "";
                Calcular();
                deseleccionar();
            }
            else
            {
                MessageBox.Show(
                   " No hay Jugada seleccionada para este Ticket " + Environment.NewLine                    
                  , "Error al Intentar imprimir un ticket vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        


        private void sr_imprimir()
        {
            KeyCreator empezar = new KeyCreator();
            TicketCS Tk = new TicketCS();

            string ser = "";
            // serial 
            ser = DateTime.Now.ToLongTimeString().ToString().Substring(0, 2) +
                DateTime.Now.ToLongTimeString().ToString().Substring(3, 2) +
                DateTime.Now.ToLongTimeString().ToString().Substring(6, 2) +
                empezar.Sertkt(6);


            //ver_ticket();

            Tk.OpenBoxCash();
            Tk.TextoCentrado("CATIA LA MAR LOTERIA");
            Tk.TextoCentrado("RIF: ");
            Tk.TextoCentrado("Direccion: ");
            Tk.TextoAlaDerecha("Local Principal");
            Tk.TextoAlaDerecha("Telfs: ");
            Tk.TextoAlaIzquierda("Emails: ");
            Tk.LineasPunteadas();
            Tk.TextoExtremos("Caja # 1", "Ticket-Boleta: # ");
            Tk.LineasPunteadas();
            Tk.TextoAlaIzquierda("Le Atendio: Jhembell Baderna");
            Tk.TextoAlaIzquierda("Cliente: Publico General");
            Tk.LineasPunteadas();
            Tk.TextoCentrado("Datos de Emision");
            Tk.TextoExtremos("Fecha: " + DateTime.Now.ToShortDateString(), "Hora: " + DateTime.Now.ToShortTimeString());
            Tk.LineasPunteadas();
            Tk.CabezeraVenta();
            Tk.LineasPunteadas();
            Tk.AgregarArticulos("Tu Love mas nada Chiquito", 10, 15, 150);
            Tk.AgregarArticulos("Tu Love mas nada Chiquito", 10, 15, 150);
            Tk.AgregarArticulos("Tu Love mas nada Chiquito", 10, 15, 150);
            Tk.AgregarArticulos("Tu Love mas nada Chiquito mas na es un papi cuando logres hacer esta pendejada master", 10, 15, 150);
            Tk.AgregarSubTotales("", 0);
            Tk.AgregarSubTotales("SUB-TOTAL: ", 2400);
            Tk.AgregarSubTotales("      IGV: ", 24.05M);
            Tk.AgregarSubTotales("    TOTAL: ", 2424.05M);
            Tk.TextoAlaDerecha("");
            Tk.AgregarSubTotales(" PAGO CON: ", 1500);
            Tk.AgregarSubTotales("    TOTAL: ", 850.5M);
            Tk.LineasIgualdad();
            Tk.TextoCentrado("SU TICKET CADUCA A LOS 3 DIAS");
            Tk.TextoCentrado("SIN TICKET NO SE COBRA");
            Tk.TextoCentrado("REVISE SU TICKET NO SE REALIZA DEV");
            Tk.TextoCentrado("GRACIAS POR SU COMPRA VUELVA PRONTO");
            Tk.CortaCinta();
            //Tk.PrintTicket("Microsoft Office Document Image Writer");
            Tk.PrintTicket("POS58(copy of 1)");

        }

        private void Ir_REPORTES_VENTAS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Reportes  f = new Reportes();
            f.ShowDialog();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frm_premiados  f = new frm_premiados ();
            f.ShowDialog();
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frm_ganyper f = new frm_ganyper();
            f.ShowDialog();
            

        }

        private void lstSorteos_SelectedIndexChanged(object sender, EventArgs e)
        {
            sr_antiquiebre();
        }

      

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_RESULTADOS f = new FRM_RESULTADOS();
            f.ShowDialog();
        }
    }
}
