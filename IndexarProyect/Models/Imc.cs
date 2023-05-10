using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexarProyect.Models
{
    class Imc
    {
        public void getIMC()
        {
            //Variables para el calculo IMC y mensajes.
            double imc, peso, estatura;
            String mostrar;
            String mostrar2;

            Console.WriteLine("Calcular IMC");

            //Valor del peso en KG.
            Console.WriteLine("Digite Peso en Kg: ");
            peso = double.Parse(Console.ReadLine());

            //Valor de estatura en cm.
            Console.WriteLine("Digite Estatura en metros [EJEMPLO: 1,83]: ");
            estatura = double.Parse(Console.ReadLine());

            //Formula cálculo de IMC.
            imc = Math.Round(peso/(double)Math.Pow(estatura,2),2);

            //Validación según el IMC.
            if(imc < 18)
            {
                mostrar = "Peso Bajo. Necesario valorar signos de desnutrición.";
                Console.WriteLine("Tu IMC es de "+imc + " lo que signfica "+mostrar);
            }else if(imc >= 18 && imc <= 24.9 ){
                mostrar = "Peso normal.";
                Console.WriteLine("Tu IMC es de " + imc + " lo que signfica " + mostrar);
            }
            else if (imc >= 25 && imc <= 26.9)
            {
                mostrar = "Sobrepeso.";
                Console.WriteLine("Tu IMC es de " + imc + " lo que signfica " + mostrar);
            }
            else if (imc > 27)
            {
                mostrar = "Obesidad. ";
                Console.WriteLine("Tu IMC es de " + imc + " lo que signfica " + mostrar);
                if (imc >= 27 && imc <= 29.9) {
                    mostrar2 = " Obesidad grado I. Riesgo relativo alto para desarrollar enfermedades cardiovasculares.";
                    Console.Write(mostrar2);
                }
                else if (imc >= 30 && imc <= 39.9) {
                    mostrar2 = " Obesidad grado II. Riesgo relativo muy alto para desarrollar enfermedades cardiovasculares.";
                    Console.Write(mostrar2);
                }
                else if (imc >= 40)
                {
                    mostrar2 = " Obesidad grado III Extrema o Morbida. Riesgo extramadamente alto para el desarrollo de enfermedades cardiovasculares.";
                    Console.Write(mostrar2);
                }
            }


        }
    }
}
