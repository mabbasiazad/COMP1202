class Program
{
    public static void Main(string[] args)
    {
        string[] names = new string[2] {"Mehdi", "Alex"};

        double[,] grades = new double[2,4] {{70, 80, 85, 40}, {85, 90, 20, 45}};

        Console.WriteLine("sample elemets of the 2D array:" + grades[1,1]);

        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.Write(names[i] + " ");
        // }

        // Console.WriteLine();

        int n_rows = grades.GetLength(0);
        int n_cols = grades.GetLength(1);

        int length = grades.Length;

        Console.WriteLine(grades.GetLength(2));

        // double sum;
        // double count = n_cols;

        // for (int i = 0; i < n_rows; i++)
        // {
        //     sum = 0;
        //     Console.Write($"Name: {names[i]}\t");
        //     Console.Write("Grades: ");
        //     for (int j = 0; j < n_cols; j++)
        //     {
        //         Console.Write(grades[i,j] + " ");
        //         sum = sum + grades[i, j];
        //     }

        //     double ave = sum / count;
        //     Console.Write($"\tave: {ave}");

        //     Console.WriteLine();
        // }

    }
}