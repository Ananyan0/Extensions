namespace GenericList_Extension;

class Program
{
    
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        
        for(int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        foreach(int items in list)
        {
            Console.Write(items + " ");
        }
        Console.WriteLine();
        list.Reverse1();
        Console.WriteLine();
        List<int> sliced = list.Slice(1, 5);

        for(int i = 0; i < sliced.Count; i++)
        {
            Console.Write(sliced[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine(list.At(0));
    }
}