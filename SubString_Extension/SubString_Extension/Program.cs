namespace SubString_Extension;
static class Program
{
    public static string SubString(this string str, int start, int end)
    {
        if (start > end || start < 0 || end >= str.Length)
        {
            return "";
        }

        string newStr = "";
        for (int i = start; i <= end; i++)
        {
            newStr += str[i];
        }

        return newStr;
    }
    static void Main(string[] args)
    {
        string str = "Hello world!";

        Console.WriteLine(str.SubString(1, 1));
    }
}