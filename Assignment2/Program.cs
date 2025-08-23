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
        public static void SearchTarget(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            while (stack.Count > 0)
            {
                count++;
                int current = stack.Pop();

                if (current == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Target was not found");
            }
        }

       public static List<int> FindIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

      
            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--; 
                }
            }

            return result;
        }

       public static void FindSubListWithSum(List<int> arr, int target)
        {
            int start = 0, currSum = 0;

            for (int end = 0; end < arr.Count; end++)
            {
                currSum += arr[end];

                while (currSum > target && start < end)
                {
                    currSum -= arr[start];
                    start++;
                }

                if (currSum == target)
                {
                    Console.Write("Contiguous sub list: [");
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(arr[i]);
                        if (i < end) Console.Write(", ");
                    }
                    Console.WriteLine("]");
                    return;
                }
            }

            Console.WriteLine("No sub list with the given sum found.");
        }


       public static Queue<int> ReverseFirstK(Queue<int> queue, int k)
        {
            if (queue == null || queue.Count == 0 || k > queue.Count || k <= 0)
                return queue;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
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

            #region Question07

            //Queue<object> queue = new Queue<object>();


            //queue.Enqueue(1);                   
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);       

            //Console.WriteLine("Queue contents:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item + " (Type: " + item.GetType().Name + ")");
            //}
            #endregion

            #region Question08

            //Stack<int> stack = new Stack<int>();

            //for (int i = 1; i <= 10; i++)
            //{
            //    stack.Push(i);
            //}

            //Console.Write("Enter the target number: ");
            //int target = int.Parse(Console.ReadLine()!);
            //SearchTarget(stack, target);
            #endregion

            #region Question09

            Console.Write("Enter size of first array: ");
            int size1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter size of second array: ");
            int size2 = int.Parse(Console.ReadLine()!);

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            Console.WriteLine("Enter elements of first array: ");
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Enter elements of second array: ");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine()!);
            }

            List<int> intersection = FindIntersection(arr1, arr2);

            Console.WriteLine("Intersection: ");
            Console.WriteLine("[" + string.Join(", ", intersection) + "]");


            #endregion

            #region Question10

            //List<int> arr = new List<int> { 1, 2, 3, 7, 5 };

            //Console.Write("Enter target sum: ");
            //int target = int.Parse(Console.ReadLine()!);

            //FindSubListWithSum(arr, target);

            #endregion

            #region Question11

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });

            //Console.Write("Enter K: ");
            //int k = int.Parse(Console.ReadLine()!);

            //Queue<int> result = ReverseFirstK(queue, k);

            //Console.WriteLine("Result: [" + string.Join(", ", result) + "]");
            #endregion



        }
    }
}
