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

        }
    }
}
