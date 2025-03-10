/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

https://leetcode.com/problems/two-sum/description/
*/

/*
1. initialize Dictionary to hold value of differences between target and current number
2. 
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
