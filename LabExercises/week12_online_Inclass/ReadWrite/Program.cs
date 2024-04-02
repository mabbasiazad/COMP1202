//StreamReader  class to read the text file
class Program
{
    public static void Main(string[] args)
    {
        // I have a text file "C:\Texts\sampletext.txt" I want to the lines of this file
        //StreamReader class to do the job for me\
        //obj.ReadLine()
        // line == null line == ""

        string fileName = @"C:\Texts\sampletext.txt";
        StreamReader read = new StreamReader(fileName);

        string line = read.ReadLine(); 
        while (line != null) {
            Console.WriteLine(line);
            line = read.ReadLine();
        }

        read.Close(); //free 

        using (StreamReader read_ = new StreamReader(fileName))
        {
            string line_ = read.ReadLine(); 
            while (line_ != null) {
                Console.WriteLine(line_);
                line_ = read.ReadLine();
            }
        }    

            
    }    
}