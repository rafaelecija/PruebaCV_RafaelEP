using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCV_RafaelEP
{
    internal class modelo
    {
        private const int NOMBRE_MIN = 2;

        private const int EDAD_MIN = 18;

        private string _nombre;
        private int _Edad;
        public string Nombre
        {
            get { return _nombre; }

            set
            {
                
                bool estaOK;

                estaOK = true;

                if(string.IsNullOrEmpty(_nombre))
                {
                    estaOK=false;
                }
                _nombre=value;

            }

        }
        public int Edad
        {
            get { return _Edad; }
            set
            {
                int edad=0;
                bool estaOK = true;
                if(edad<EDAD_MIN)
                {
                    estaOK = false;
                }
            }
        }

    }
}
