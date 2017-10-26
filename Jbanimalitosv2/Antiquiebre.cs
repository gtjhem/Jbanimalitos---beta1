using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jbanimalitosv2
{
    class Antiquiebre
    {
        Utilidades CN = new Utilidades();
        public void sr_anti_quiebre(DateTime  desde, DateTime hasta, ref  ListBox lst, int IDS, int IDH)
        {

            lst.Items.Clear();
              animalitos db = new animalitos(CN.CONEC);
            var query = (from TBL_DTICKET in db.dbdtickets
                         join TBL_TICKET in db.dbtickets on new { IDTICKETDTR = Convert.ToInt64(TBL_DTICKET.IDTICKETDTR) } equals new { IDTICKETDTR = TBL_TICKET.IDTICKET } into TBL_TICKET_join
                         from TBL_TICKET in TBL_TICKET_join.DefaultIfEmpty()
                         where
                          TBL_DTICKET.FECHADTK >= desde &&
                          TBL_DTICKET.FECHADTK <= hasta &&
                           TBL_TICKET.IDSORTEOTK == IDS &&
                           TBL_TICKET.IDHRTK == IDH
                         group new { TBL_TICKET, TBL_DTICKET } by new
                         {
                             TBL_TICKET.IDSORTEOTK,
                             TBL_TICKET.IDHRTK,
                             TBL_DTICKET.CODIGODTK
                         } into g
                         orderby
                           (double?)g.Sum(p => p.TBL_DTICKET.MONTO) descending
                         select new
                         {
                             IDSORTEOTK = (int?)g.Key.IDSORTEOTK,
                             IDHRTK = (int?)g.Key.IDHRTK,
                             g.Key.CODIGODTK,
                             conteo = g.Count(p => p.TBL_DTICKET.CODIGODTK != null),
                             TOTAL = (double?)g.Sum(p => p.TBL_DTICKET.MONTO)
                         }).ToList();

            string nombre = "";
            double? total = 0;
            foreach (var anti in query){
                total = 0;
                nombre_animal(ref nombre, anti.CODIGODTK, anti.IDSORTEOTK );

                total = anti.TOTAL * 30;
                lst.Items.Add(anti.CODIGODTK.ToString () + " - " + nombre
                    + " - " + anti.conteo + " - " + Convert.ToDouble(total).ToString("###,##0.00"));

            }
        }

        public void nombre_animal(ref string nombre,string animal, int? IDS)
        {
            animalitos db = new animalitos(CN.CONEC);

            var query = (from qryanimalito in db.dbanimalitos
                         where qryanimalito.IDSORTEOAN == IDS && qryanimalito.CODIGO == animal
                         select new { qryanimalito.CODIGO, qryanimalito.NOMBRE_ANIMALITO }).ToList();

            nombre = "";

            foreach (var aqui in query)
                nombre = aqui.NOMBRE_ANIMALITO.ToString();




        }
    }
}
