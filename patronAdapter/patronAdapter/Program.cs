using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
           /* // Instanciamos enchufe y taladro
            IEnchufeIngles enchufe = new EnchufeBritanico();
            Taladro taladro = new Taladro(enchufe);

            // Encendemos el taladro
            taladro.Encender();

            Console.ReadLine();

            // Instanciamos enchufe y taladro
            IEnchufeEuropeo enchufe1 = new EnchufeEspanol();
            Taladro taladro1 = new Taladro(enchufe);

            // Encendemos el taladro
            taladro.Encender();*/

            // Instanciamos el enchufe español, que es el que existe en nuestro país
            IEnchufeEuropeo enchufeEuropeo = new EnchufeEspanol();

            // Instanciamos el adaptador pasándole el enchufe español como parámetro
            IEnchufeIngles adaptador = new AdapterInglesEuropeo(enchufeEuropeo);

            // Creamos el taladro pasándole nuestro adaptador
            Taladro taladro = new Taladro(adaptador);

            // Encendemos el taladro
            taladro.Encender();

            Console.ReadKey();
        }
    }
}
