namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };

            Dictionary<int, int> frequencyTable = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (frequencyTable.ContainsKey(number))
                {
                    frequencyTable[number]++;
                }
                else
                {
                    frequencyTable[number] = 1;
                }
            }
            #endregion
        }
    }
}
