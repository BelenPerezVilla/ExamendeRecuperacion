using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace examenderecuperacion
{
    class productos
    {
  public  string Nombre;
  public   int cantidad;
 public    float Precio;

        public productos(string Nombre, int cantidad, float Precio)
        {
            this.Nombre = Nombre;
            this.cantidad = cantidad;
            this.Precio = Precio;
        }
        public void MostrarProducto()
        {
            Console.WriteLine("--------Producto-------");
            Console.WriteLine("El nombre del producto es: {0}", Nombre);
            Console.WriteLine("La cantidad de su producto es: {0}", cantidad);
            Console.WriteLine("El precio del prodcuto es: {0:C}", Precio);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           string Nombre;
            int cantidad;
            float Precio;
            StreamWriter sw = new StreamWriter("Inventario.txt", true);
            Console.WriteLine("-------Captura de datos-------");
            Console.Write("El nombre del producto es: ");
            Nombre = Console.ReadLine();
            Console.Write("la cantidad del producto es: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.Write("El precio del producto es: ");
            Precio = float.Parse(Console.ReadLine());
            Console.Clear();
            productos P1 = new productos(Nombre, cantidad, Precio);

            sw.WriteLine("Nombre del producto: " + P1.Nombre + "\nCantidad " + P1.cantidad + "\nPrecio: $" + P1.Precio);
            Console.WriteLine("Productos registrados exitosamente!!!!\n");
            P1.MostrarProducto();
            Console.WriteLine("\nPrecione ENTER para continuar.....");
            Console.ReadKey();
            Console.Clear();
            sw.Close();

            try
            {
                StreamReader sr = new StreamReader("Inventario.txt");
                string line = "";
                Console.WriteLine("Productos registrados\n");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            catch(IOException e)
            {
                Console.WriteLine("Error, Archivo no encontrado\nDebe Capturar un producto primero");
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}
