/*https://leetcode.com/problems/sum-root-to-leaf-numbers/description/*/
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
public class Solution
{
    List<int> branchVal = new List<int>();

    public string SumNumbersString(TreeNode root, string previousRootNum = "")
    {
        string sum = "";

        if (root == null)
        {
            return "";
        }

        sum += previousRootNum + root.val.ToString();

        if (root.left != null)
        {
            Console.WriteLine(SumNumbersString(root.left, sum));
            if(root.left.left == null && root.left.right == null)
                branchVal.Add(Convert.ToInt32(SumNumbersString(root.left, sum)));
        }

        if (root.right != null)
        {
            Console.WriteLine(SumNumbersString(root.right, sum));
            if (root.right.left == null && root.right.right == null)
                branchVal.Add(Convert.ToInt32(SumNumbersString(root.right, sum)));
        }
            

        return sum;
    }

    public int SumNumbers(TreeNode root)
    {
        if (root.left != null || root.right != null)
            SumNumbersString(root);
        else if (root.left == null || root.right == null)
            return root.val;
        int result = 0;
        foreach (int sum in branchVal)
        {
            result += sum;
        }
        return result;
    }
}
