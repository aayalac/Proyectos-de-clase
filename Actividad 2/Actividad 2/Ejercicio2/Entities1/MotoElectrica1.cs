using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities1
{
    internal class MotoElectrica1 : Entity1
    {
        public override void Arrancar()
        {
            Console.WriteLine("Posee un motor Electrico");
        }
    }
}
