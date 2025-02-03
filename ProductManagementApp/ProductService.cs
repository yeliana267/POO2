

using System;

namespace ProductManagementApp
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto '{name}' agregado con precio {price:C}.");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Producto con ID {productId} eliminado.");
        }
    }

}
