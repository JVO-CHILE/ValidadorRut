using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorRut
{
    class Program
    {
        static void Main(string[] args)
        {
            String Rut = "12345678-5";

            Console.WriteLine(validarRut(Rut));
            Console.ReadKey();
        }

        private static bool validarRut(String Rut)
        {
            List<int> a, b;
            int aux, sum, digito;
            
            a = new List<int>();
            b = new List<int>();
            aux = 9;
            sum = 0;

            for (int i = Rut.Length - 3; i >= 0; i--)
            {
                a.Add((int)Char.GetNumericValue(Rut[i]));
                b.Add(aux);

                if (aux <= 9 && aux > 4)
                    aux--;
                else
                    aux = 9;
            }

            for (int i = 0; i < a.Count(); i++)
                sum += (a[i] * b[i]);

            digito = sum % 11;

            if (digito.Equals((int)Char.GetNumericValue(Rut[Rut.Length - 1])))
                return true;
            return false;
        }
    }
}
