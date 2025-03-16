/* There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.  

https://leetcode.com/problems/find-the-highest-altitude/description/?envType=study-plan-v2&envId=leetcode-75
*/

public class Solution {
    public int LargestAltitude(int[] gain) {
        int[] prefix = new int[gain.Length+1];
        prefix[0] = 0;

        int ans = 0;

        for(int i = 0; i < gain.Length; i++)
        {
            prefix[i+1] = prefix[i] + gain[i];

            ans = Math.Max(ans, prefix[i+1]);
        }

        return ans;
    }
}
