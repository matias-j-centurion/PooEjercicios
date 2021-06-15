using System;
using Poo.Models;


namespace Poo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l1 = new Libro();
            // Enciclopedia e1 = new Enciclopedia();
            // Console.WriteLine("Ingrese 1 si quiere ver la informacion de una enciclopedia, 2 si quiere prestar/devolver un libro");
            // int opcion = Int32.Parse(Console.ReadLine());
            // if(opcion == 1)
            // {
            //     Console.WriteLine("Introducir el titulo de la Enciclopedia");
            //     e1.titulo = Console.ReadLine();
            //     Console.WriteLine("Introducir autor de la enciclopedia");
            //     e1.Autor = Console.ReadLine();
            //     Console.WriteLine("Introducir cantidad total de tomos de la enciclopedia");
            //     e1.tomos = int.Parse(Console.ReadLine());
            //     Console.WriteLine(e1.getInfoLibro());
            // }else if (opcion == 2)
            // {
            Console.WriteLine("Introducir titulo del libro");
            l1.Titulo = Console.ReadLine();
            Console.WriteLine("Introducir autor del libro");
            l1.Autor = Console.ReadLine();
            Console.WriteLine("Introducir cantidad total de copias del libro");
            l1.Copias = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir numero de unidades prestadas del libro");
            l1.Prestados = int.Parse(Console.ReadLine());
            Console.WriteLine(l1.getInfoLibro());
            // }
            Console.WriteLine("Si se pudo prestar o devolver el libro, aparecerá 'true', caso contrario, se leerá 'false'");

            Console.WriteLine("Si desea prestar un libro, presione 1. Si desea devolver un libro, presione 2");
            
            int opcion = Int32.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                if (l1.Prestar())
                {
                
                    Console.WriteLine($"Se ha prestado el libro {l1.titulo}");
                    
                }
                else
                {
                    Console.WriteLine($"No quedan copias de {l1.titulo} para prestar");
                }
            }
            else if (opcion == 2)
            {
                
                if (l1.Devolver())
                {
                   
                   Console.WriteLine($"Se ha devuelvo el libro {l1.titulo}");
                }
                else
                {
                    Console.WriteLine($"No se puede devolver {l1.titulo} ya que no hay unidades que devolver");
                }
            }
            else
            {
                Console.WriteLine("Opción Incorrecta");
            }
            

        }

    }
}
