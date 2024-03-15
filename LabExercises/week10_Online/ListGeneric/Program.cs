class Program
{
    public static void Main(string[] args)
    {
        List<int> list = [1, 3];
        list.Add(6);
        foreach(var elem in list) {
            Console.WriteLine(elem);
        }

        Dictionary<int, int> amounts = new Dictionary<int, int>() {{1, 3}, {1, 4}};

        int[] array = new int[5];


        
    }
}
