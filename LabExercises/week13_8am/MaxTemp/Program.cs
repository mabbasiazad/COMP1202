class MaxTemp {
    public static string[] hottestOfDay(string filePath) {
        string fileName = Path.GetFileName(filePath);   //file name represents the date
        string[] output = null;
        using (StreamReader reader = new StreamReader(filePath)) {
            string line = reader.ReadLine(); 

            string maxTemp = null;
            string maxTime = null;

            while((line = reader.ReadLine()) != null){
                //Console.WriteLine(line);
                string[] values = line.Split(",");
 
                string currentTime = values[0];
                string currentTemp = values[1];

                if(maxTemp == null) {
                    maxTemp = currentTemp;
                    maxTime = currentTime;
                }
                else if (double.Parse(currentTemp) > double.Parse(maxTemp)){
                    maxTemp = currentTemp; 
                    maxTime = currentTime;
                }
            }
            output = new string[3]{maxTemp, maxTime, fileName};
            return output;
        }       

    }
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\mabba\Downloads\2015\weather-2015-01-01.csv";
        string[] tempTimeDate = hottestOfDay(filePath);
        Console.WriteLine("Max Temp:" + tempTimeDate[0] + " at Time: " + tempTimeDate[1] + " on Date: " + tempTimeDate[2]);
        
    }
}