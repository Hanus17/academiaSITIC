using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Metodos
    {
        static void Main3(string[] args)
        {
            int initialStock = 50;
            int quantityToAdd = 20;
            int addedQuantity;

            UpdateStock(initialStock, quantityToAdd, out int updatedStock, out addedQuantity);

            Console.WriteLine($"Inventario inicial: {initialStock}");
            Console.WriteLine($"Inventario inicial: {quantityToAdd}");
            Console.WriteLine($"Inventario inicial: {updatedStock}");

            //Ajuste de entrada
            AdjustStock(ref updatedStock, 10);
            Console.WriteLine($"Ajuste de entrada: {updatedStock}");

            //Ajuste de entrada
            AdjustStock(ref updatedStock, -20);
            Console.WriteLine($"Ajuste de entrada: {updatedStock}");

            //Lectura del producto
            //var infoProduct = GetProductInfo("Laptop", 20);
            //infoProduct.

            Console.WriteLine();
            (string productName, int stock) = GetProductInfo("Laptop", 20);
            Console.WriteLine($"Nombre del producto: {productName}");
            Console.WriteLine($"Inventario del producto: {stock}");

            Console.ReadKey();
        }

        public static void UpdateStock(int initialStock, int quantityToAdd, out int updatedStock, out int addedQuantity)
        {
            addedQuantity = quantityToAdd;
            updatedStock = initialStock + addedQuantity;
        }

        public static void AdjustStock(ref int stock, int adjustment)
        {
            stock += adjustment;
        }

        public static (string productName, int stock) GetProductInfo(string productName, int stock)
        {
            return (productName, stock);
        }
    }
}

