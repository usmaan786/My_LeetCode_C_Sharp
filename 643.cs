/* You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

https://leetcode.com/problems/maximum-average-subarray-i/description/?envType=study-plan-v2&envId=leetcode-75
*/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxAns = 0;
        double curr = 0;

        for(int i = 0; i < k; i++)
        {
            curr += nums[i];
        }

        maxAns = curr;

        for(int i = k; i < nums.Length; i++)
        {
            curr += nums[i] - nums[i-k];
            
            maxAns = Math.Max(curr, maxAns);
        }

        return (maxAns/k);
    }
}
