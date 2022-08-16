﻿using System;
using System.Globalization;

namespace Retangulo
{

    class Program
    {

        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.CurrentCulture;

            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do retangulo: ");
			largura = double.Parse(Console.ReadLine(), CI);
			Console.Write("Altura do retangulo: ");
			altura = double.Parse(Console.ReadLine(), CI);

			area = largura* altura;
			perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));
        
			Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONA= " + diagonal.ToString("F4", CI));

        }
    }
}