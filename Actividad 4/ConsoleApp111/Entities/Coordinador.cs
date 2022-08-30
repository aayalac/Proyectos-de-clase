using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111.Entities
{
    internal class Coordinador : Entity
    {
        public string Ingreso { get; private set; }

        public Coordinador(int id, string ingreso) : base(id)
        {
            Ingreso = ingreso;
        }
    }
}
