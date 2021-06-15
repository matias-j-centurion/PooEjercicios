using System;

namespace Poo.Models
{
    public class Libro
    {
        public string titulo;
        public string Titulo
        {
            set { this.titulo = value; }
            get { return this.titulo; }
        }
        public string autor;
        public string Autor
        {
            set { this.autor = value; }
            get { return this.autor; }
        }
        public int copias;
        public int Copias
        {
            set { this.copias = value; }
            get { return this.copias; }
        }
        public int prestados;
        public int Prestados
        {
            set { this.prestados = value; }
            get { return this.prestados; }
        }
        public Libro()
        {
            //constructor por defecto
        }

        public Libro(string titulo, string autor, int copias, int prestados)
        {
            //Constructor
            this.titulo = titulo;
            this.autor = autor;
            this.copias = copias;
            this.prestados = prestados;
        }


        //Metodos

        public bool Prestar()
        {
            bool prest = true;
            if (prestados < copias)
            {
                prestados++;
            }
            else
            {
                prest = false;
            }
            Console.WriteLine(prest);
            return prest;
            ;

        }


        public bool Devolver()
        {

            bool dev = true;
            if (prestados == 0)
            {
                dev = false;
            }
            else
            {
                prestados--;
            }
            Console.WriteLine(dev);
            return dev;

        }
         public string getInfoLibro()
        {
            return $"El nombre del libro es {Titulo}, su autor es {Autor}. La cantidad de copias es {Copias} y la cantidad de copias prestadas es {Prestados}";
        }
        
    }
    
    
}
