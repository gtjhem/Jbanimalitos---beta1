﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
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
        
        public animalitos(string connection) : base(connection) { }
    }
}
