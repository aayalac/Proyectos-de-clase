using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    internal class Conductor : Entity
    {
        public string Nombre { get; set; }

        public string Identificacion { get; private set; }        

        public List<ConductorBus> ConductoresBus { get; private set; }

        public Conductor(string id, string identificacion, string nombre) : base(id)
        {
            this.Identificacion = identificacion;
            ConductoresBus = new List<ConductorBus>();
            Nombre = nombre;
        }

        public void AddConductor(string pasajeroId)
        {
            this.ConductoresBus.Add(new ConductorBus(id: Guid.NewGuid().ToString(), busId: this.Id, conductorId: pasajeroId));
        }
    }
}
