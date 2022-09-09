using Actividad_5.Models;
using Actividad_5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Controllers
{
    internal class ConductorController
    {
        private readonly IVista<Conductor> vista;

       public ConductorController(IVista<Conductor> vista)
        {
            this.vista = vista;           
        }

        public void Crear(string id, string identificacion, string nombre)
        {
            Conductor conductor;

            conductor = Conductor.Build(id, nombre, identificacion);

                this.vista.Render(conductor);
        }
    }
}
