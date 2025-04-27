namespace GenericList_Extension;

public static class Extension
{
    public static void Reverse1(this List<int> list)
    {

        for(int i = list.Count - 1; i >= 0; i--)
        {
            Console.Write(list[i] + " ");
        }

    }

    public static List<int> Slice(this List<int> list, int start, int end)
    {
        if(start > end) return list;

        List<int> newList = new List<int>();
        for(int i = start; i <= end; i++)
        {
            newList.Add(list[i]);
        }

        return newList;
    }

    public static int At(this List<int> list, int index)
    {

        if(index >= 0) return list[index];

        return list[list.Count + index - 1];
    }
}