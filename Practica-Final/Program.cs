using System;

namespace Practica_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Calculos Cal = new Calculos();
            Console.WriteLine("Bienvenido a la calculadora de prestamos ");
            Console.WriteLine("¿Su interes es Anual o Mensual? ");
            Console.WriteLine("Presione 1 para Anual o 0 para Mensual");


            y = int.Parse(Console.ReadLine());
            if (y == 0)
            {
                Console.Clear();
                Cal.InDatosMen();
                Console.Clear();
                Cal.Calcular();
                Cal.MosTabla();
            }
            else
            {
                
                Console.Clear();
                Cal.InDatosAn();
                Console.Clear();
                Cal.Calcular();
                Cal.MosTabla();
                
            }

            Console.WriteLine("Software creado por Ramces Batista Peña, gracias por su uso y espero que le halla sido util");

        }
    }
}
