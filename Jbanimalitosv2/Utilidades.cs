using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Jbanimalitosv2
{
    class Utilidades 
    {
        
                public string CONEC =  System.Configuration.ConfigurationManager.ConnectionStrings["CNX"].ConnectionString;

        
        private   CheckedListBox  CLB = new CheckedListBox();

        public void sr_llenar_sorteos  (ref CheckedListBox CLB, int vr_key_codigo)
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         join qryhorario in db.dbhorarios on qrysorteos.ID_SORTEO equals qryhorario.IDSORTEOHR
                         where qrysorteos.ESTATUS == "A" && qrysorteos.ID_SORTEO == vr_key_codigo
                         select new { qryhorario.HORA, qrysorteos.NOMBRE_SORTEO, qrysorteos.ID_SORTEO }).ToList();


            CLB.Items.Clear();
            foreach (var aqui in query)

                if (aqui.HORA <= DateTime.Now.TimeOfDay)
                {

                    CLB.Items.Add(aqui.HORA + " - " + aqui.NOMBRE_SORTEO.ToString().ToUpper() + " - " + aqui.ID_SORTEO);
                }        
                                    
        }

        private ComboBox cmb = new ComboBox();
        public void sr_llenar_loteria (ref ComboBox CMB)
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         where qrysorteos.ESTATUS == "A"
                         select new { qrysorteos.NOMBRE_SORTEO, qrysorteos.ID_SORTEO }).ToList();


            CMB.Items.Clear();

            foreach (var aqui in query)

                CMB.Items.Add(aqui.NOMBRE_SORTEO.ToString().ToUpper() + " - " + aqui.ID_SORTEO);
        }
        
        public void sr_llenar_animales(ref CheckedListBox CLB, int vr_key_loteria)
        {
            animalitos db = new animalitos(CONEC);


            var query = (from qryanimalito in db.dbanimalitos
                         where qryanimalito.IDSORTEOAN == vr_key_loteria

                         select new { qryanimalito.CODIGO, qryanimalito.NOMBRE_ANIMALITO }).ToList();


            CLB.Items.Clear();

            foreach (var aqui in query)
                CLB.Items.Add(aqui.CODIGO.ToString() + " - " + aqui.NOMBRE_ANIMALITO.ToString());
        }
        
        public int sr_ticket()
        {
            
            animalitos db = new animalitos(CONEC);

             var query = db.dbtickets.Max(d => d.IDTICKET);

            return query + 1;
        }

        public void sr_nombre_animalitos (ref TextBox TXT, int vr_key_sorteo, string vr_key_codigo )
        {
            animalitos db = new animalitos(CONEC);

            var query = (from qryanimalito in db.dbanimalitos
                         where qryanimalito.IDSORTEOAN == vr_key_sorteo && qryanimalito.CODIGO == vr_key_codigo
                         select new { qryanimalito.CODIGO, qryanimalito.NOMBRE_ANIMALITO }).ToList();
            
            TXT.Text = "";

            foreach (var aqui in query)
                TXT.Text = aqui.NOMBRE_ANIMALITO.ToString();                   

        }
        
        public void sr_guardar_ticket(ref ListBox lxb, ref TextBox ttl, ref ComboBox ltr, ref CheckedListBox hrr)
        {
            using (animalitos db = new animalitos(CONEC))
            {

                TBL_TICKET ing = new TBL_TICKET(); //clase para ingresar en TBL_TICKET
                KeyCreator empezar = new KeyCreator(); // clase para generar seriales

                string ser = "";
                // serial 
                ser = DateTime.Now.ToLongTimeString().ToString().Substring(0, 2) +
                    DateTime.Now.ToLongTimeString().ToString().Substring(3, 2) +
                    DateTime.Now.ToLongTimeString().ToString().Substring(6, 2) +
                    empezar.Sertkt(6);

                ing.TOTALPAGADO = float.Parse (ttl.Text);
                ing.IDHRTK = 0;
                
                ing.SERIAL = ser;
                ing.JUGADAS = lxb.Items.Count - 1;

                sr_Detalle(ref lxb);               

            }            
        }

        public void sr_Detalle(ref ListBox rlxb)
        {
            Detalles_animales DA = new Detalles_animales();

            int x = 0;

            for (x = 1; x <= rlxb.Items.Count; x++)
            {

                string[] v = rlxb.Items[x].ToString().Split('-');
                Dtsanimal dts = new Dtsanimal(v[0], v[1], float.Parse(v[2]));
                DA[x] = dts;
            }


        }



    }
}
