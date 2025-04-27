namespace IndexOf_Extension;
static class Program
{
    public static int IndexOf(this string str, string subString)
    {
        if (subString.Length > str.Length)
        {
            return -1;
        }


        for (int i = 0; i <= str.Length - subString.Length; i++)
        {
            bool matchFound = true;

            for (int j = 0; j < subString.Length; j++)
            {
                if (str[i + j] != subString[j])
                {
                    matchFound = false;
                    break;
                }
            }

            if (matchFound)
            {
                return i;
            }
        }

        return -1;
    }
    static void Main(string[] args)
    {
        string str = "Herlo world";

        Console.WriteLine(str.IndexOf("world"));
    }
}