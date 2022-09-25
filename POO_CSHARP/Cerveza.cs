using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSHARP
{
    public class Cerveza
    {
        public int amargor { get; set; }
        public decimal alcohol { get; set; }
        public int tiempoFermentacion { get; set; }


        // Contructor

        public Cerveza(int amargor, decimal alcohol, int tiemoFermentacion)
        {
            this.amargor = amargor;
            this.alcohol = alcohol;
            this.tiempoFermentacion = tiempoFermentacion;

        }



        // actions
         public void Fermentacion()
        {
            for (int i = 0; i < tiempoFermentacion; i++) ;
            // algo
            Console.WriteLine("Se fermentó");
        }
    }
}
