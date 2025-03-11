/*Given an array of strings strs, group the anagrams together. You can return the answer in any order.

https://leetcode.com/problems/group-anagrams/description/
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] strArr = s.ToCharArray();
            Array.Sort(strArr);
            string sortedStr = new string(strArr);

            if(map.ContainsKey(sortedStr))
            {
                map[sortedStr].Add(s);
            }
            else
            {
                map[sortedStr] = new List<string> {s};
            }
        }

        return map.Values.ToList<IList<string>>(); 
    }
}
