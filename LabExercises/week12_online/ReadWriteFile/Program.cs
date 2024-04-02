using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        string inputFile = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Texts\Questions.txt";
        //read the file line by line and show the content 
        StreamReader reader = new StreamReader(inputFile);
        string line;
        line = reader.ReadLine();
        
        while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        
        reader.Close();

        //using syntax for reading line by line
        using (StreamReader reader2 = new StreamReader(inputFile))
        {
            string line2;
            while ((line2 = reader2.ReadLine()) != null)
            {
                Console.WriteLine(line2);
            }        
        }


        //writng to a file with StreamWriter
        string outputFile = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Texts\output.txt";
        StreamWriter writer = new StreamWriter(outputFile);
        writer.WriteLine("Hello World!");
        writer.WriteLine("This is a test file.");
        writer.Close();

        //using syntax for writing to a file
        //true append mode false overwrite mode
        using (StreamWriter writer2 = new StreamWriter(outputFile, true))
        {
            writer2.WriteLine("Hello World for the second time!");
            writer2.WriteLine("This is a test file.");
        }

    }
}
    

