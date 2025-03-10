/*Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
https://leetcode.com/problems/contains-duplicate/description/
*/


/*
1. Create HashSet for each number in the array
2. Iterate through each number in nums
3. If the number is already in the Set then the condition is met and true is returned
4. Else the number is added to the set
5. If the for loop ends then false is returned, the condition was not met.
*/
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach(int num in nums){
            if(set.Contains(num))
            {
                return true;
            }
            else
            {
                set.Add(num);
            }
        }

        return false;
    }
}
