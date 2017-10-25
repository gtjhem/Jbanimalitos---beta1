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

        [Function(Name = "dbo.TOTALGANYPER")]
        public int TOTALGANYPER([Parameter(DbType = "Date")] DateTime  desde,
            [Parameter(DbType = "Date")] DateTime hasta,
            [Parameter(DbType = "Float")] ref float ttv,
            [Parameter(DbType = "Float")] ref float ttp,
            [Parameter(DbType = "Float")] ref float stt)

        {
            
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), 
                Convert.ToDateTime("2017-10-24"), Convert.ToDateTime("2017-10-24"), ttv, ttp, stt);

            ttv = ((float)(result.GetParameterValue(2)));
            ttp = ((float)(result.GetParameterValue(3)));
            stt = ((float)(result.GetParameterValue(4)));
            return ((int)(result.ReturnValue));

        }
        public animalitos(string connection) : base(connection) { }

       
    }
}
