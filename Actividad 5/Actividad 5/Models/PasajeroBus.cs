using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    public class ConductorBus : Entity
    {    
        public string BusId { get; private set; }

        public string PasajeroId { get; private set; }        

        public ConductorBus(string id, string busId, string conductorId) : base(id)
        {
            this.BusId = busId;
            this.PasajeroId = conductorId;
        }        
    }
}
