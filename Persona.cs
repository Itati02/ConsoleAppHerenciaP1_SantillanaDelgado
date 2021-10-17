using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Persona
    {
        private string nombre;
        private string edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public Persona()
        {
            Nombre = "";
            Edad = "";
        }
        public override string ToString()
        {
            return "Nombre:"+ nombre+ "Edad:"+ edad;
        }
    }
    
}
