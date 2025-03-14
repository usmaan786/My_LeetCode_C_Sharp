/*You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75
*/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int w1 = 0;
        int w2 = 0;
        
        StringBuilder sb = new StringBuilder();

        while(w1 < word1.Length || w2 < word2.Length)
        {
            if(w1 < word1.Length)
            {
                sb.Append(word1[w1]);
                w1++;
            }
            if(w2 < word2.Length)
            {
                sb.Append(word2[w2]);
                w2++;
            }
        }

        return sb.ToString();
    }
}
