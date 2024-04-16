//Took 3 hours as well medium diff
//https://leetcode.com/problems/add-one-row-to-tree/?envType=daily-question&envId=2024-04-16
public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution 
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth) 
    {
        // If the depth is 1, create a new root node with the original root as its left child
        if (depth == 1) 
        {
            TreeNode newRoot = new TreeNode(val);
            newRoot.left = root;
            return newRoot;
        }
        
        DFS(root, val, depth, 1);
        return root;
    }
    
    private void DFS(TreeNode node, int val, int depth, int currentDepth) 
    {
        if (node == null) 
        {
            return;
        }
        
        // If we reach the desired depth, insert new nodes with the given value
        if (currentDepth == depth - 1) 
        {
            TreeNode leftNode = new TreeNode(val);
            TreeNode rightNode = new TreeNode(val);
            leftNode.left = node.left;
            rightNode.right = node.right;
            node.left = leftNode;
            node.right = rightNode;
            return;
        }
        
        // Continue DFS traversal
        DFS(node.left, val, depth, currentDepth + 1);
        DFS(node.right, val, depth, currentDepth + 1);
    }
}
