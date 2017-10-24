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
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDHORA  into fx
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx .Where(x => x.IDHORA == qrytickets.IDHRTK ).DefaultIfEmpty ()         
                       where qrytickets.FECHATQ >= desde.Value && qrytickets.FECHATQ <= hasta.Value 
                       select new
                       {
                           qrytickets.IDTICKET,
                           fgi.NOMBRE_SORTEO, fxi.HORA, qrytickets.TOTALPAGADO,
                           qrytickets.PREMIOS, qrytickets.DIFERENCIA,
                           qrytickets.ESTATUSTK, qrytickets.FECHATQ, qrytickets.HORATQ  }).ToList();

            // SELECT * FROM DBTICKET LEFTJOIN DBSORTEO ON IDSORTEOTK = ID_SORTEO LEFT JOIN DBHORARIO ON IDHRTK = IDSORTEOHR

            dgr.DataSource = query;


        }

        public void sr_columnas_cambiar(ref DataGridView dgr, string tipo)
        {

            dgr.Columns[0].HeaderText = "Ticket";
            dgr.Columns[1].HeaderText = "Loteria";
            dgr.Columns[2].HeaderText = "Horario";
            dgr.Columns[3].HeaderText = "Jugadas";
            dgr.Columns[4].HeaderText = "Premios";
            dgr.Columns[5].HeaderText = "Totales";
            dgr.Columns[6].HeaderText = "Estatus";
            dgr.Columns[7].HeaderText = "Fecha";
            dgr.Columns[8].HeaderText = "Hora";

            dgr.Columns[3].DefaultCellStyle.Format = "###,##0.00";
            dgr.Columns[4].DefaultCellStyle.Format = "###,##0.00";
            dgr.Columns[5].DefaultCellStyle.Format = "###,##0.00";
            dgr.Columns[8].DefaultCellStyle.Format = @"hh\:mm\:ss";




        }
    }
}
