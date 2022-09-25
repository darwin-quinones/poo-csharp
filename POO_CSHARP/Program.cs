using System;

namespace POO_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza oCerveza = new Cerveza(5, 6.5M, 30);
            oCerveza.Fermentacion();


            Leon oLeon = new Leon();
            oLeon.nombre = "Simba";
            oLeon.Correr();
            oLeon.Correr(10);
            oLeon.Correr(10, "Felizmente");
            oLeon.Correr("rapido");

            Buitre buitre = new Buitre();
            buitre.nombre = "Condorito";
            buitre.Volar();
            

        }
    }

}
