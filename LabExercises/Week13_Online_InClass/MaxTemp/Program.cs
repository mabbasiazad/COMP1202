using System.ComponentModel.DataAnnotations;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        //creat an object for StreamReader
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\weather-2015-01-01.csv";
        using (StreamReader reader = new StreamReader(filePath)) {
            string line = null;
            // line = reader.ReadLine();  // I skipped the first line
            // line = reader.ReadLine();  // I read the second line
            // Console.WriteLine(line);
            // //Processing of the data
            // string[] values = line.Split(',');
            string time = values[0];
            string temp = values[1];
            // Console.WriteLine("Time" + time); 
            // Console.WriteLine("Temp" + temp); 


            //Split()
            
            line = reader.ReadLine(); //skip the first line
            double maxTemp = -1000; 
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line); // Output the contents of each line
            }

        }
        
    }
}