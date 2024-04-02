class Program
{
    public static void Main(string[] args)
    {
        //names = {"Ali", "Sara", "Ben"}
        //names: Ali    Sara    Ben
        string[] names = new string[3]{"Ali", "Sara", "Ben"};
        Console.Write("names: ");
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"{names[i]}\t");
        }

        //grades = 86   90  45  68
        //         79   87  85  94
        //         80   75  50  75 
        int[,] grades = new int[3,4]{{86, 90, 45, 68} , {79, 87, 85, 94}, {80, 75, 50, 75}};
        //access operator
        int sample = grades[1, 3];
        Console.WriteLine();
        Console.WriteLine("the sample element in i = 1 ; j = 3 : " + sample);

        int n_rows = grades.GetLength(0);   // n_rows = 3
        int n_cols = grades.GetLength(1);   // n_cols = 4

        //loop over the rows of the 2D array
        for (int i = 0; i < n_rows; i++)
        {
            Console.Write("name: " + names[i] + "\t");
            Console.Write("Grades: ");

            int sum = 0;
            // loop over the columns when the row is fixed
            for (int j = 0; j < n_cols; j++)
            {
                Console.Write($"{grades[i,j]}" + " ");
                sum = sum + grades[i,j];
            }

            double ave = (double) sum / n_cols;

            Console.WriteLine("\tave: " + ave);
        }





    }
}
