using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7] { 5, 2, 9, 3, 8, 7, 4 };
            BublleSort(a);
            
           
            Console.WriteLine();
            SelectionSort(a);
            Console.WriteLine();
            InsertionSort(a);
            Console.WriteLine(LinearSearch());



        }
        public static void BublleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            foreach (int c in a)
            {
                Console.Write(c + " ");
            }
        }

        public static bool LinearSearch()
        {
           int[] a =new int[]{1,4,8,20,50,70 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 17)
                {
                    return true;
                }
            }
            return false;
        }
        public static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            foreach (int c in a)
            {
                Console.Write(c + " ");
            }
        }

    
      public static void InsertionSort(int[] a) {
        
        for (int i = 1; i<a.Length; i++) 
        {
                   int key = a[i];
                   int j = i - 1;

     
           while (j >= 0 && key<a[j]) 
                {
                  a[j + 1] = a[j];
                           --j;
                }

           a[j + 1] = key;
        }
        foreach(int i in a)
            {
                Console.Write(i+" ");
            }
      }

    }
}
