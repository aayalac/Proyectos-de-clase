using Actividad_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Views.Vehicle
{
    internal class CrearBus : IVista<Bus>
    {
        public void Render(Bus obj)
        {
            Console.WriteLine($"Se crea un bus asignado para la ruta {obj.Ruta}");
        }
    }
}
