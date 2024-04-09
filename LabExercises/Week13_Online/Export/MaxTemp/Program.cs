using System.Runtime.CompilerServices;

class MaxTemp{
    
    public static void hottestTimeOfOneDay(string filePath){
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

            Console.WriteLine("Max Temp: " + MaxTemp + " at " + MaxTime);
        }        
    }
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\Week13_Online\weather-2015-01-01.csv";
        hottestTimeOfOneDay(filePath); 

        //exercise: write a method to find the max temp of the year
    }
}