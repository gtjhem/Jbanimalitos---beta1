using System;

using System.Linq;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Jbanimalitosv2
{
    class  Utilidades  :  IDisposable

    {
        
        public string CONEC =  System.Configuration.ConfigurationManager.ConnectionStrings["CNX"].ConnectionString;
        public string ULTIMOSERIAL;
        public string ULTIMOTICKET;
        public double ULTIMOTOTAL;
        
        private   CheckedListBox  CLB = new CheckedListBox();

        public void sr_llenar_sorteos  (ref CheckedListBox CLB, int vr_key_codigo)
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         join qryhorario in db.dbhorarios on qrysorteos.ID_SORTEO equals qryhorario.IDSORTEOHR
                         where qrysorteos.ESTATUS == "A" && qrysorteos.ID_SORTEO == vr_key_codigo
                         select new { qryhorario.HORA, qrysorteos.NOMBRE_SORTEO, qryhorario.IDHORA   }).ToList();


            CLB.Items.Clear();
            foreach (var aqui in query)

                if (aqui.HORA >= DateTime.Now.TimeOfDay)
                //if (aqui.HORA <= DateTime.Now.TimeOfDay)
                {

                    CLB.Items.Add(aqui.HORA + " - " + aqui.NOMBRE_SORTEO.ToString().ToUpper() + " - " + aqui.IDHORA );
                }        
                                    
        }



        public void sr_llenar_sorteos_resultados(ref CheckedListBox CLB, int vr_key_codigo) // no posee filtros para la hora
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         join qryhorario in db.dbhorarios on qrysorteos.ID_SORTEO equals qryhorario.IDSORTEOHR
                         where qrysorteos.ESTATUS == "A" && qrysorteos.ID_SORTEO == vr_key_codigo
                         select new { qryhorario.HORA, qrysorteos.NOMBRE_SORTEO, qryhorario.IDHORA }).ToList();


            CLB.Items.Clear();
            foreach (var aqui in query)
                    CLB.Items.Add(aqui.HORA + " - " + aqui.NOMBRE_SORTEO.ToString().ToUpper() + " - " + aqui.IDHORA);
             
        }

        public void sr_llenar_sorteos_cmb(ref ComboBox CLB, int vr_key_codigo) // no posee filtros para la hora
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         join qryhorario in db.dbhorarios on qrysorteos.ID_SORTEO equals qryhorario.IDSORTEOHR
                         where qrysorteos.ESTATUS == "A" && qrysorteos.ID_SORTEO == vr_key_codigo
                         select new { qryhorario.HORA, qrysorteos.NOMBRE_SORTEO, qryhorario.IDHORA }).ToList();


            CLB.Items.Clear();
            foreach (var aqui in query)
                CLB.Items.Add(aqui.HORA + " - " + aqui.NOMBRE_SORTEO.ToString().ToUpper() + " - " + aqui.IDHORA);

        }

        private ComboBox cmb = new ComboBox();
        public void sr_llenar_loteria (ref ComboBox CMB, Boolean limpiar)
        {

            animalitos db = new animalitos(CONEC);

            var query = (from qrysorteos in db.dbSorteos
                         where qrysorteos.ESTATUS == "A"
                         select new { qrysorteos.NOMBRE_SORTEO, qrysorteos.ID_SORTEO }).ToList();


            if (limpiar == true ) CMB.Items.Clear();

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
        public void sr_llenar_animales_cmb(ref ComboBox CLB, int vr_key_loteria)
        {
            animalitos db = new animalitos(CONEC);


            var query = (from qryanimalito in db.dbanimalitos
                         where qryanimalito.IDSORTEOAN == vr_key_loteria

                         select new { qryanimalito.CODIGO, qryanimalito.NOMBRE_ANIMALITO }).ToList();


            CLB.Items.Clear();

            foreach (var aqui in query)
                CLB.Items.Add(aqui.CODIGO.ToString() + " - " + aqui.NOMBRE_ANIMALITO.ToString());
        }

        public long sr_ticket()
        {
            try

            {
                animalitos db = new animalitos(CONEC);

                long query = db.dbtickets.Max(d => d.IDTICKET);

                return query + 1;
            }
            catch (System.InvalidOperationException)
            {
                return 1;
            }
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
        
        public void sr_resultados_del_dia()
        {
            animalitos db = new animalitos(CONEC);
           
            long cont = db.dbresultados.Where(d => d.FECHA == DateTime.Now).Count();

            if (cont == 0) // si no se han cargados los registros del dia se procede 
            {

                CLS_LINQ_ANMLTDataContext PRC = new Jbanimalitosv2.CLS_LINQ_ANMLTDataContext(CONEC);

                var query = PRC.PREP_REST();
                
            }
        }

        public void sr_resultados_del_dia_otros(DateTime fec)
        {
            animalitos db = new animalitos(CONEC);

            long cont = db.dbresultados.Where(d => d.FECHA == fec).Count();

            if (cont == 0) // si no se han cargados los registros de los otros dias se procede 
            {

                CLS_LINQ_ANMLTDataContext PRC = new Jbanimalitosv2.CLS_LINQ_ANMLTDataContext(CONEC);

                var query = PRC.PREP_REST_OTROS(fec);

            }
        }


        public void sr_guardar_ticket(ref ListBox lxb, ref TextBox ttl, ref ComboBox ltr)
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

                ULTIMOSERIAL = ser; // obtener el ultimo serial para imprimir 
                ULTIMOTICKET = sr_ticket().ToString(); // obtener el ultimo ticket para IMPRIMIR 

                ing.TOTALPAGADO = float.Parse (ttl.Text);
                ULTIMOTOTAL = float.Parse(ttl.Text); // total ticket pagado para IMPRIMIR
                
                string[] v = lxb.Items[0].ToString().Split('-');
                ing.IDHRTK = int.Parse (v[2]); //obtener ID horario desde el primer items del listbox 

                string[] s = ltr.Text.ToString().Split('-');
                ing.IDSORTEOTK = int.Parse (s[1]);  // obtener ID loteria desde el combobox
                ing.PREMIOS = 0;
                ing.DIFERENCIA = float.Parse (ttl.Text );
                ing.SERIAL = ser;
                ing.JUGADAS = lxb.Items.Count - 1;
                ing.ESTATUSTK = "PP";
                ing.FECHATQ = DateTime.Now ;
                ing.HORATQ = DateTime.Now.TimeOfDay;

                db.dbtickets.InsertOnSubmit(ing);
                db.SubmitChanges();
                

                sr_Detalle(ref lxb);               

            }            
        }

        public void sr_Detalle(ref ListBox rlxb)
        {
            Detalles_animales DA = new Detalles_animales();
                   
            int x = 0;
            for (x = 1; x <= rlxb.Items.Count - 1; x++)
            {
                using (animalitos xdb = new animalitos(CONEC)){
                    TBL_DTICKET ding = new TBL_DTICKET();

                    string[] v = rlxb.Items[x].ToString().Split('-');
                    Dtsanimal dts = new Dtsanimal(v[0], v[1], float.Parse(v[2]));
                    DA[x] = dts;

                    ding.ESTATUSDTK = "PP";
                    ding.CODIGODTK = DA[x].var_cls_codi_animal;
                    ding.IDTICKETDTR = sr_ticket() - 1;
                    ding.MONTO = DA[x].var_cls_Monto;
                    ding.PREMIO = 0;
                    ding.FECHADTK = DateTime.Now;
                    ding.HORA = DateTime.Now.TimeOfDay;
                    xdb.dbdtickets.InsertOnSubmit(ding);
                    xdb.SubmitChanges();
                
                }
            }

        }

        public void sr_guardar_ganador(int idl, int ids, DateTime fecha, string coda)
        {
            using (animalitos db = new animalitos(CONEC))
            {

                var ganador = (from c in db.dbresultados
                               where c.ID_LOTERIA == idl && c.ID_SORTEOHR == ids
                               && c.FECHA == fecha select c).First ();

                //ganador.ID_ANIMAL =
                if (ganador.ESTATUS == "CA") ganador.ESTATUS = "RE";
                if (ganador.ESTATUS == "XS") ganador.ESTATUS = "CA";          
                ganador.ID_ANIMAL = sr_ID_ANIMALITO(coda, idl);
                ganador.CODIGOANIMAL = coda;
                db.SubmitChanges();


            }
        }


        public Boolean sr_anular_ticket(long idticket)
        {
            using (animalitos db = new animalitos(CONEC))
            {

           try
                {
                    //actualizo ticket principal
                    var queryTBL_TICKET =
                        from TBL_TICKET in db.dbtickets
                        where
                          TBL_TICKET.IDTICKET == idticket
                        select TBL_TICKET;

                    foreach (var ACtualizar_TICKET in queryTBL_TICKET)
                    {
                        ACtualizar_TICKET.ESTATUSTK = "AM";
                    }
                    db.SubmitChanges();

                    //Actualizo ticket detalle
                    var queryTBL_DTICKET =
                            from TBL_TICKET in db.dbdtickets
                            where
                              TBL_TICKET.IDTICKETDTR == idticket
                            select TBL_TICKET;

                    foreach (var Actualizardetalle in queryTBL_DTICKET)
                    {
                        Actualizardetalle.ESTATUSDTK = "AM";
                    }
                    db.SubmitChanges();

                    return true;
                }
                catch(System.InvalidOperationException)
                {
                    return false;
                }
                

            }
        }


        public Boolean sr_pagar_ticket(long idticket, string serial)
        {
            using (animalitos db = new animalitos(CONEC))
            {

                try
                {
                    //actualizo ticket principal
                    var queryTBL_TICKET =
                        from TBL_TICKET in db.dbtickets
                        where
                          TBL_TICKET.IDTICKET == idticket &&
                          TBL_TICKET.SERIAL == serial
                        select TBL_TICKET;

                    foreach (var ACtualizar_TICKET in queryTBL_TICKET)
                    {
                        ACtualizar_TICKET.ESTATUSTK = "PA";
                    }
                    db.SubmitChanges();

                    //Actualizo ticket detalle
                    var queryTBL_DTICKET =
                            from TBL_TICKET in db.dbdtickets
                            where
                              TBL_TICKET.IDTICKETDTR == idticket
                            select TBL_TICKET;

                    foreach (var Actualizardetalle in queryTBL_DTICKET)
                    {
                        if (Actualizardetalle.PREMIO != 0) {
                            Actualizardetalle.ESTATUSDTK = "PA";
                        }
                        
                    }
                    db.SubmitChanges();

                    return true;
                }
                catch (System.InvalidOperationException)
                {
                    return false;
                }


            }
        }
        public int sr_ID_ANIMALITO(string coda, int IDL)
        {
            animalitos db = new animalitos(CONEC);
            var IDANIMAL = (from A1 in db.dbanimalitos
                            where A1.IDSORTEOAN == IDL && A1.CODIGO == coda select A1).First();

            return IDANIMAL.IDANIMALITOS;
        }

        public void sr_ganador(DateTime fec)
        {
            CLS_LINQ_ANMLTDataContext PRC = new CLS_LINQ_ANMLTDataContext(CONEC);

            var query = PRC.ACTUALIZAR_RESULTADOS(fec);
        }

        public string func_linea (ref ListBox lst)
        {
            string linea = "";

            int x = 0;
            for (x = 1; x <= lst.Items.Count - 1; x++)
            {
                string[] v = lst.Items[x].ToString().Split('-');
        

                linea = linea + " " + v[0] + " - " + v[1] + " - " + float.Parse(v[2]).ToString("###,##0.00") + Environment.NewLine; 
            }

                
            return linea;
        }


        public void sr_actualizar_BANCA(double ? comi, int ? cadu, double ? mult, string impresora, string agencia)
        {
            animalitos DB = new Jbanimalitosv2.animalitos(CONEC);

            try { 

                    var query = (from qrybanca in DB.dbbanca
                         where qrybanca.ID_AGENCIA == MiBanca.ID_AGENCIA &&
                         qrybanca.ESTATUS == "AC"
                         select qrybanca).First();

                //* SI LO CONSIGO ACTUALIZO 
                query.COMISION_ACTUAL = comi;
                query.TIEMPO_LIMITE = cadu;
                query.IMPRESORA = impresora;
                query.MULTIPLICADOR = mult;
                query.NOMBRE_AGENCIA = agencia;
                DB.SubmitChanges();
                           
                }
            catch (System.InvalidOperationException)
            {
                //* SI NO LO CONSIGO CREO UNO NUEVO CUAL ES EL PEO
                TBL_BANCA TBN = new TBL_BANCA();

                TBN.MULTIPLICADOR = 30;
                TBN.NOMBRE_AGENCIA = "LOTERIA POR DEFECTO";
                TBN.COMISION_ACTUAL = 0;
                TBN.IMPRESORA = "POR DEFINIR";
                TBN.TIEMPO_LIMITE = 3;
                TBN.ESTATUS = "AC";
                DB.dbbanca.InsertOnSubmit(TBN);
                DB.SubmitChanges();
            }
        }


        public void sr_buscar_ticket_para_anular(long BTCK,ref string loteria, ref string sorteo, ref double ? total, ref string fecha, ref string hora, ref string estatus)
        {
            animalitos db = new animalitos(CONEC);


            try
            {
                var query = (from TBL_TICKET in db.dbtickets
                             join Tbl_SORTEO in db.dbSorteos on new { IDSORTEOTK = Convert.ToInt32(TBL_TICKET.IDSORTEOTK) } equals new { IDSORTEOTK = Tbl_SORTEO.ID_SORTEO }
                             join TBL_HORARIOS in db.dbhorarios
                                   on new { TBL_TICKET.IDSORTEOTK, IDHRTK = Convert.ToInt32(TBL_TICKET.IDHRTK) }
                               equals new { IDSORTEOTK = TBL_HORARIOS.IDSORTEOHR, IDHRTK = TBL_HORARIOS.IDHORA }
                             join TBL_ESTATUS in db.dbestatus on new { ESTATUSTK = TBL_TICKET.ESTATUSTK } equals new { ESTATUSTK = TBL_ESTATUS.CODESTATUS }
                             where TBL_TICKET.IDTICKET == BTCK
                             select new
                             {
                                 TBL_TICKET.IDTICKET,
                                 Tbl_SORTEO.NOMBRE_SORTEO,
                                 TBL_HORARIOS.HORA,
                                 TBL_TICKET.TOTALPAGADO,
                                 TBL_TICKET.FECHATQ,
                                 TBL_TICKET.HORATQ,
                                 TBL_ESTATUS.NOMESTATUS
                             }).First();


                loteria = query.NOMBRE_SORTEO;
                sorteo = query.HORA.ToString();
                total = query.TOTALPAGADO ;
                fecha = query.FECHATQ.ToString();
                hora = query.HORATQ.ToString();
                estatus = query.NOMESTATUS;

            }


          
            catch (System.InvalidOperationException)
            {
                // Ticket no encontrado
                loteria = "";
                sorteo = "";
                total = 0;
                fecha = "";
                hora = "";
                estatus = "";
            }
        }



        public void sr_buscar_ticket_para_pagar(long BTCK, string serial, ref string loteria, ref string sorteo, ref double? total, ref string fecha, ref string hora, ref double? premio, ref string estatus)
        {
            animalitos db = new animalitos(CONEC);
            
            try
            {
                var query = (from TBL_TICKET in db.dbtickets
                             join Tbl_SORTEO in db.dbSorteos on new { IDSORTEOTK = Convert.ToInt32(TBL_TICKET.IDSORTEOTK) } equals new { IDSORTEOTK = Tbl_SORTEO.ID_SORTEO }
                             join TBL_HORARIOS in db.dbhorarios
                                   on new { IDHRTK = Convert.ToInt32(TBL_TICKET.IDHRTK), TBL_TICKET.IDSORTEOTK }
                               equals new { IDHRTK = TBL_HORARIOS.IDHORA, IDSORTEOTK = TBL_HORARIOS.IDSORTEOHR }
                             join TBL_ESTATUS in db.dbestatus on new { ESTATUSTK = TBL_TICKET.ESTATUSTK } equals new { ESTATUSTK = TBL_ESTATUS.CODESTATUS }
                             where
                                    TBL_TICKET.IDTICKET == BTCK && TBL_TICKET.SERIAL == serial
                             select new
                             {
                                 TBL_TICKET.IDTICKET,
                                 Tbl_SORTEO.NOMBRE_SORTEO,
                                 TBL_HORARIOS.HORA,
                                 TBL_ESTATUS.NOMESTATUS,
                                 TBL_TICKET.TOTALPAGADO,
                                 TBL_TICKET.PREMIOS,
                                 TBL_TICKET.SERIAL,
                                 TBL_TICKET.FECHATQ,
                                 TBL_TICKET.HORATQ
                             }).First();


                loteria = query.NOMBRE_SORTEO;
                sorteo = query.HORA.ToString();
                total = query.TOTALPAGADO;
                fecha = query.FECHATQ.ToString();
                hora = query.HORATQ.ToString();
                premio = query.PREMIOS;
                estatus = query.NOMESTATUS.ToString();

            }



            catch (System.InvalidOperationException)
            {
                // Ticket no encontrado
                loteria = "";
                sorteo = "";
                total = 0;
                fecha = "";
                hora = "";
                premio = 0;
                estatus = "";
            }
        }


        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~Utilidades() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
            // GC.SuppressFinalize(this);
        }
        #endregion



        public Boolean func_agrupar(ref ListBox lst, string jugada)
        {

            string[] s = jugada.Split('-'); // obtengo la jugada que voy agrupar

            int val = 0;   
            for (int x = 1; x <= lst.Items.Count - 1; x++)
            {
                string[] v = lst.Items[x].ToString().Split('-'); // separo los valores del list
                if (v[0] == s[0]) //comparo la jugada con la que ya esta ingresada 
                {

                    val = int.Parse(v[2]) + int.Parse(s[2]);
                    lst.Items.RemoveAt(x);
                    lst.Items.Insert(x, v[0].Trim() + " - " + v[1].Trim() + " - " + (val.ToString().Trim()));
                    return true;
                }
              
                                        
            }

            return false;
                   
        }

        public Boolean func_conexion() {

            try
            {
                SqlConnection conexion = new SqlConnection(CONEC);
                conexion.Open();
                conexion.Close();
                return true;

            }
            catch (System.InvalidOperationException)
            {
                return false;
            }
               

        }


  }

    }

