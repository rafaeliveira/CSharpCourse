using System;
using System.Collections.Generic;
using System.Text;

namespace HashSets
{
    class Exemplos
    {
        public void Exemplo()
        {
            int n = 0;

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Type a integer number: ");
            n = int.Parse(Console.ReadLine());

            /*
             * Contains
             */
            if (B.Contains(n))
            {
                Console.WriteLine("The value " + n + " belongs to the set!");
            }
            else
            {
                Console.WriteLine("The value " + n + " not belongs to the set!");
            }

            /*
             * Remove
             */
            //B.Remove(4);

            /*
             * Diferença entre conjuntos
             */
            A.ExceptWith(B);
            Console.WriteLine("Diferença entre conjuntos");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            /*
             * União de conuntos
             */
            A.UnionWith(B);
            Console.WriteLine("União de conuntos");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            /*
             * Intersecção de conuntos
             */
            A.IntersectWith(B);
            Console.WriteLine("Intersecção de conuntos");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
        }
    }
}
