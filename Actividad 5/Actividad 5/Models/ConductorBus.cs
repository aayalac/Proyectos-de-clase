using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    internal class PasajeroBus : Entity
    {    
        public string BusId { get; private set; }

        public string PasajeroId { get; private set; }        

        public PasajeroBus(string id, string busId, string pasajeroId) : base(id)
        {
            this.BusId = busId;
            this.PasajeroId = pasajeroId;
        }        
    }
}
