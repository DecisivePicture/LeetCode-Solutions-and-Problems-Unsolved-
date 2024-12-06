//1 Hour taken
public class Solution
{
    public int MaxCount(int[] _banned, int n, int maxSum)
    {
        HashSet<int> banned = new HashSet<int>(_banned);
        int sum = 0;
        int integers = 0;
        int intToAdd = 1;

        while (true)
        {
            if (banned.Contains(intToAdd))
            {
                intToAdd++;
            }
            else
            {
                if (sum + intToAdd <= maxSum && intToAdd <= n)
                {
                    integers++;
                    sum += intToAdd;
                    intToAdd++;
                }
                else break;
            }
        }
        
        return integers;
    }
}
