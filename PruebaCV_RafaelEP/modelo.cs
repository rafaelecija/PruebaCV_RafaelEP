using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCV_RafaelEP
{
    internal class modelo
    {
        private string _nombre;

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
    }
}
