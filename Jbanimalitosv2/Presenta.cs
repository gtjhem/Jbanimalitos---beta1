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
    public partial class Presenta : Form
    {
        public Presenta()
        {
            InitializeComponent();
        }

        Boolean yaconecto;
        long segundos;
        Utilidades Cn = new Utilidades();
        private void Presenta_Load(object sender, EventArgs e)
        {
            tcont.Start();
            yaconecto = false;
        }

        private void tcont_Tick(object sender, EventArgs e)
        {
            barra.Width += 5;
            if (yaconecto == false) { 
                if (Cn.func_conexion() == false )
                {
                    barra.Width -= 5;
                }else
                {
                    yaconecto = true;
                }
            }

            if (barra.Width >= pgrb.Width){
                this.Hide();
                
                INICIO ini = new INICIO();
                ini.Show();
                
                tcont.Enabled = false;
            }

            segundos += 1;


            if (segundos == 240)
            {
                Application.Exit();
            }
        }


        public void ir_a_Cerrarme()
        {
            this.Close();
        }

        private void Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
              "Error al iniciar la BD, es posible que la BD este ocupado o el equipo no poseea suficiente memoria " 
             , "Error al iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        

    }
}
