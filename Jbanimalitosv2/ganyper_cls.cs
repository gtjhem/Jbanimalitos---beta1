using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jbanimalitosv2
{
    class ganyper
    {

        private float totalventas;
        public float varcls_totalventas
        {
            set
            {
                totalventas  = value;
            }
            get
            {
                return totalventas;
            }
        }

        private float totalapagar;
        public float varcls_totalapagar
        {
            set
            {
                totalapagar = value;
            }
            get
            {
                return totalapagar;
            }
        }

        private float subtotal;
        public float varcls_subtotal
        {
            set
            {
                subtotal = value;
            }
            get
            {
                return  subtotal;
            }
        }

        private float porcentajeventas;
        public float varcls_porcentajeventas
        {
            set
            {
                porcentajeventas = value;
            }
            get
            {
                return porcentajeventas;
            }
        }
        private float totalgeneral;
        public float varcls_totalgeneral
        {
            set
            {
                totalgeneral = value;
            }
            get
            {
                return totalgeneral;
            }
        }



        public ganyper (float ttv, float ttap, float sbt, float pven, float ttg)
        {
            varcls_totalventas = ttv;
            varcls_totalapagar = ttap;
            varcls_subtotal = sbt;
            varcls_porcentajeventas = pven;
            varcls_totalgeneral = ttg;

        }
        
    }

    class totalescls
    {
        private ganyper[] var_cls_TOTALES;
       
        public totalescls()
        {
            var_cls_TOTALES = new ganyper[1];
        }

        public ganyper this[int indice]
        {
            set
            {
                var_cls_TOTALES[indice] = value;
            }
            get
            {
                return var_cls_TOTALES[indice];
            }
        }
    }

    class Busquedas
    {
        totalescls TOTAL = new totalescls();
        Utilidades CN = new Utilidades();

        public void sr_buscar_totales(ref float ttv, ref float ttp, ref float stt, DateTimePicker desde, DateTimePicker hasta)
        {
            animalitos DB = new Jbanimalitosv2.animalitos(CN.CONEC);

            // que cagada no pude hacerla en un group maldita sea 
        
            

            var query1 = (DB.dbtickets.Where(x => x.FECHATQ >= desde.Value).Where(X => X.FECHATQ <= hasta.Value).Sum(a => a.TOTALPAGADO ));
            if (query1 != null )ttv = float.Parse(query1.ToString());

            var query2 = (DB.dbtickets.Where(x => x.FECHATQ >= desde.Value).Where(X => X.FECHATQ <= hasta.Value).Sum(b => b.PREMIOS ));
            if (query2 != null )ttp = float.Parse(query2.ToString());

            var query = (DB.dbtickets.Where(x => x.FECHATQ >= desde.Value).Where(X => X.FECHATQ <= hasta.Value).Sum(s => s.DIFERENCIA));
            if (query != null )stt = float.Parse(query.ToString());

        }

        public void sr_stp_totales(ref decimal ? ttv, ref decimal ? ttp, ref decimal ? stt, DateTimePicker desde, DateTimePicker hasta)
        {
            
            CLS_LINQ_ANMLTDataContext DCT = new CLS_LINQ_ANMLTDataContext(CN.CONEC);

            var query = DCT.TOTALES_GYP(desde.Value , hasta.Value ,ref  ttv , ref ttp, ref stt);

        }
    }
}
