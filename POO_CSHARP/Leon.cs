using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSHARP
{
    public class Leon: Carnivoro
    {
        public string colorCabello { get; set; }

        private int velocidadDefecto = 20;

        // la sobre carga en la que permite crear metodos con el mismo nombre
        // pero con acciones diferentes
        public Leon()
        {
            if(this.nombre == null || this.nombre.Equals(""))
               this.nombre = "Leon";

            Console.WriteLine("Carga de datos de la base de datos");
        }

        // this() indica que se ejecuta este constructor
        // pero que tambien va a ejecutar el principla
        public Leon(string nombre): this()
        {
            this.nombre = nombre;
        }

        public Leon(string nombre, int velocidad) : this()
        {
            this.nombre = nombre;
            this.velocidadDefecto = velocidad;
        }


        public void Correr()
        {
            Console.WriteLine("Corriendo: "+ velocidadDefecto);
        }

        public void Correr(int velocidad)
        {
            Console.WriteLine("Corriendo: "+ velocidad);
        }

        public void Correr(int velocidad, string detalle)
        {
            Console.WriteLine("Corriendo: " + velocidad + " " + detalle);
        }

        public void Correr(string detalle)
        {
            Console.WriteLine(detalle);
        }
    }
}
