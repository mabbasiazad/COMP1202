class Program
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\Texts\Questions.txt";
        //exercise read the context of Questions.txt line by line
        //hint: StreamReader class 
        // 1.creating an object of StreamReader Class
        // 2. ReadLine() method of this class
        // 3. while structure to read all lines
        // 4. close the file I opened

        // StreamReader readerObj = new StreamReader(filePath);

        string line; 
        // line =  readerObj.ReadLine();
        
        // while (line != null) {
        //    Console.WriteLine(line);
        //    line = readerObj.ReadLine();     
        // } 

        // readerObj.Close(); // why????? Free my resource

        using (StreamReader readerObj_1 = new StreamReader(filePath)) {

        line =  readerObj_1.ReadLine();
        
        while (line != null) {
           Console.WriteLine(line);
           line = readerObj_1.ReadLine();     
        } 

        }

    }
}
