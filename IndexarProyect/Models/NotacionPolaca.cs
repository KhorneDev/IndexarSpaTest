using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect.Models
{
    class NotacionPolaca
    {

        public static String getCalculadora()
        {
            Console.WriteLine("Ingresa la formula Matematica: [EJEMPLO: 5 + ( ( 1 + 2 ) *  4 ) -3]");
            String input = Console.ReadLine();

            //Variable para recoguer la pila de resultados.
            Stack<char> pila = new Stack<char>();

            //Variable que almacena parametro de entrada sin espacios.
            String str = input.Replace(" ", string.Empty);

            //Variable para hacer calculadora Polaca.
            StringBuilder formula = new StringBuilder();

            //Bucle que empieza en 0 y recorre el largo de la cadena.
            for (int i = 0; i < str.Length; i++)
            {

                //Variable que almacena la posición del indice.
                char x = str[i];

                //Validación para conocer si es que existen parentesis, a lo que lo enviamos a la pila.
                if (x == '(')
                    pila.Push(x);

                //Validación cierre de parentesis.
                else if (x == ')')
                {

                    //Bucle para hacer funcional la pila en los parentesis. Con el Pop se remueve de la pila
                    while (pila.Count > 0 && pila.Peek() != '(')
                        formula.Append(pila.Pop());
                    pila.Pop();
                }
                //Validacion para conocer un digito.
                else if (Digito(x))
                {
                    //Se agrega al top de la pila.
                    formula.Append(x);
                }

                //Validacion para conocer un operador.
                else if (Operador(x))
                {
                    //Bucle que hace funcionar la pila para los operadorees, el fin es deajarlos al final del resultado.
                    while (pila.Count > 0 && pila.Peek() != '(' && Prioridad(x) <= Prioridad(pila.Peek()))
                        formula.Append(pila.Pop());
                    pila.Push(x);
                }
                //Validación ni digitos ni operadores.
                else
                {
                    char y = pila.Pop();
                    if (y != '(')
                        formula.Append(y);
                }
            }
            //Bucle para organizar y devolver resultado.
            while (pila.Count > 0)
            {
                formula.Append(pila.Pop());
            }
            return formula.ToString();
        }

        //Identificador de operadores aritmeticos.
        static bool Operador(char c)
        {
            return (c == '-' || c == '+' || c == '*' || c == '/');
        }

        //Identificador Digitos.
        static bool Digito(char c)
        {
            return (c >= '0' && c <= '9' || c == '.');
        }

        //Identificador de prioridad.
        static int Prioridad(char c)
        {
            switch (c)
            {
                case '=':
                    return 1;
                case '+':
                    return 2;
                case '-':
                    return 2;
                case '*':
                    return 3;
                case '/':
                    return 3;
                case '^':
                    return 4;
                default:
                    throw new ArgumentException("Parámetro Rossz");
            }
        }
    }
}
