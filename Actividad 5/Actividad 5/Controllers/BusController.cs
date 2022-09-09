using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_5.Models;
using Actividad_5.Views;

namespace Actividad_5.Controllers
{
    internal class BusController
    {
        private IVista<Bus> vista;

        public BusController(IVista<Bus> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string ruta, Estacion estacion)
        {
            Bus bus;

            bus = Bus.Build(id, ruta);

            this.vista.Render(bus);
        }
    }
}
