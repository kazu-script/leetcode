namespace Solutions.P0200_0299.P0271_EncodeAndDecodeStrings;

public static class P0271EncodeAndDecodeStrings
{
    private const char Separator = '^';
    
    public static string Encode(IList<string> strs)
    {
        string encoded = String.Empty;

        foreach (var word in strs)
        {
            encoded += $"{word.Length}{Separator}{word}";
        }

        return encoded;
    }

    public static List<string> Decode(string s)
    {
        List<string> decoded = [];
        string lengthString = String.Empty;
        bool separatorFound = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (separatorFound is false)
            {
                if (s[i] != Separator)
                {
                    lengthString += s[i];
                }
                else
                {
                    separatorFound = true;
                }
            }
            else
            {
                int length = Convert.ToInt32(lengthString);

                decoded.Add(s.Substring(i, length));
                
                lengthString = String.Empty;
                separatorFound = false;
                i += length - 1;
            }
        }

        if (lengthString.Equals("0"))
        {
            decoded.Add("");
        }

        return decoded;
    }
}