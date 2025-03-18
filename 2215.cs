/* Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
Note that the integers in the lists may be returned in any order.

 https://leetcode.com/problems/find-the-difference-of-two-arrays/description/?envType=study-plan-v2&envId=leetcode-75
 */

/*This isn't as efficient as it could be. Can use Array class's IndexOf method to just check the arrays to see if number is in the array instead of putting them in a Set*/

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        IList<int> list1 = new List<int>();
        IList<int> list2 = new List<int>();
        
        foreach(int num1 in nums1)
        {
            if(!set2.Contains(num1) && !list1.Contains(num1))
            {
                list1.Add(num1);
            }
        }

        foreach(int num2 in nums2)
        {
            if(!set1.Contains(num2) && !list2.Contains(num2))
            {
                list2.Add(num2);
            }
        }

        return new List<IList<int>>{list1, list2};
    }
}
