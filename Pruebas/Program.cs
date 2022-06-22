using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string correo = "eden@c5.cdmx.gob.mx";
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
            if (emailRegex.IsMatch(correo))
            {
                Console.WriteLine("si");
            }
            else 
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
