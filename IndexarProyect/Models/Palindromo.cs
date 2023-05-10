using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect.Models
{
    class Palindromo
    {
        //Metodo para ejercicio numero 1: Palíndromo
        public void getPalindromo()
        {
           //Variable que almacena la palabra a medir.
           Console.WriteLine( "Ingresa una palabra Palíndromo o no.");
           String var_texto = Console.ReadLine();
           String var_textoTemp = var_texto;

            //Vaidacion para saber si la palabra es vacio.
            if (var_texto != null)
            {

                //A modo de evitar errores llevamos la cadena a caracteres en minuscula. 
                var_texto = var_texto.ToLower();

                //Quitamos los espacios entre caracteres.
                var_texto = var_texto.Replace(" ", "");

                //Variable que almacena el largo de la cadena.
                int var_longitud = var_texto.Length;

                //Variable condicional para saber si es Palíndromo o no.
                bool var_igual = true;

                //Variable contadora para verificar posición de cada caracter en el bucle.
                int var_cotador = 0;

                //Bucle que empieza en la última letra y llega hasta 0, decrementandose.
                for(int ind=var_longitud-1;ind>=0;ind--)
                {

                    //Validación de Palindromo.
                    if (var_texto[ind] != var_texto[var_cotador])
                    {
                        var_igual = false;
                        break;
                    }
                    var_cotador++;
                }

                //Resultado según validación.
                if(var_igual == true)
                {
                    Console.WriteLine("La frase " + var_textoTemp + " SI es un Palíndromo.");
                }
                else
                {
                    Console.WriteLine("La frase " + var_textoTemp + " NO es un Palíndromo.");
                }
            }
        }
    }
}
