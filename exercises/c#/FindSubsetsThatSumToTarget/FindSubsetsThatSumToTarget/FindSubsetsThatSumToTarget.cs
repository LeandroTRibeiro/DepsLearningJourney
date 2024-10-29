namespace FindSubsetsThatSumToTarget;

public static class FindSubsetsThatSumToTarget
{
    public static List<List<int>> FindSubsets(this List<int> numbers, int target)
    {
        List<List<int>> response = new List<List<int>>();
        
        FindSubsetsRecursive(numbers, target, 0, new List<int>(), response);

        return response;
    }

    private static void FindSubsetsRecursive(List<int> numbers, int target, int index,
        List<int> currentSubset, List<List<int>> response)
    {
        if (currentSubset.Sum() == target)
        {
            response.Add(new List<int>(currentSubset));
        }

        for (int i = index; i < numbers.Count; i++)
        {
            currentSubset.Add(numbers[i]);
            
            FindSubsetsRecursive(numbers, target, i + 1, currentSubset, response);
            
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }
}