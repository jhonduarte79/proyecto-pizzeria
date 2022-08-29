using System;
using PizzeriaDominio;
using PizzeriaPersistencia;

namespace PizzeriaConsola
{
    class Program
    {
        private static IRepositorioTb_cliente _repoTb_cliente = new RepositorioTb_cliente(new PizzeriaPersistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("successful conexion!");
            CrearCliente();
        }
        private static void CrearCliente()
        {
            var cliente = new Cliente
            {
                Nombres = "jhon",
                Apellidos = "duarte",
                Email = "jfduarte79@gmail.com",
                Edad = 43,
                Telefono = "345672",
                Direccion = "cali, valle, colombia",
                Password = "3421"

            };
            _repoTb_cliente.CrearCliente(cliente);
        }
    }
}
