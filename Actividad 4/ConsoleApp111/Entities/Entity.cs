using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111.Entities
{
    internal abstract class Entity
    {
        private string nombre;

        public int Id { get; protected set; }

        protected Entity(int id)
        {
            Id = id;
        }

        public Entity(int id, string nombre) : this(id)
        {
            this.nombre = nombre;
        }
    }
}