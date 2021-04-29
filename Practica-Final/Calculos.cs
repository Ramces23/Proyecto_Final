using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Final
{
    class Calculos
    {

        public DateTime FechaIni = new DateTime();
        public DateTime FechaCon = new DateTime();
        public double MonPrestamo = 0;
        public double Interes = 0;
        public double IntMesNet = 0;
        public double MonInt = 0;
        public double Cuota = 0;
        public double Capital = 0;
        public double Plazo = 0;

        public void Calcular()
        {
            IntMesNet = Interes / 100;
            MonInt = MonPrestamo * IntMesNet;
            double b = Math.Pow((1 + IntMesNet), Plazo);
            Cuota = IntMesNet * MonPrestamo * b / (b - 1);
            Capital = Cuota - MonInt;
            //            Cuota = MonPrestamo * ((Math.Pow((1 + IntMesNet), Plazo)) * IntMesNet / (Math.Pow((1 + IntMesNet), Plazo)) - 1);
        }


        public void InFecha(String FechaString) { FechaCon = DateTime.Parse(FechaString); FechaIni = FechaCon.Date; }
            public void InMonPres(double pres) { MonPrestamo = pres; }
        public void InInterMes(double Inter) { Interes = Inter; }
        public void InInterAn(double Inter) { Interes = Inter / 12; }
        public void InPlazo(double Pla) { Plazo = Pla; }
        public void MenIn() { MonInt = MonPrestamo * IntMesNet; Capital = Cuota - MonInt; }
        public void InDatosMen()
        {
            Console.WriteLine("Introdusca a fecha de su primer pago en el siguiente formato YY,MM,DD ");
            InFecha(Console.ReadLine());
            Console.WriteLine("Digite el monto de su prestamo");
            InMonPres(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite su interes");
            InInterMes(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite su plazo de pago en meses");
            InPlazo(double.Parse(Console.ReadLine()));
        }

        public void InDatosAn()
        {
            Console.WriteLine("Introdusca a fecha de su primer pago en el siguiente formato YY,MM,DD ");
            InFecha(Console.ReadLine());
            Console.WriteLine("Digite el monto de su prestamo");
            InMonPres(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite su interes");
            InInterAn(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite su plazo de pago en meses");
            InPlazo(double.Parse(Console.ReadLine()));

        }

        public void MosTabla()
        {
            int c = 0;
            char L = 'A';
            Console.WriteLine("                     Menu                        ");
            Console.WriteLine(" Pago     Fecha de pago     Cuota             Capital           Interes           Balance");

            for (int i = 0; i <= Plazo; i++)
            {

                MenIn();
                Console.Write(" [{0}]", i);
                Console.Write("      ["+FechaIni.ToString("d")+"]");
                Console.Write("      [{0:N2}]", Cuota);
                Console.Write("      [{0:N2}]", Capital);
                Console.Write("      [{0:N2}]", MonInt);
                if (i == Plazo) { Console.Write("          [{0:N2}]\n", MonPrestamo); } else { Console.Write("      [{0:N2}]\n", MonPrestamo); }
                
                MonPrestamo -= Capital;
                FechaIni = FechaIni.AddMonths(1);
            }


        }
    }
}
