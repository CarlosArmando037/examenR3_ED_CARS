using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Nodo
    {
        private ProductosModel _Productos;
        private Nodo _Siguiente;

        public Nodo(ProductosModel productos)
        {
            _Productos = productos;
            _Siguiente = null;
        }
        public Nodo(ProductosModel productos, Nodo siguiente)
        {
            _Productos = productos;
            _Siguiente = siguiente;
        }
        public ProductosModel Productos { get { return _Productos; } set { _Productos = value; } }
        public Nodo siguiente { get { return _Siguiente; } set { _Siguiente = value; } }
    }
}
