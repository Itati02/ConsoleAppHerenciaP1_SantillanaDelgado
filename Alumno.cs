using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Alumno: Persona
    {
        private string matricula;
        private string especialidad;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Especialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
            }
        }

        public Alumno()
        {
            matricula = "";
            especialidad = "";
        }
        public Alumno(string nombre, string FechaN, string matricula, string especialidad) : base()
        {
            this.matricula = matricula;
            this.especialidad = especialidad;
        }

       

       
        public override string ToString()
        {
            return "Nombre:"+ Nombre+ "Fecha de nacimiento:"+ FechaN + "Matricula:"+ matricula+ "Especialidad: "+ especialidad;
        }

    }
}
