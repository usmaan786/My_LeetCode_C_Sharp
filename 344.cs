/* Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

https://leetcode.com/problems/reverse-string/description/
*/

public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length-1;

        while(left<right)
        {
            char sLeft = s[left];
            s[left] = s[right];
            s[right] = sLeft;

            left++;
            right--;
        }
        
    }
}
