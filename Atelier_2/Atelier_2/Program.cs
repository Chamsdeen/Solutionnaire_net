using System;
using System.Collections.Generic;
using System.Linq;

namespace Atelier_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 1
            /*List<String> names = new List<String>(){ "Felix", "Sam", "Xavier", "Pascal", "Éric", "Ben" };
            foreach (string s in names)
            {
                Console.Write("\t" + s);
            }
            Console.WriteLine();
            int i = 2, j = 4;

            for(int index=i; index<=j/2; index++)
            {
                    string temp = names[index];
                    names[index] = names[j - index + i];
                    names[j - index + i] = temp;
            }
           
            foreach(string s in names)
            {
                Console.Write("\t" + s);
            }*/

            //Exercice 2
            List<String> names = new List<String>() { "Pascal", "Felix", "Sam", "Xavier", "Pascal", "Éric", "Ben", "Felix" };
            List<string> unique_names = new List<string>();
        
            foreach(string name in names)
            {
                if (!unique_names.Contains(name))
                {
                    unique_names.Add(name);
                }
            }

            Console.WriteLine("Il y a " + unique_names.Count + " noms distincts");
            Console.ReadKey();
        }
    }
}
