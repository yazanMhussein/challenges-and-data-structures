using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] input = { 1, 2, 3, 1, 2, 3 };
        int[] result = FindDuplicates(input);

        Console.WriteLine($"Output: {string.Join(", ", result)}");
    }

    public static int[] FindDuplicates(int[] array)
    {
        // Dictionary to store the count of each element
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        // List to store the duplicates
        List<int> duplicates = new List<int>();

        // Traverse the array and count the occurrences of each element
        for (int i = 0; i < array.Length; i++)
        {
            int element = array[i];
            if (countMap.ContainsKey(element))
            {
                countMap[element]++;
            }
            else
            {
                countMap[element] = 1;
            }
        }

        // Collect elements that appear more than once
        foreach (var pair in countMap)
        {
            if (pair.Value > 1)
            {
                duplicates.Add(pair.Key);
            }
        }

        // Convert the list to an array and return
        return duplicates.ToArray();
    }
}
