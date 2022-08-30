using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities1
{
    internal class MotoGasolina1 : Entity1
    {
        public override void Arrancar()
        {
            Console.WriteLine("La combustion de su motor es a Gasolina");
        }
    }
}
