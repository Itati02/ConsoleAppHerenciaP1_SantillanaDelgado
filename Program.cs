using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona a = new Persona();
            Alumno b = new Alumno();

            Console.WriteLine("---Ingresar los datos solicitados---");
            Console.WriteLine("");
            Console.WriteLine("-DATOS DE LA PERSONA-");
            Console.WriteLine("Nombre :");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Edad :");
            a.Edad = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("DATOS DEL ALUMNO");
            Console.WriteLine("");
            Console.WriteLine("Nombre :");
            b.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Edad :");
            b.Edad = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Matricula:");
            b.Matricula = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Especialidad :");
            b.Especialidad = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("DATOS DE LA PERSONA=" + a.ToString());
            Console.WriteLine("DATOS DEL ALUMNO" + b.ToString());
            Console.ReadKey();



        }


    }
}
