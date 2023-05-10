using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect.Models
{
    class Fibonacci
    {
        public void getFibonacci()
        {
            //Variable para los 2 primeros digitos de la succesión.
            int var_valor1 = 0;
            int var_valor2 = 1;

            //Variable que almacena el limite de la sucesión.
            Console.WriteLine("¿Hasta que Numero quieres la succesión Fibonacci?");
            int var_numero = Convert.ToInt32(Console.ReadLine());

            //Mostramos el primer valor, 0.
            Console.WriteLine(var_valor1);

            //Bucle que empieza desde 0 y reccore hasta el dígito limite ingresado.
            for (int ind = 0; ind < var_numero; ind++)
            {
                //Se almacena el valor de la variable 1 en varible temporal.
                int var_temporal = var_valor1;

                //La variable1 pasa a tener el valor de la variable2.
                var_valor1 = var_valor2;

                //La variable2 pasa a tener el valor de la suma de la variable temporal + la variable 1, permitiendo la sucessión Fibonacci.
                var_valor2 = var_temporal + var_valor1;

                //Resultados
                Console.Write(var_valor1 + ", ");
                

            }
        }
    }
}
