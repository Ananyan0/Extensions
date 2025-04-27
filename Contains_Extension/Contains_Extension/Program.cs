namespace Contains_Extension;

static class Program
{
    public static bool Contains(this string str, string subString)
    {
        if (str.Length < subString.Length)
        {
            return false;
        }

        for (int i = 0; i < str.Length; i++)
        {
            bool isFound = true;
            for (int j = 0; j < subString.Length; j++)
            {
                if (str[i + j] != subString[j])
                {
                    isFound = false;
                    break;
                }
            }
            if (isFound)
            {
                return true;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        string str = "Hello world!";

        Console.WriteLine(str.Contains("oooo"));
    }
}