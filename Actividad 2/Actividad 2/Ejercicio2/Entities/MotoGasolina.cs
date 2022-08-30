using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities
{
    internal class MotoGasolina:Entity
    {
        public MotoGasolina(string id,string marca,string modelo, string placa, string cilindraje) :base(id,marca,modelo,placa,cilindraje)
        {

        }

        public void ImprimirValores()
        {
            if (string.IsNullOrEmpty(Marca))
                throw new Exception("");
            else if (String.IsNullOrEmpty(Modelo))
                throw new Exception("");  

            Console.WriteLine($"{this.Marca} {this.Modelo} {this.Cilindraje}");
        }
    }
}
