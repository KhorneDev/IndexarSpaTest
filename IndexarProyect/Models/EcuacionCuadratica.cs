using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect.Models
{
    class EcuacionCuadratica
    {
        public void getCuadratica()
        {
            //Variable para la ecuación.
            double a, b, c;

            //Variables para las formulas.
            double x1, x2;
            
            Console.WriteLine("Ecuación Cuadratica");

            //Asignación de valores para variables de ecuación.
            Console.WriteLine("Ingrese el valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            //Comienza el proceso de operaciones

            //Formula para la suma de la ecuación cuadratica.
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;

            //Formula para la resta de la ecuación cuadratica.
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;

            //Impresión de valores en pantalla
            Console.WriteLine("El valor de x1: " + x1);
            Console.WriteLine("El valor de x2: " + x2);
        }
       
    }
}
