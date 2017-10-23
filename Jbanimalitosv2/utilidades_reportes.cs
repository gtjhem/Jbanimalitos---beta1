using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jbanimalitosv2
{
    class utilidades_reportes
    {

        Utilidades CN = new Utilidades();
        public void sr_llenar_grid(ref DataGridView dgr,  DateTimePicker desde,  DateTimePicker hasta) {

            animalitos db = new animalitos(CN.CONEC);
            dgr.Rows.Clear();
            var query = (from qrytickets in db.dbtickets
                         join qrysorteo in db.dbSorteos on qrytickets.IDSORTEOTK equals qrysorteo.ID_SORTEO into fg
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDSORTEOHR into fx
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx .Where(x => x.IDHORA == qrytickets.IDHRTK ).DefaultIfEmpty ()         
                       where qrytickets.FECHA >= desde.Value && qrytickets.FECHA <= hasta.Value 
                       select new { fgi.NOMBRE_SORTEO, fxi.HORA, qrytickets.IDTICKET,
                           qrytickets.TOTALPAGADO, qrytickets.PREMIOS, qrytickets.ESTATUSTK  }).ToList();

            // SELECT * FROM DBTICKET LEFTJOIN DBSORTEO ON IDSORTEOTK = ID_SORTEO LEFT JOIN DBHORARIO ON IDHRTK = IDSORTEOHR

            dgr.DataSource = query;


        }
    }
}
