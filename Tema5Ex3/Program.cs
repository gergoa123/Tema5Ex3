using System;

namespace Tema5Ex3
{
    //Ex 3
    //Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
    //de caractere.Atat caracterul cautat cat si sirul de caracter vor fi citite de la
    //tastatura

    class Program
    {
        
        static void Main(string[] args)
        {
            int aux = 0;

            Console.WriteLine("Introduceti string-ul!");
            string string1 = Console.ReadLine();
            Console.WriteLine("Introduceti caracterul cautat");
            char caracter = Console.ReadLine()[0];

            for(int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == caracter )
                {
                    aux++;

                }

            }
            

            Console.WriteLine(" Caracterul apare in string de " + aux + " ori.");

        }
    }
}
