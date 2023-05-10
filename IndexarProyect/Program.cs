using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect
{

    //El código de cada ejercicio esta en la carpeta Models, en sus respectivos archivos.
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Palíndromo.
            Models.Palindromo pali = new Models.Palindromo();
            pali.getPalindromo();

            Console.WriteLine("---------");

            //Ejercicio 2: Fibonacci.
            Models.Fibonacci fibo = new Models.Fibonacci();
            fibo.getFibonacci();

            Console.WriteLine();
            Console.WriteLine("---------");

            //Ejercicio 3: Caluladora Notación Polaca.
            //String str = "5 + ( ( 1 + 2 ) *  4 ) -3";
            String result = Models.NotacionPolaca.getCalculadora();
            Console.WriteLine("Notación Polaca: "+result);


            Console.WriteLine("---------");

            Models.EcuacionCuadratica ecu = new Models.EcuacionCuadratica();
            ecu.getCuadratica();

            Console.WriteLine("---------");

            Models.Imc imc = new Models.Imc();
            imc.getIMC();
        }
    }
}
