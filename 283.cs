/* Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

https://leetcode.com/problems/move-zeroes/description/?envType=study-plan-v2&envId=leetcode-75*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length==1)
        {
            return;
        }

        int left = 0;
        int right = 1;

        while(right < nums.Length)
        {
            if(nums[left]==0 && nums[right] != 0)
            {
                nums[left] = nums[right];
                nums[right] = 0;

                left++;
                right++;
            }
            else if(nums[left] != 0){
                left++;
                right++;
            }
            else{
                right++;
            }
        }
    }
}


/*or an approach only swap non zeros so they get left at the end*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;

        for(int right = 0; right < nums.Length; right++)
        {
            if(nums[right] != 0)
            {
                if(left != right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
                left++;
            }
        }
    }
}
