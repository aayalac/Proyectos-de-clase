using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    public class Bus : Entity
    {
        public string Ruta { get; set; }        

        public List<PasajeroBus> PasajerosBus { get; set; }

        private Bus(string id, string ruta): base(id)
        {
            this.Ruta = ruta;            
            PasajerosBus = new List<PasajeroBus>();
        }

        public static Bus Build(string id, string ruta)
        {
            return new Bus(id, ruta);
        }

        public void AddPasajero(string pasajeroId)
        {
            this.PasajerosBus.Add(new PasajeroBus(id: Guid.NewGuid().ToString(),busId: this.Id,pasajeroId: pasajeroId));
        }

    }
}