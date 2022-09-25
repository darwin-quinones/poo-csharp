using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSHARP
{
    internal class Buitre: Carnivoro
    {
        public string colorPlumas { get; set; }


        public void Volar()
        {
            Console.WriteLine("El buitre voló");
        }
    }
}
