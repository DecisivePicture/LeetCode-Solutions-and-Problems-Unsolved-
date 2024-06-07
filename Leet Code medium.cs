//difficulty medium, time taken 2 hours
public class Solution
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        // Sort the dictionary by length first, then alphabetically
        var sortedDictionary = dictionary.OrderBy(word => word.Length).ThenBy(word => word).ToList();

        // Split the sentence into words
        string[] words = sentence.Split(' ');

        // Replace words in the sentence with the shortest root in the dictionary
        for (int i = 0; i < words.Length; i++)
        {
            foreach (string root in sortedDictionary)
            {
                if (words[i].StartsWith(root))
                {
                    words[i] = root;
                    break;  // Once replaced, no need to check further
                }
            }
        }

        // Join the words back into a single sentence
        return string.Join(" ", words);
    }
}
