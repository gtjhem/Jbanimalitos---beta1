﻿using System;
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

        public void sr_llenar_resultados(ref DataGridView dgr, int IDS, DateTime dia)
        {
            animalitos db = new animalitos(CN.CONEC);
            var query = (from A in db.dbresultados
                         join B in db.dbSorteos on new { ID_LOTERIA = Convert.ToInt32(A.ID_LOTERIA) } equals new { ID_LOTERIA = B.ID_SORTEO } into B_join
                         from B in B_join.DefaultIfEmpty()
                         join C in db.dbhorarios
                               on new { A.ID_LOTERIA, ID_SORTEOHR = Convert.ToInt32(A.ID_SORTEOHR) }
                           equals new { ID_LOTERIA = C.IDSORTEOHR, ID_SORTEOHR = C.IDHORA } into C_join
                         from C in C_join.DefaultIfEmpty()
                         join D in db.dbanimalitos on new { ID_ANIMAL = Convert.ToInt32(A.ID_ANIMAL) } equals new { ID_ANIMAL = D.IDANIMALITOS } into D_join
                         from D in D_join.DefaultIfEmpty()
                         join E in db.dbestatus on new { ESTATUS = A.ESTATUS } equals new { ESTATUS = E.CODESTATUS } into E_join
                         from E in E_join.DefaultIfEmpty()
                         where
                           A.FECHA == dia && 
                           A.ID_LOTERIA == IDS
                         select new
                         {
                             A.ID_RESULTADO,
                             NOMBRE_SORTEO = B.NOMBRE_SORTEO,
                             HORA = C.HORA,
                             NOMBRE_ANIMALITO = D.NOMBRE_ANIMALITO,
                             NOMESTATUS = E.NOMESTATUS,
                             A.FECHA,
                             Column1 = A.HORA
                         });

            dgr.DataSource = query;
        }

        public void sr_llenar_grid_pagados(ref DataGridView dgr, DateTimePicker desde, DateTimePicker hasta)
        {
            //obtengo todos los pagados y por pagar 
            animalitos db = new animalitos(CN.CONEC);


            var TAGESTATUS = new string[] { "PA", "PE" };

            var query = (from qrytickets in db.dbtickets
                         join qrysorteo in db.dbSorteos on qrytickets.IDSORTEOTK equals qrysorteo.ID_SORTEO into fg
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDHORA into fx
                         join qryestatus in db.dbestatus on qrytickets.ESTATUSTK equals qryestatus.CODESTATUS into fe
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx.Where(x => x.IDHORA == qrytickets.IDHRTK).DefaultIfEmpty()
                         from fed in fe.Where(n => n.CODESTATUS == qrytickets.ESTATUSTK).DefaultIfEmpty()

                         where qrytickets.FECHATQ >= desde.Value && qrytickets.FECHATQ <= hasta.Value &&
                            TAGESTATUS.Contains (qrytickets.ESTATUSTK )

                         select new
                         {
                             qrytickets.IDTICKET,
                             fgi.NOMBRE_SORTEO,
                             fxi.HORA,
                             qrytickets.TOTALPAGADO,
                             qrytickets.PREMIOS,
                             qrytickets.DIFERENCIA,
                             fed.NOMESTATUS,
                             qrytickets.FECHATQ,
                             qrytickets.HORATQ
                         }).ToList();

            // SELECT * FROM DBTICKET LEFTJOIN DBSORTEO ON IDSORTEOTK = ID_SORTEO LEFT JOIN DBHORARIO ON IDHRTK = IDSORTEOHR

            dgr.DataSource = query;


        }



        public void sr_llenar_grid_FILTRADO1(ref DataGridView dgr, DateTimePicker desde, DateTimePicker hasta, ComboBox cmb)
        {

            //filtra por loterias 

            animalitos db = new animalitos(CN.CONEC);

            string[] v = cmb.Text.Split('-'); //Obtengo el ID de la loteria
            

            var query = (from qrytickets in db.dbtickets
                         join qrysorteo in db.dbSorteos on qrytickets.IDSORTEOTK equals qrysorteo.ID_SORTEO into fg
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDHORA into fx
                         join qryestatus in db.dbestatus on qrytickets.ESTATUSTK equals qryestatus.CODESTATUS into fe
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx.Where(x => x.IDHORA == qrytickets.IDHRTK).DefaultIfEmpty()
                         from fed in fe.Where(n => n.CODESTATUS == qrytickets.ESTATUSTK).DefaultIfEmpty()

                         where qrytickets.FECHATQ >= desde.Value && qrytickets.FECHATQ <= hasta.Value
                               && qrytickets.IDSORTEOTK == int.Parse(v[1]) 

                         select new
                         {
                             qrytickets.IDTICKET,
                             fgi.NOMBRE_SORTEO,
                             fxi.HORA,
                             qrytickets.TOTALPAGADO,
                             qrytickets.PREMIOS,
                             qrytickets.DIFERENCIA,
                             fed.NOMESTATUS,
                             qrytickets.FECHATQ,
                             qrytickets.HORATQ
                         }).ToList();

            dgr.DataSource = query;


        }
        public void sr_llenar_grid_FILTRADO_pagados(ref DataGridView dgr, DateTimePicker desde, DateTimePicker hasta, ComboBox cmb)
        {

            //filtra por loterias y los pagados y pendientes por pagar

            animalitos db = new animalitos(CN.CONEC);

            string[] v = cmb.Text.Split('-'); //Obtengo el ID de la loteria
            var TAGESTATUS = new string[] { "PA", "NP" };


            var query = (from qrytickets in db.dbtickets
                         join qrysorteo in db.dbSorteos on qrytickets.IDSORTEOTK equals qrysorteo.ID_SORTEO into fg
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDHORA into fx
                         join qryestatus in db.dbestatus on qrytickets.ESTATUSTK equals qryestatus.CODESTATUS into fe
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx.Where(x => x.IDHORA == qrytickets.IDHRTK).DefaultIfEmpty()
                         from fed in fe.Where(n => n.CODESTATUS == qrytickets.ESTATUSTK).DefaultIfEmpty()

                         where qrytickets.FECHATQ >= desde.Value && qrytickets.FECHATQ <= hasta.Value
                               && qrytickets.IDSORTEOTK == int.Parse(v[1]) &&
                               TAGESTATUS.Contains(qrytickets.ESTATUSTK)

                         select new
                         {
                             qrytickets.IDTICKET,
                             fgi.NOMBRE_SORTEO,
                             fxi.HORA,
                             qrytickets.TOTALPAGADO,
                             qrytickets.PREMIOS,
                             qrytickets.DIFERENCIA,
                             fed.NOMESTATUS,
                             qrytickets.FECHATQ,
                             qrytickets.HORATQ
                         }).ToList();

            dgr.DataSource = query;


        }

        public void sr_llenar_grid_FILTRADO2(ref DataGridView dgr,  TextBox TXTIDTK)
        {

            //filtra por TICKETS 

            animalitos db = new animalitos(CN.CONEC);

    

            var query = (from qrytickets in db.dbtickets
                         join qrysorteo in db.dbSorteos on qrytickets.IDSORTEOTK equals qrysorteo.ID_SORTEO into fg
                         join qryhorario in db.dbhorarios on qrytickets.IDHRTK equals qryhorario.IDHORA into fx
                         join qryestatus in db.dbestatus on qrytickets.ESTATUSTK equals qryestatus.CODESTATUS into fe
                         from fgi in fg.Where(f => f.ID_SORTEO == qrytickets.IDSORTEOTK).DefaultIfEmpty()
                         from fxi in fx.Where(x => x.IDHORA == qrytickets.IDHRTK).DefaultIfEmpty()
                         from fed in fe.Where(n => n.CODESTATUS == qrytickets.ESTATUSTK).DefaultIfEmpty()

                         where qrytickets.IDTICKET  == int.Parse(TXTIDTK.Text )

                         select new
                         {
                             qrytickets.IDTICKET,
                             fgi.NOMBRE_SORTEO,
                             fxi.HORA,
                             qrytickets.TOTALPAGADO,
                             qrytickets.PREMIOS,
                             qrytickets.DIFERENCIA,
                             fed.NOMESTATUS,
                             qrytickets.FECHATQ,
                             qrytickets.HORATQ
                         }).ToList();

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

         public void sr_llenar_grid_jugadas(ref DataGridView dgr, long loteria, long sorteo, string codan, DateTime desde, DateTime hasta)
        {
            animalitos db = new animalitos(CN.CONEC);

            var query = (from A in db.dbdtickets
                         join TBL_TICKET in db.dbtickets 
                            on new { IDTICKETDTR = Convert.ToInt64(A.IDTICKETDTR), A.FECHADTK } 
                            equals new { IDTICKETDTR = TBL_TICKET.IDTICKET, FECHADTK = TBL_TICKET.FECHATQ }
                         join Tbl_SORTEO in db.dbSorteos on new { IDSORTEOTK = Convert.ToInt32(TBL_TICKET.IDSORTEOTK) } equals new { IDSORTEOTK = Tbl_SORTEO.ID_SORTEO }
                         join B in db.dbhorarios
                               on new { TBL_TICKET.IDSORTEOTK, IDHRTK = Convert.ToInt32(TBL_TICKET.IDHRTK) }
                           equals new { IDSORTEOTK = B.IDSORTEOHR, IDHRTK = B.IDHORA }
                         join TBL_ANIMALITOS in db.dbanimalitos
                               on new { TBL_TICKET.IDSORTEOTK, A.CODIGODTK }
                           equals new { IDSORTEOTK = TBL_ANIMALITOS.IDSORTEOAN, CODIGODTK = TBL_ANIMALITOS.CODIGO }
                         join TBL_ESTATUS in db.dbestatus on new { ESTATUSDTK = A.ESTATUSDTK } equals new { ESTATUSDTK = TBL_ESTATUS.CODESTATUS }
                         where
                           A.FECHADTK >= desde && A.FECHADTK <= hasta &&
                           A.CODIGODTK == codan && TBL_TICKET.IDSORTEOTK == loteria && TBL_TICKET.IDHRTK == sorteo 
                         orderby
                           A.IDTICKETDTR
                         select new
                         {
                             A.IDTICKETDTR,
                             TBL_ANIMALITOS.NOMBRE_ANIMALITO,
                             A.CODIGODTK,
                             A.MONTO,
                             TBL_ESTATUS.NOMESTATUS,
                             FECHADTK = (DateTime?)A.FECHADTK,
                             A.HORA,
                             Tbl_SORTEO.NOMBRE_SORTEO,
                             Column1 = B.HORA
                         }).ToList();


            dgr.DataSource = query;

        }
        public void sr_columnas_cambiar(ref DataGridView dgr, string tipo)
        {
            if (tipo == "D") { 
                dgr.Columns[0].HeaderText = "Ticket";
                dgr.Columns[1].HeaderText = "Loteria";
                dgr.Columns[2].HeaderText = "Sorteo";
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
            
            }else if (tipo == "R")
            {

                dgr.Columns[0].HeaderText = "Id";
                dgr.Columns[1].HeaderText = "Loteria";
                dgr.Columns[2].HeaderText = "Sorteo";
                dgr.Columns[3].HeaderText = "Jugada";
                dgr.Columns[4].HeaderText = "Estatus";
                dgr.Columns[5].HeaderText = "Fecha";
                dgr.Columns[6].HeaderText = "Hora";

            }



            dgr.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
            dgr.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public void sr_ganador_ticket(ref DataGridView dgr, int celda)
        {
            for (int count = 0; count < dgr.Rows.Count; count++)
                {
                
                        if (dgr.Rows[count].Cells[celda].Value.ToString().Trim() == "PAGADO") 
                        {
                            dgr.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(167)))), ((int)(((byte)(151)))));

                        } else if (dgr.Rows[count].Cells[celda].Value.ToString().Trim() == "ANULADO MANUAL"){
                    
                            dgr.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
                            dgr.Rows[count].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        }else if (dgr.Rows[count].Cells[celda].Value.ToString().Trim() == "PENDIENTE POR PAGAR")
                { 
                    dgr.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(148)))), ((int)(((byte)(38)))));
                    dgr.Rows[count].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                } 
                }


        }

        public void Formatear_fechas(ref DateTimePicker dtp )
        {
            //Aplica formato de fecha y coloca la fecha de hoy 
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.Value = DateTime.Today;
       
        }


    }

}
