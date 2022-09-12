using System;
using System.ComponentModel.DataAnnotations;

namespace PizzeriaDominio
{
    public class Cliente
    {
        public int Id {get; set;}
        [Required]
        public string Nombres {get; set;}
        [Required]
        public string Apellidos {get; set;}
        [Required]
        public string Email {get; set;}
        [Required]
        public int Edad {get; set;}
        [Required]
        public string Telefono {get; set;}
        [Required]
        public string Direccion {get; set;}
        public string Password {get; set;}
        public Producto Producto {get; set;}
        public Pedido Pedido {get; set;}
    }
}