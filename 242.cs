/* Given two strings s and t, return true if t is an anagram of s, and false otherwise.

https://leetcode.com/problems/valid-anagram/description/
*/

/*
1. Create Dicitonaries (HashMaps) to count number of occurences of each character in both strings.
2. If the length of both strings aren't equal return false, the condition cannot be met.
2. Iterate through first string and count number of each character.
3. Iterate through second string and count number of each character.
4. Iterate through the keys in the first Dictionary
5. For each key get the value from said key in the second Dictionary, if not possible then return false condition cannot be met.
6. If the value of the key in the second Dictionary does not equal the value of the key in the first Dictionary, return false.
7. If for the loop concludes, return true as the condition was met.
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sCount = new Dictionary<char, int>();
        Dictionary<char, int> tCount = new Dictionary<char, int>();

        if(s.Length != t.Length)
        {
            return false;
        }

        foreach(char currChar in s){
            sCount.TryGetValue(currChar, out int count);
            sCount[currChar] = count + 1;
        }

        foreach(char currChar in t){
            tCount.TryGetValue(currChar, out int count);
            tCount[currChar] = count + 1;
        }

        foreach(char key in sCount.Keys)
        {
            if(tCount.TryGetValue(key, out int tValue))
            {
                int sValue = sCount[key];

                if(sValue != tValue)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        return true;
    }
}
/////////////////////////////////
/* This is a more optimized (cleaner) improvement to the solution
1. If the length of both strings aren't equal return false, the condition cannot be met.
2. Create a Dictionary to store the count of characters from both strings.
3. Iterate through the first string
4. Increment the occurence of the character in the first string in the Dictionary by 1.
5. Decrement the occurence of the character in the second string in the Dictionary by 1.
6. Iterate through values in the Dictionary, if a value is not 0 then return false.
7. If the for loop completes, return true.

*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false; 

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            charCount[s[i]] = charCount.GetValueOrDefault(s[i], 0) + 1;
            charCount[t[i]] = charCount.GetValueOrDefault(t[i], 0) - 1;
        }

        foreach (int count in charCount.Values) {
            if (count != 0) return false;
        }

        return true;
    }
}
