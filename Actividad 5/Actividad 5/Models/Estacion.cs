using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    internal class Estacion : Entity
    {
        public string Nombre { get; set; }

        public string Troncal { get; set; }

        public List<Bus> Buses { get; set; }

        //Constructor
        private Estacion(string id, string troncal, string nombre) : base(id)
        {
            Troncal = troncal;
            Buses = new List<Bus>();
            Nombre = nombre;
        }

        public static Estacion Build(string id, string troncal, string nombre)

        {
            return new Estacion(id, troncal, nombre);
        }

        //Metodo
        public void RegistroBuses(Bus bus)
        {
            this.Buses.Add(bus);
        }
    }
}