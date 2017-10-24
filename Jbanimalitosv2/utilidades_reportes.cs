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
                         join qryestatus in db.dbestatus on qrytickets.ESTATUSTK equals qryestatus.CODESTATUS into fe
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx .Where(x => x.IDHORA == qrytickets.IDHRTK ).DefaultIfEmpty ()
                         from fed in fe.Where (n => n.CODESTATUS == qrytickets.ESTATUSTK).DefaultIfEmpty ()
                            
                       where qrytickets.FECHATQ >= desde.Value && qrytickets.FECHATQ <= hasta.Value 

                       select new
                       {
                           qrytickets.IDTICKET,
                           fgi.NOMBRE_SORTEO, fxi.HORA, qrytickets.TOTALPAGADO,
                           qrytickets.PREMIOS, qrytickets.DIFERENCIA,
                           fed.NOMESTATUS , qrytickets.FECHATQ, qrytickets.HORATQ  }).ToList();

            // SELECT * FROM DBTICKET LEFTJOIN DBSORTEO ON IDSORTEOTK = ID_SORTEO LEFT JOIN DBHORARIO ON IDHRTK = IDSORTEOHR

            dgr.DataSource = query;


        }

        public void sr_llenar_grid_detalle(ref DataGridView dgr, long tkt)
        {
            animalitos db = new animalitos(CN.CONEC);
            int IDSORT = func_CODSORTEO(tkt);

            var query = (from qrydetalleticket in db.dbdtickets
                         join qryanimal in db.dbanimalitos on qrydetalleticket.CODIGODTK equals qryanimal.CODIGO into AN
                         join qryestatus in db.dbestatus on qrydetalleticket.ESTATUSDTK equals qryestatus.CODESTATUS into CA
                         from ANX in AN.Where (x => x.CODIGO  == qrydetalleticket.CODIGODTK  ).DefaultIfEmpty ()
                         from CAX in CA.Where (b => b.CODESTATUS == qrydetalleticket.ESTATUSDTK ).DefaultIfEmpty ()

                         where qrydetalleticket.IDTICKETDTR == tkt && ANX.IDSORTEOAN == IDSORT

                         select new
                         {
                             qrydetalleticket.IDTICKETDTR,
                             qrydetalleticket.CODIGODTK,
                             ANX.NOMBRE_ANIMALITO,
                             qrydetalleticket.MONTO,
                             qrydetalleticket.PREMIO,
                             CAX.NOMESTATUS  
                         }
                         ).ToList();


            dgr.DataSource = query;

        }
        public int func_CODSORTEO(long tkt) //obtengo el codigo de SORTEO desde 
        {
            animalitos db = new animalitos(CN.CONEC);
            int IDSORT = 0;
          
            var queryid = (from qryticket in db.dbtickets
                           where qryticket.IDTICKET == tkt
                           select new { qryticket.IDSORTEOTK }).ToList();

            foreach (var aqui in queryid)
                IDSORT = int.Parse(aqui.IDSORTEOTK.ToString());
            return IDSORT;
        }

        public void sr_columnas_cambiar(ref DataGridView dgr, string tipo)
        {
            if (tipo == "D") { 
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

                //dataGridView1.Columns["CompanyName"].ReadOnly = true;

          
                dgr.Columns[1].ReadOnly = true;
                dgr.Columns[2].ReadOnly = true;
                dgr.Columns[3].ReadOnly = true;
                dgr.Columns[4].ReadOnly = true;
                dgr.Columns[5].ReadOnly = true;
                dgr.Columns[7].ReadOnly = true;
                dgr.Columns[8].ReadOnly = true;

            }else if (tipo == "T")
            {

                dgr.Columns[0].HeaderText = "Ticket";
                dgr.Columns[1].HeaderText = "Animal";
                dgr.Columns[2].HeaderText = "Nombre";
                dgr.Columns[3].HeaderText = "Monto";
                dgr.Columns[4].HeaderText = "Premio";
                dgr.Columns[5].HeaderText = "Estatus";

                dgr.Columns[3].DefaultCellStyle.Format = "###,##0.00";
                dgr.Columns[4].DefaultCellStyle.Format = "###,##0.00";
            
            }


        }

        public void sr_ganador_ticket(ref DataGridView dgr, int celda)
        {
            
                for (int count = 0; count < dgr.Rows.Count; count++)
                {
                
                        if (dgr.Rows[count].Cells[celda].Value.ToString().Trim() == "PENDIENTE POR PAGAR" ||
                            dgr.Rows[count].Cells[celda].Value.ToString().Trim() == "PAGADO") 
                        {
                            dgr.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(167)))), ((int)(((byte)(151)))));
                        }
                }


        }
    }
}
