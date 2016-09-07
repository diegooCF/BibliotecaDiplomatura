using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Editorial
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Editorial(int Id, string Descripcion)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
        }
    }
}
