using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_erxercises_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Program which checks if two Strings are Anagram or not?
            /*
            string one = "maria";
            string two = "mari";
            bool areAnagrams = AreStringsAnagrams(one, two);
            */
            //-----------------------------------------------------------------------
            //Write a function to print the nth number in Fibonacci series?
            /*
            int returnFibo = ReturnFibonacci(5);
            Console.WriteLine(returnFibo);
            */
            //------------------------------------------------------------------
            //Write a function to count a total number of set bits in a 32 - bit Integer?

            //SumofBits(56);
            //-----------------------------------------------------------------------
            //Write a function to remove duplicate characters from String?

            //ExtractStringDuplicates("aabbcc");
            //----------------------------------------------------------------------
            //How to find the 3rd element from the end, in a singly linked, in a single pass?
            //ShowNodeFromLinkedList()
            //------------------------------------------------------------------------
            //C# program to check if a number is Armstrong number or not?
            /*
            for (int i = 100; i < 10000; i++)
            {

                if (Armstrong(i))
                {
                    Console.WriteLine($"Your number {i} is an Armstrong number!");
                }
               
            }
            ----------------------------------------------------------------*/
            //Algorithm to check if a number is Prime or not?
            /*
                        if (CheckPrime(123))
                        {
                            Console.WriteLine($"Your Number is prime");
                        }
                        else
                        {
                            Console.WriteLine($"Your Number is anything but prime");
                        }
                        --------------------------------------------------------------------*/
            //Algorithm to check if a number is a Palindrome ?
            /*
             if (PalindromNumberCheck(12215))
            {
                Console.WriteLine("Your number is palindrome");

            }
            else
            {
                Console.WriteLine("This is not a palindrom");
            }
            -------------------------------------------------------------------*/
            //Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?
            //ReverseLinkedList();

            /*LinkedList<int> lista = new LinkedList<int>();
            lista.AddLast(10);
            lista.AddLast(20);
            lista.AddLast(30);
            lista.AddLast(40);
            ReverseLinkedList(lista);

           ------------------------------------------------------------------------------------------------*/
            //How to rotate an array by a given pivot?
            int[] array = new int[] { 2, 5, 8, 1, 6 };



            /*-----------------------------------------------------------------------------------------*/

            //Sorting an Array using Selection Sort
            /*
            int[] array = new int[] { 2, 5, 8, 1, 6 };

            SortArray(array);
                foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            -------------------------------------------------------------------------------------------*/
            //Sorting an Array using Bubble Sort
            /*
            int[] array = new int[] { 2, 5, 8, 1, 6 };
            BubbleSort(array);
            -------------------------------------------------------------------------------------------*/
            Console.ReadKey();


        }

        private static void BubbleSort(int[] array)
        {
            int contor = 0;
            do
            {
                contor = 0;
                for (int i = 0, j = i + 1; i < array.Length - 1; i++, j++)
                {
                    int temp = 0;
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        contor++;
                    }
                }
            } while (contor != 0);


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int index = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];
                        index = j;
                    }
                }

                int temp = array[i];
                array[i] = min;
                array[index] = temp;
            }
        }

        private static void ReverseLinkedList(LinkedList<int> lista)
        {
            int listaLength = lista.Count();
            LinkedList<int> lista2 = new LinkedList<int>();

            for (int i = 0; i < listaLength; i++)
            {
                LinkedListNode<int> nodeToTransfer = lista.Last;
                lista.Remove(lista.Last);
                lista2.AddLast(nodeToTransfer);

            }
            foreach (int item in lista2)
            {
                Console.WriteLine(item);
            }
        }

        private static bool PalindromNumberCheck(int x)
        {
            int[] array = new int[x.ToString().Length];

            bool palindrom = false;

            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                array[i] = int.Parse(x.ToString().Substring(i, 1));

                array[j] = int.Parse(x.ToString().Substring(j, 1));

                if (array[i] == array[j] && i != j)
                {
                    palindrom = true;
                }

            }
            if (palindrom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckPrime(int nr)
        {
            if (nr == 1)
            {
                return true;
            }
            for (int i = 2; i < nr / 2; i++)
            {
                if (nr % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        private static bool Armstrong(int nr)
        {
            double sum = 0;
            int nrToWork = nr;
            int power = nrToWork.ToString().Length;

            do
            {
                sum = sum + Math.Pow((nrToWork % 10), power);
                nrToWork = nrToWork / 10;

            } while (nrToWork > 0);

            if (sum == nr)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void ShowNodeFromLinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            LinkedListNode<int> node = new LinkedListNode<int>(10);
            lista.AddFirst(node);
            LinkedListNode<int> node2 = new LinkedListNode<int>(20);
            lista.AddAfter(node, node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(30);
            lista.AddAfter(node2, node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(40);
            lista.AddLast(node4);
            //lista.AddLast(50);
            int nodesTotal = lista.Count();
            int contor = nodesTotal - 2;

            var node1 = lista.First;

            for (int i = 1; i < contor; i++)
            {
                node1 = node1.Next;

            }
            Console.WriteLine(node1.Value);
        }

        private static void ExtractStringDuplicates(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 1);
                }
            }

            string output = string.Join("", dict.Keys);

            Console.WriteLine(output);
        }

        private static void SumofBits(int nr)
        {

            string binary = Convert.ToString(nr, 2);
            int sum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                sum = sum + int.Parse((binary[i]).ToString());
            }

            Console.WriteLine(sum);
        }

        private static int ReturnFibonacci(int nr)
        {
            int a = 0;
            int b = 1;
            int sum = 0;
            if (nr == 0 || nr == 1)
            {
                return nr;
            }
            for (int i = 1; i < nr; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }

        private static bool AreStringsAnagrams(string one, string two)
        {
            if (one.Length != two.Length)
            {
                return false;

            }
            var dict1 = AddToDictionary(one);
            var dict2 = AddToDictionary(two);

            foreach (var key in dict1.Keys)
            {
                if (!dict2.Keys.Contains(key) || dict2[key] != dict1[key])
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<char, int> AddToDictionary(string one)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < one.Length; i++)
            {
                char key = one[i];
                if (dict.ContainsKey(key))
                {
                    dict[key] = dict[key] + 1;
                }
                else
                {
                    dict.Add(key, 1);
                }

            }
            return dict;
        }
    }
}
