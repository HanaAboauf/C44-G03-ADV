namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };

            //Dictionary<int, int> frequencyTable = new Dictionary<int, int>();
            //foreach (int number in numbers)
            //{
            //    if (frequencyTable.ContainsKey(number))
            //    {
            //        frequencyTable[number]++;
            //    }
            //    else
            //    {
            //        frequencyTable[number] = 1;
            //    }
            //}
            //foreach (var kvp in frequencyTable)
            //{
            //    Console.WriteLine($"Number: {kvp.Key}, Frequency: {kvp.Value}");
            //}
            #endregion

            #region Question02

            //Dictionary<string, int> hashtable = new Dictionary<string, int>() {
            //    { "a", 10 },
            //    { "b", 20 },
            //    {"c", 15 }
            //};

            //string keyWithHighestValue = null;

            //int highestValue = int.MinValue;

            //foreach (var kvp in hashtable)
            //{
            //    if (kvp.Value > highestValue)
            //    {
            //        highestValue = kvp.Value;
            //        keyWithHighestValue = kvp.Key;
            //    }
            //}
            //Console.WriteLine($"Key with highest value: {keyWithHighestValue}, Value: {highestValue}");


            #endregion

            #region Question03

            //Dictionary<string, int> hashtable = new Dictionary<string, int>()
            //{
            //    { "a", 10 },
            //    { "b", 20 },
            //    { "c", 15 },
            //    { "d", 10 },
            //    {"e", 30 }
            //};
            //Console.Write("Enter target value: ");
            //int targetValue = int.Parse(Console.ReadLine()!);
            //List<string> keysWithTargetValue = new List<string>();
            //foreach (var kvp in hashtable)
            //{
            //    if (kvp.Value == targetValue)
            //    {
            //        keysWithTargetValue.Add(kvp.Key);
            //    }
            //}
            //if (keysWithTargetValue.Count > 0)
            //{
            //    Console.WriteLine($"Keys with value {targetValue}: {string.Join(", ", keysWithTargetValue)}");
            //}
            //else
            //{
            //    Console.WriteLine("Key not found");
            //}

            #endregion

            #region Question04


            //string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
            //foreach (string str in strs)
            //{
            //    char[] charArray = str.ToCharArray();
            //    Array.Sort(charArray);
            //    string sortedStr = new string(charArray);
            //    if (anagramGroups.ContainsKey(sortedStr))
            //    {
            //        anagramGroups[sortedStr].Add(str);
            //    }
            //    else
            //    {
            //        anagramGroups[sortedStr] = new List<string> { str };
            //    }
            //}
            //foreach (var group in anagramGroups.Values)
            //{
            //    Console.WriteLine($"[{string.Join(", ", group)}]");
            //}



            #endregion

            #region Question05

            //int[] nums = { 1, 2, 3, 1 };
            //HashSet<int> seenNumbers = new HashSet<int>();
            //bool hasDuplicates = false;
            //foreach (int num in nums)
            //{
            //    if (seenNumbers.Contains(num))
            //    {
            //        hasDuplicates = true;
            //        break;
            //    }
            //    seenNumbers.Add(num);
            //}
            //Console.WriteLine(hasDuplicates ? "Array contains duplicates" : "No duplicates found");
            #endregion

            #region Question06

            //SortedDictionary<int, string> studentDirectory = new SortedDictionary<int, string>() {
            //    { 100, "John" },
            //    {104, "Emma" },
            //    {103, "David" },
            //    {102, "Sophia" }


            //};
            //studentDirectory.Remove(103);

            //foreach (var kvp in studentDirectory)
            //{
            //    Console.WriteLine($"Student ID: {kvp.Key}, Name: {kvp.Value}");
            //}

            #endregion

            #region Question07

            //SortedList<int, string> employeeDirectory = new SortedList<int, string>()
            //{
            //    { 102, "Alice" },
            //    { 101, "Bob" },
            //    { 104, "Charlie" },
            //    {103, "Diana" }
            //};
            //foreach (var kvp in employeeDirectory)
            //{
            //    Console.WriteLine($"Employee ID: {kvp.Key}, Name: {kvp.Value}");
            //}

            //int searchId = 102;
            //if (employeeDirectory.ContainsKey(searchId))
            //{
            //    Console.WriteLine($"\nEmployee with ID {searchId}: {employeeDirectory[searchId]}");
            //}
            //else
            //{
            //    Console.WriteLine($"\nEmployee with ID {searchId} not found.");
            //}

            //employeeDirectory.Remove(101);
            //Console.WriteLine("\nAfter removing employee with ID 101:");

            //foreach (var kvp in employeeDirectory)
            //{
            //    Console.WriteLine($"Employee ID: {kvp.Key}, Name: {kvp.Value}");
            //}


            #endregion

            #region Question08

            //int[] arr = { 1, 2, 4, 6, 3, 7, 8 };
            //int n = 8; 
            //HashSet<int> numberSet = new HashSet<int>(arr);
            //List<int> missingNumbers = new List<int>();
            //for (int i = 1; i <= n; i++)
            //{
            //    if (!numberSet.Contains(i))
            //    {
            //        missingNumbers.Add(i);
            //    }
            //}
            //Console.WriteLine($"Missing numbers: {string.Join(", ", missingNumbers)}");
            #endregion

            #region Question09


            //int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            //Console.WriteLine($"Unique numbers: {string.Join(", ", uniqueNumbers)}");

            #endregion

            #region Question10



            //Dictionary<string, int> originalHashtable = new Dictionary<string, int>()
            //{
            //    { "a", 10 },
            //    { "b", 20 },
            //    {"c", 30 }

            //};
            //Dictionary<int, string> swappedHashtable = new Dictionary<int, string>();
            //foreach (var kvp in originalHashtable)
            //{
            //    swappedHashtable[kvp.Value] = kvp.Key;
            //}
            //foreach (var kvp in swappedHashtable)
            //{
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            //}
            #endregion

            #region Question11


            //HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4 };
            //HashSet<int> setB = new HashSet<int>() { 3, 4, 5, 6 };
            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);
            //Console.WriteLine($"Union of Set A and Set B: {string.Join(", ", unionSet)}");


            #endregion

            #region Question12

            //Dictionary<string, int> hashtable = new Dictionary<string, int>()
            //    {
            //    { "apple", 10 },
            //    { "banana", 20 },
            //    { "apricot", 15 },
            //    { "blueberry", 25 },
            //    { "avocado", 30 }
            //};
            //Console.Write("Enter target character: ");
            //char targetChar = Char.Parse(Console.ReadLine()!);
            //int count = 0;
            //foreach (var kvp in hashtable)
            //{
            //    if (kvp.Key.StartsWith(targetChar))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Number of keys starting with '{targetChar}': {count}");

            #endregion



        }
    }
}
