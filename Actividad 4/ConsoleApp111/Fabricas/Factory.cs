using ConsoleApp111.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111.Fabricas
{
    internal class Factory : IFactory
    {
        public Entity BuildEstudiante(int id)
        {
            return new Estudiante(id);
        }

        public Entity BuildProfesor(int id, string ingreso)
        {
            return new Profesor(id, ingreso);
        }

        public Entity BuildCoordinador(int id, string ingreso)
        {
            return new Profesor(id, ingreso);
        }

        public Entity BuildEscuela(int id, string nombre)
        {
            return new Escuela(id, nombre);
        }
    }
}
