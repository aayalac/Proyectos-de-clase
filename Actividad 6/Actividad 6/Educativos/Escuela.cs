using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_6.Entities;

namespace Actividad_6.Educativos
{
    internal class Escuela<T> : IEscuela<T> where T : Entity
    {
        private List<T> Matriculados { get; set; }

        public Escuela()
        {
           Matriculados = new List<T>();
        }

        public void Matricular(T obj)
        {
            
            obj.Id = "123";

            Matriculados.Add(obj);
        }
    }
}
