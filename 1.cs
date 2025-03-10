/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

https://leetcode.com/problems/two-sum/description/
*/

/*
1. initialize Dictionary to store each number
2. Iterate through the nums array
3. Find the difference with target -  current number (this will equal the number we need to reach the target)
4. Check the Dictionary to see if the number has been previously stored, if so then the answer is found. Return int array
5. If the loop ends then return empty array
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if(map.ContainsKey(difference))
            {
                return new int[] {map[difference], i};
            }

            map[nums[i]] = i;
        }

        return new int[0];
    }
}
