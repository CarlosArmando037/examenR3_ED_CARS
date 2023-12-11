using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Lista
    {
        public Nodo primero;
        public Nodo ultimo;
        public Lista() 
        {
            primero = ultimo = null;
        }

        //metodo

        public bool EsVacio()
        {
            if (primero == null)
            {
                return true;
            }
            else
                return false;
        }

        public void Insertar(ProductosModel productos)
        {
            if (EsVacio())
            {
                primero = new Nodo(productos);
                Console.WriteLine("se ha insertado el producto exitosamente");
            }
            else
            {
                primero = new Nodo(productos, primero);
                Console.WriteLine("se ha insertado el producto exitosamente");

            }
        }

        public void Mostrar()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"el producto es: {actual.Productos.Nombre}, y su precio es: {actual.Productos.Presio}");
                    actual = actual.siguiente;
                }
            }
        }
        public void Ordenar()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Nodo proximo = actual.siguiente;
                    while (proximo != null)
                    {
                        if (actual.Productos.Presio < proximo.Productos.Presio)
                        {
                            //los datos no se modifican, puede ser por el hecho de nodo temp?
                            Nodo temp = actual;
                            actual = proximo;
                            proximo = temp;
                        }
                        proximo = proximo.siguiente;
                    }
                    actual = actual.siguiente;
                }
                Mostrar();
            }
        }

        public void Buscar(ProductosModel producto)
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.Productos.Presio == producto.Presio)
                    {
                        Console.WriteLine($"se encontraron el producto: {actual.Productos.Nombre}");
                    }
                    actual = actual.siguiente;
                }
            }
        }

    }
}
