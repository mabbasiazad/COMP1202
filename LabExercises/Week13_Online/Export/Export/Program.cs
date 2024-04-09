using System.Runtime.InteropServices;

class Export{
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\exports_small.csv";
        string exportOfIntrest = "coffee";
        using(StreamReader readObj = new StreamReader(filePath)){
            string line;
            while((line = readObj.ReadLine()) != null) {
                
                string[] items = line.Split(',');

                foreach(var item in items) {
                    if (item.ToLower().Contains(exportOfIntrest.ToLower())){
                        Console.WriteLine(items[0]);
                    }                    
                }             
            }
        }
    }
}