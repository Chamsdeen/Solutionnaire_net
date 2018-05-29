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
            /*List<String> names = new List<String>() { "Pascal", "Felix", "Sam", "Xavier", "Pascal", "Éric", "Ben", "Felix" };
            List<string> unique_names = new List<string>();
        
            foreach(string name in names)
            {
                if (!unique_names.Contains(name))
                {
                    unique_names.Add(name);
                }
            }

            Console.WriteLine("Il y a " + unique_names.Count + " noms distincts");
            */
            // Exercice 3
            /* Stack<int> p1 = new Stack<int>();
             p1.Push(5); p1.Push(6); p1.Push(3); p1.Push(2);
             Stack<int> p2 = new Stack<int>();

             while (p1.Count > 0)
             {
                 int val = p1.Pop();
                 p2.Push(val);
             }
             */
            // Exercice 4
            /*Stack<int> p1 = new Stack<int>();
            p1.Push(5); p1.Push(6); p1.Push(3); p1.Push(2);
            Stack<int> p2 = new Stack<int>();

            while (p1.Count > 0)
            {
                int val = p1.Pop();
                p2.Push(val);
            }

            p1.Push(7);

           while (p2.Count > 0)
           {
               int val = p2.Pop();
               p1.Push(val);
           }*/
            // Exercice 5

            List<string> prenoms = new List<string>() { "Marc", "carl", "Marie", "Laurie" };

            var req = from p in prenoms
                      where p.ToUpper().StartsWith("M") || p.ToUpper().StartsWith("C")
                      select p;

            foreach(string s in req)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}
