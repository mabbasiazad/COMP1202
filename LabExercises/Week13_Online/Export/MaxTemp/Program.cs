using System.Globalization;
using System.Runtime.CompilerServices;

class MaxTemp{
    
    public static string[] hottestTimeOfOneDay(string filePath){
        string fileName = Path.GetFileName(filePath);
        string[] output = null;
        using(StreamReader reader = new StreamReader(filePath)){
            string line = null;  
            line = reader.ReadLine(); // Skip the first line
        
            string MaxTemp = null;
            string MaxTime = null;
            while((line = reader.ReadLine()) != null){
                string[] values = line.Split(',');
                string currenttime = values[0];
                string currentTemp = values[1];                
                if(MaxTemp == null){
                    MaxTemp = currentTemp;
                    MaxTime = currenttime;
                }

                else
                {
                    if(Double.Parse(currentTemp) > double.Parse(MaxTemp)){
                        MaxTemp = currentTemp;
                        MaxTime = currenttime;
                    }
                }
            }

            // Console.Write("Date: " + fileName + " "); 
            // Console.WriteLine("Max Temp: " + MaxTemp + " at " + MaxTime);

            output = new string[] {MaxTemp, fileName, MaxTime};
            return output;
        }    

           
    }
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\weather-2015-01-01.csv";
        //hottestTimeOfOneDay(filePath); 

        string directoryPath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\2015";
        string[] files = Directory.GetFiles(directoryPath);

        string[] tempDateTime = null; 
        // tempDateTime = hottestTimeOfOneDay(files[0]);
        // Console.Write("MaxTemp: " + tempDateTime[0] + "\t"); 
        // Console.WriteLine("Date: " + tempDateTime[1] + "\t" + "Time: " + tempDateTime[2]);

        List<Double> temps = new List<Double>();
        List<String> dates = new List<String>(); 
        List<String> times = new List<String>();

        foreach (string file in files)
        {
            tempDateTime = hottestTimeOfOneDay(file);
            temps.Add(double.Parse(tempDateTime[0])); 
            dates.Add(tempDateTime[1]);
            times.Add(tempDateTime[2]);
        }

        foreach (var temp in temps)
        {
            Console.Write(temp + " "); 
        }

        Console.WriteLine("\nMax of Maxs: " + temps.Max()); 

        double MaxOfMaxs = temps.Max();
        int index = temps.IndexOf(MaxOfMaxs); 

        Console.WriteLine("\nMax of Maxs: " + MaxOfMaxs + "\t" + "Index: " + index); 
        Console.WriteLine("Test: " + temps[index]);
        Console.WriteLine("Date: " + dates[index] + "\t" + "Time: " + times[index]); 
    }
}