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
        private string FechaN;

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

        public string FechaN
        {
            get
            {
                return FechaN;
            }
            set
            {
                FechaN = value;
            }
        }

        public Persona()
        {
            Nombre = "";
            FechaN = "";
        }
        public override string ToString()
        {
            return "Nombre:"+ nombre+ "Fecha de nacimiento :"+ FechaN;
        }
    }
    
}
