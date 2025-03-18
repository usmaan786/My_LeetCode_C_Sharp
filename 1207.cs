/* Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

https://leetcode.com/problems/unique-number-of-occurrences/description/?envType=study-plan-v2&envId=leetcode-75
*/

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> uniqueMap = new Dictionary<int, int>();

        foreach(int num in arr)
        {
            if(uniqueMap.ContainsValue(num))
            {
                continue;
            }

            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==num)
                {
                    count++;
                }
            }

            if(!uniqueMap.ContainsKey(count))
            {
                uniqueMap.Add(count, num);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
