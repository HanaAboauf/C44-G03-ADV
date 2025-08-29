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
        }
    }
}
