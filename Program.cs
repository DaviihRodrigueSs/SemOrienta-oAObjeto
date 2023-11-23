﻿using ClasseObjetoEAtributoTriangulo;
using System.ComponentModel.Design;
using System.Globalization;

namespace ClasseObjetoEAtributoTriangulo
{
    class program
    {
        static void Main(string[] args)
        {
            //calculando os dois lados de um triangulo sem orientação a objeto.

            Triangulo x, y;

            //instanciação de variável.

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");


            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));


            p = (y.A + y.B + y.C) / 2.0;


            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área X: ");

            }
            else
            {
                Console.WriteLine("Maior área Y: ");

            }









        }
    }
}