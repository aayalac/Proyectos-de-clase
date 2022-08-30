using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities
{
    internal class MotoElectrica : Entity
    {
        public double HorasCarga { get; private set; }

        public MotoElectrica(string id, string marca,string modelo, string placa,string cilindraje , double horasCarga) : base(id,marca,modelo,placa,cilindraje)
        {
            HorasCarga = horasCarga;
        }
    }
}
