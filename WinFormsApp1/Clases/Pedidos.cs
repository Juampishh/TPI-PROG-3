using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1.Clases
{
    public class Pedidos
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Categoria { get; set; }

        public Pedidos(string producto, int cantidad, decimal precioUnitario, string categoria)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Categoria = categoria;
        }

        public static List<Pedidos> ObtenerMenuCompleto()
        {
            return new List<Pedidos>
            {
                // Entradas
                new Pedidos("Ensalada César", 0, 8.99m, "Entradas"),
                new Pedidos("Sopa de tomate", 0, 6.99m, "Entradas"),
                new Pedidos("Nachos con queso", 0, 9.99m, "Entradas"),
                
                // Platos principales
                new Pedidos("Filete de salmón", 0, 18.99m, "Platos principales"),
                new Pedidos("Pollo a la parrilla", 0, 15.99m, "Platos principales"),
                new Pedidos("Pasta Alfredo", 0, 13.99m, "Platos principales"),
                new Pedidos("Pizza Margherita", 0, 14.99m, "Platos principales"),
                
                // Postres
                new Pedidos("Tarta de manzana", 0, 6.99m, "Postres"),
                new Pedidos("Helado de vainilla", 0, 4.99m, "Postres"),
                new Pedidos("Brownie con helado", 0, 7.99m, "Postres"),
                
                // Bebidas
                new Pedidos("Refresco", 0, 2.99m, "Bebidas"),
                new Pedidos("Jugo de naranja", 0, 3.99m, "Bebidas"),
                new Pedidos("Café", 0, 2.49m, "Bebidas"),
                new Pedidos("Agua mineral", 0, 1.99m, "Bebidas")
            };
        }


        public void mostrarPedidos()
        {
            List<Pedidos> p = ObtenerMenuCompleto();
            foreach (Pedidos pedidos in p)
            {

            }
        }
    }
}