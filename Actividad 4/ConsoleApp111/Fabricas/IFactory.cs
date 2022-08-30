using ConsoleApp111.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111.Fabricas
{
    internal interface IFactory
    {
        public Entity BuildEstudiante(int id);

        public Entity BuildProfesor(int id, string ingreso);

        public Entity BuildCoordinador(int id, string ingreso);

        public Entity BuildEscuela(int id, string nombre);
    }
}
