using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    internal class Pasajero : Entity
    {
        public string Nombre { get; set; }

        public string Cedula { get; private set; }

        public List<PasajeroBus> PasajerosBus { get; private set; }

        public Pasajero(string id, string cedula, string nombre) : base(id)
        {
            Cedula = cedula;
            Nombre = nombre;
            PasajerosBus = new List<PasajeroBus>();
        }
        
        public void AddBus(string busId)
        {
            this.PasajerosBus.Add(new PasajeroBus(Guid.NewGuid().ToString(),busId,this.Id));
        }

    }
}
