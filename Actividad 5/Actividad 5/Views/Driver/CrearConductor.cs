using Actividad_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Views.Driver
{
    internal class CrearConductor : IVista<Conductor>
    {
        public void Render(Conductor obj)
        {
            Console.WriteLine($"Un conductor ha sido creado con el Id {obj.Id} y nombre {obj.Nombre}");
        }
    }
}
