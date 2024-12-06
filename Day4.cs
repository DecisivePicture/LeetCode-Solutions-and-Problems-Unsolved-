//Took 35 minutes, though is subpar compared to everybody else
public class Solution {
    public string AddSpaces(string s, int[] spaces)
    {
        List<char> result = s.ToList();
        int counter = 0;

        for(int i = 0; i < spaces.Length; i++)
        {
            result.Insert(spaces[i] +counter, ' ');
            counter++;
        }
        return String.Concat(result);   
    }
}
