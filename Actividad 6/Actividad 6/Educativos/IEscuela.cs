using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_6.Entities;

namespace Actividad_6.Educativos
{
    internal interface IEscuela<T> where T : Entity
    {
        public void Matricular(T obj);
    }
}
