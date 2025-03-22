/*Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.

For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).

Two binary trees are considered leaf-similar if their leaf value sequence is the same.

Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

https://leetcode.com/problems/leaf-similar-trees/description/?envType=study-plan-v2&envId=leetcode-75
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        if(root1==null || root2 == null)
        {
            return false;
        }

        List<int> leaf1 = new List<int>();
        List<int> leaf2 = new List<int>();

        Dfs(root1, leaf1);
        Dfs(root2, leaf2);

        return leaf1.SequenceEqual(leaf2);

    }

    public void Dfs(TreeNode node, List<int> values)
    {
        if(node!=null )
        {
            if(node.left == null && node.right == null)
            {
                values.Add(node.val);
            }
            Dfs(node.left, values);
            Dfs(node.right, values);
        }
    }
}
