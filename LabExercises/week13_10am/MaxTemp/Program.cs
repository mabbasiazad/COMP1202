using System.Runtime.CompilerServices;

class Program
{
    public static string[] hottestOfDay(string filePath){
        using(StreamReader reader = new StreamReader(filePath)){
            string fileName = Path.GetFileName(filePath);   //file name represents the date of the day
            string[] output = null;   //new line
            string line = reader.ReadLine(); //skip the first line            
            string maxTemp = null; 
            string maxTime = null;
            while ((line = reader.ReadLine()) != null) {
                //split the line
                string[] values = line.Split(",");
                string currentTime = values[0];
                string currentTemp = values[1];
                if (maxTemp == null) {
                    maxTemp = currentTemp;
                    maxTime = currentTime;
                }
                else if (double.Parse(currentTemp) > double.Parse(maxTemp)) {
                   maxTemp = currentTemp;
                   maxTime = currentTime;   
                }
            }            
            
            Console.WriteLine("Max Temp: " + maxTemp + " at " + maxTime + " on " + fileName);
            output = new string[3]{maxTemp, maxTime, fileName};  //new line
            return output;
        }
    }
    public static void Main(){
        // string filePath = @"C:\Users\mabba\Downloads\2015\weather-2015-01-01.csv";
        // string[] tempTime = hottestOfDay(filePath);  //add new line
        // Console.WriteLine("Max Temp: " + tempTime[0] + " at " + "Time: " + tempTime[1]);

        string directoryPath = @"C:\Users\mabba\Downloads\2015";
        string[] files =  Directory.GetFiles(directoryPath);

        foreach (var file in files)
        {
            //Console.WriteLine(file);
            hottestOfDay(file);
        }
  
        
    }
}