using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEjemplo
{
    internal class MiPila
    {
        MiNodo _tope;

        public MiNodo Tope()
        {
            return _tope;
        }

        public void Apilar(MiNodo unNodo)
        {
            if (_tope == null)
                _tope = unNodo;
            else
            {
                MiNodo aux = _tope;
                _tope = unNodo;
                _tope.Siguiente = aux;
            }
        }
        

        public void Desapilar() 
        {
            if (_tope != null) 
            {
                _tope = _tope.Siguiente;
            }  
        }
    }
}
 