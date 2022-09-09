using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5.Models
{
    public class Entity
    {
        public string Id { get; protected set; }        

        public Entity(string id)
        {
            this.Id = id;
        }        
    }
}