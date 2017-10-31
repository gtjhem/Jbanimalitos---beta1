using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Jbanimalitosv2
{
    public partial class animalitos : DataContext
    {
        public Table<Tbl_SORTEO> dbSorteos;
        public Table<TBL_HORARIOS> dbhorarios;
        public Table<TBL_ANIMALITOS> dbanimalitos;
        public Table<TBL_TICKET> dbtickets;
        public Table<TBL_DTICKET> dbdtickets;
        public Table<TBL_ESTATUS> dbestatus;
        public Table<TBL_RESULTADOS> dbresultados;
        public Table<TBL_BANCA> dbbanca;
        public Table<TBL_ABONOS> dbabono;
        public Table<TBL_CIERRE> dbcierre;
        public Table<TBL_COMISION> dbcomision;
 
        
        
        public animalitos(string connection) : base(connection) { }

       
    }
}
