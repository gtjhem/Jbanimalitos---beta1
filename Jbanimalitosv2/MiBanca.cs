using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jbanimalitosv2
{
    
    public static class MiBanca
    {
       

        public static string nom_banca;
        public static string impresora;
        public static long ID_AGENCIA;
        public static double ? VR_MULTIPLICADOR;
        public static double? VR_COMISION;
         
      
        public static void sr_llenar()
        {
            try
            { 
            Utilidades CN = new Utilidades();
            animalitos db = new Jbanimalitosv2.animalitos(CN.CONEC);

            var query = (from qrybanca in db.dbbanca
                         where qrybanca.ESTATUS == "AC" select qrybanca ).First();

                nom_banca = query.NOMBRE_AGENCIA.ToUpper();
                impresora = query.IMPRESORA;
                VR_MULTIPLICADOR = query.MULTIPLICADOR;
                VR_COMISION = query.COMISION_ACTUAL;
                ID_AGENCIA = query.ID_AGENCIA;
            }
            catch (System.InvalidOperationException) {
                nom_banca = "";
                impresora = "";
                VR_MULTIPLICADOR = 0;
                VR_COMISION = 0;

            }                   

        }

    }


}
