using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jbanimalitosv2
{
    class Dtsanimal
    {
        private string codi_animal;
        public string var_cls_codi_animal
        {
            set
            {
                codi_animal = value;
            }
            get
            {
                return codi_animal;
            }
        }
        private string nombre;
        public string var_cls_Nombre
        {
            set
            {
                 nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        private float monto;
        public float var_cls_Monto
        {
            set
            {
                monto = value;
            }
            get
            {
                return monto;
            }
        }


        public Dtsanimal (string cod, string nom, float mnt)
        {
            var_cls_codi_animal = cod;
            var_cls_Nombre = nom;
            var_cls_Monto = mnt;
            
        }
    }
    class Detalles_animales
    {
        private Dtsanimal[] var_cls_dtsanimal;
        public Detalles_animales()
        {
            var_cls_dtsanimal = new Dtsanimal[40];
        }

        public Dtsanimal this[int indice]
        {
            set
            {
                var_cls_dtsanimal[indice] = value;
            }
            get
            {
                return var_cls_dtsanimal[indice];
            }
        }
    }
}
