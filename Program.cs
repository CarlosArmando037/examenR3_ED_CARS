using ConsoleApp1.Clases;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista= new Lista();
            int opcion;
            do
            {
                Console.WriteLine("SELECCIONE UNA OPCION");
                Console.WriteLine("1._Salir");
                Console.WriteLine("2._Ingresar un nuevo producto");
                Console.WriteLine("3._Mostrar todos los productos");
                Console.WriteLine("4._Ordenar los productos pro su precio");
                Console.WriteLine("5._Buscar producto por precio");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 2:
                        ProductosModel productos= new ProductosModel();
                        Console.WriteLine("inserte el Nombre del producto");
                        productos.Nombre = Console.ReadLine();
                        Console.WriteLine("inserte el Precio del producto");
                        productos.Presio = Convert.ToInt32(Console.ReadLine());
                        lista.Insertar(productos);
                        break;
                    case 3:
                        lista.Mostrar();
                        break;
                    case 4:
                        lista.Ordenar();
                        break;
                    case 5:
                        ProductosModel productos1 = new ProductosModel();
                        Console.WriteLine("inserte el producot que quiera buscar por PRECIO");
                        productos1.Presio = Convert.ToInt32(Console.ReadLine());
                        lista.Buscar(productos1);
                        break;
                        
                }
            }
            while (opcion != 1);

        }
    }
}