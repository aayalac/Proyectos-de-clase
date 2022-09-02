using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    internal class Bus : Entity
    {
        public string Ruta { get; private set; }        

        public Estacion Estacion { get; private set; }

        public List<PasajeroBus> PasajerosBus { get; private set; }

        public Bus(string id, string ruta, Estacion estacion): base(id)
        {
            this.Ruta = ruta;                        
            Estacion = estacion;
            PasajerosBus = new List<PasajeroBus>();
        }

        public void AddPasajero(string pasajeroId)
        {
            this.PasajerosBus.Add(new PasajeroBus(id: Guid.NewGuid().ToString(),busId: this.Id,pasajeroId: pasajeroId));
        }

    }
}