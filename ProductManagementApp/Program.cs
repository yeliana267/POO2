

using System;

namespace ProductManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();


            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del producto: ");
                        string name = Console.ReadLine();

                        Console.Write("Ingrese el precio: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal price))
                        {
                            productService.AddProduct(name, price);
                        }
                        else
                        {
                            Console.WriteLine("Precio invalido. Intente de nuevo.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el ID del producto a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int productId))
                        {
                            productService.DeleteProduct(productId);
                        }
                        else
                        {
                            Console.WriteLine("ID invalido. Intente de nuevo.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("Opción no valida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
