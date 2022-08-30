using Actividad_3.CuerpoTecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Miembros
{
    internal class CuerpoMedico : ICuerpoTecnico
    {
        public void Entrenar()
        {
            Console.WriteLine("Se realiza ejercicios de recuperacion y preparacion fisica");
        }
    }
}
