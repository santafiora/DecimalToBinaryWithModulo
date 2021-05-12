using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryWithModulo
{
    class Program
    {      /// <summary>
           /// Doxygen Doku bzw. XML Format Doku
           /// Die Parameter aus der Main habe keine Bedeutung!
           /// </summary>
           /// <param name="args"></param>
        static void Main(string[] args)
        {

            int dezimalZahl;
            Console.WriteLine("Geben Sie eine Dezimalzahl ein:");


            dezimalZahl = Convert.ToInt32(Console.ReadLine());
            string ergebnisBinary = string.Empty;



            for (int i = 0; dezimalZahl > 0; i++)
            {
                ergebnisBinary = dezimalZahl % 2 + ergebnisBinary;
                dezimalZahl /= 2;
            }

            Console.WriteLine($"Die Binäre Zahl lautet: {ergebnisBinary}");
            Console.ReadKey();

        }
    }
}