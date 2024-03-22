class Program
{
    public static void Main(string[] args)
    {
        //creat the 2D array and display it in the console
        string[] students = new string[] {"Alex", "Sara"};
        int[,] grades = new int[2,4] {{10, 50, 60, 80}, {80, 90, 20, 70}};

        int n_rows = grades.GetLength(0);
        int n_cols = grades.GetLength(1);

        Console.WriteLine("number of rows: " + n_rows);
        Console.WriteLine("number of columns: " + n_cols);

        for (int i = 0; i < n_rows; i++) {
            int sum = 0;
            Console.Write($"Name: {students[i]}\t");
            Console.Write("Grades: ");
            for (int j = 0; j < n_cols; j++){
                Console.Write(grades[i,j] + " "); 
                sum = sum + grades[i,j];               
            }

            double ave = (double) sum / n_cols;
            Console.Write($"\tAverage: {ave}");
            Console.WriteLine();             
        }



        //display
    }
}