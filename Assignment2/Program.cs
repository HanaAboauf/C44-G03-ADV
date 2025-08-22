using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Assignment2
{

   
    internal class Program
    {

        public static void ReverseArray<T>(Queue<T>queue)
        {
            Queue<T> queue2 = queue;

            Stack<T> stack = new Stack<T>();
            while (queue2.Count > 0)
            {
                stack.Push(queue2.Dequeue());
            }

            queue2.Clear();

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
    

        }

        public static List<T> RemoveDuplicates<T>(List<T> list)
        {

            List<T>newList= new List<T>();

            foreach (T item in list) {
                if (!newList.Contains(item))
                {
                    newList.Add(item);
                }
            }
            return newList;

        }

        public static List<int> RemoveOddNumbers(List<int> list)
        {

            List<int> newList = new List<int>();

            foreach (int item in list)
            {
                if (item%2==0)
                {
                    newList.Add(item);
                }
            }
            return newList;

        }
        static void Main(string[] args)
        {
            #region Question01

            //Console.WriteLine("Enter the size of the array: ");

            //int size = int.Parse(Console.ReadLine()!);

            //int[] numbers = new int[size];

            //int counter = 0;

            //Console.WriteLine("Enter enter the number of the queries: ");

            //int queries = int.Parse(Console.ReadLine()!);
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter the number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine()!);
            //}

            //for (int i = 0; i < queries; i++)
            //{
            //    Console.WriteLine($"Enter the query 0{i + 1}: ");
            //    int query = int.Parse(Console.ReadLine()!);
            //    foreach (var item in numbers)
            //    {
            //        if (item >= query)
            //        {
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine($"The number of elements greater than or equal to 0{query} is: {counter}");
            //    counter = 0;

            //}
            #endregion

            #region Question02

            //Console.WriteLine("Enter the size of the array: ");

            //int size = int.Parse(Console.ReadLine()!);

            //List<int>numbers = new List<int>(size);

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter the number {i + 1}: ");
            //    numbers.Add(int.Parse(Console.ReadLine()!)); ;
            //}

            //int mid = size % 2==0?(size/2)+1: size / 2;

            //bool isPalindrome = true;

            //for (int i = 0; i < mid; i++)
            //{
            //    if (numbers[i] != numbers[size - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //if (isPalindrome)
            //{
            //    Console.WriteLine("The array is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The array is not a palindrome.");
            //}



            #endregion

            #region Question03

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //ReverseArray<int>(queue);


            #endregion

            #region Question04

            //Stack<string> parentheses = new Stack<string>();

            //string input = Console.ReadLine()!;

            //foreach (char item in input)
            //{
            //    if (item == '(' || item == '{' || item == '[')
            //    {
            //        parentheses.Push(item.ToString());
            //    }
            //    else if (item == ')' || item == '}' || item == ']')
            //    {
            //        if (parentheses.Count > 0)
            //        {
            //            string last = parentheses.Pop();
            //            if ((last == "(" && item != ')') ||
            //                (last == "{" && item != '}') ||
            //                (last == "[" && item != ']'))
            //            {
            //                Console.WriteLine("The parentheses are not balanced.");
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("The parentheses are not balanced.");
            //            return;
            //        }
            //    }


            //}

            //if (parentheses.Count == 0)
            //    Console.WriteLine("The parentheses are balanced.");
            //else
            //    Console.WriteLine("The parentheses are not balanced.");





            #endregion

            #region Question05

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3 };

            //List<int> newList = RemoveDuplicates<int>(list);

            //Console.WriteLine("List after removing duplicates: ");

            //foreach (int number in newList)
            //{
            //    Console.Write($"{number} ");
            //}

            #endregion

            #region Question06

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3 };

            //List<int> newList = RemoveOddNumbers(list);

            //Console.WriteLine("List after removing odd numbers: ");

            //foreach (int number in newList)
            //{
            //    Console.Write($"{number} ");
            //}


            #endregion

        }
    }
}
