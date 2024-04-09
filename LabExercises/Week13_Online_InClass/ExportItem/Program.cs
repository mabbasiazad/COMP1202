using System.Runtime.CompilerServices;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\exportdata.csv";
        using(StreamReader reader = new StreamReader (filePath)) {
            string itemOfIntrest = "coffee";
            string line = reader.ReadLine(); //skip the first line 
            
            while((line = reader.ReadLine()) != null) {
                string[] values = line.Split(',');
                string country = values[0];
                foreach (var value in values)
                {
                    //Console.WriteLine(value); 
                    if (value.Contains(itemOfIntrest)) {
                        Console.WriteLine(country);
                    }
                }
            };  //read seccond line

        }
    }
}