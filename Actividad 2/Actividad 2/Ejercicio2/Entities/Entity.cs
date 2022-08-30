using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities
{
    internal class Entity
    {
        public string Id { get; protected set; }
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Placa { get; protected set; }
        public string Cilindraje { get; protected set; }        

        public Entity(string id,string marca,string modelo ,string placa, string cilindraje)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cilindraje = cilindraje;
        }
    }
}
