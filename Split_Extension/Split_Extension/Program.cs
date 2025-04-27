namespace Split_Extension;
static class Program
{
    public static string[] Split(this string str, char seperator)
    {

        int sepCount = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == seperator)
            {
                sepCount++;
            }
        }

        string[] newStr = new string[str.Length - sepCount];

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != seperator)
            {
                newStr[i] += str[i];//bayluskoryuninshka
            }
        }

        return newStr;
    }
    static void Main(string[] args)
    {
        string str = ",baylus,Kor,yun,inshka,";

        string[] a = str.Split(",");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine(a[1]);
    }
}