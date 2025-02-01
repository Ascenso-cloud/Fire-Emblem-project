using System.Data;
using System.Reflection.Metadata;

namespace project
{
    class Program
    {
        public static void Main()
        {
            int n;
            int m;
           
                Console.Clear();
                Console.WriteLine("Bienvenidos a Fire Emblem Escape");
                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para avanzar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("En el mundo en el que se desarrolla esta historia se han librado incontables batallas");
                Console.WriteLine("A lo largo de los distintos continentes se han erigido distintos heroes como baluartes");
                Console.WriteLine("de sus reinos");
                Console.WriteLine("No obstante,la catastrofe que se acercaba no tenia igual en la historia de esta realidad");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("A lo largo de los reinos se expandio una fuerza sobrenatural que arraso con las principales");
                Console.WriteLine("fortalezas de cada uno de los continentes al mismo tiempo que desaparecian los heroes de ");
                Console.WriteLine("cada uno de los reinos que con anterioridad lideraron a su pais a memorables exitos ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("          Marth,rey heroico,heroe primigenio de Archanea");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine("         Roy,estoque prodigioso de Pherae,heroe de Elibe");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine("           Hector,Hacha letal de Ostia,heroe de Elibe");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine("        Sigurd,jinete ilustre de Grannvale,heroe de Jugdral");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine("           Chrom,leyenda de Altea,segundo heroe de Archanea");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Estos heroes fueron transportados a un mundo distopico e inestable que rebosaba de energia");
                Console.WriteLine("caotica.");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Yune, Diosa del caos relegada al olvido por uno de los heroes mas grandes de la historia");
                Console.WriteLine("de este universo,Ike de Tellius,recibe a nuestros heroes en esta realidad distopica");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Con una expresion prepotente les comunica que para salvar a sus respectivos reinos");
                Console.WriteLine("necesitan completar el puzzle planteado por ella");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("No obstante,solo el primer heroe en completar el laberinto lograra volver a su pais");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Asi los heroes se lanzaron a la batalla para salvar tanto a sus reinos como a ellos mismos");
                Console.ReadKey();
                Console.Clear();
                 while (true)
            {
                Console.WriteLine("Escoja el tamaño del laberinto");
                Console.WriteLine("1-Pequeño");
                Console.WriteLine("2-Mediano");
                Console.WriteLine("3-Grande");


                string Eleccion = Console.ReadLine();
                if (Eleccion == "1")
                {
                    n = 8;
                    m = 8;

                    break;
                }
                if (Eleccion == "2")
                {
                    n = 12;
                    m = 12;

                    break;
                }
                if (Eleccion == "3")
                {
                    n = 18;
                    m = 18;

                    break;
                }
                Console.Clear();
            }
            Console.Clear();

            Maze Josue = new Maze(n, m);
            Josue.renderer();
        }

    }
}