using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        //try to read Qestions.txt file and display the file line by line
        //use StreamReader class for this purpose
        // obj.ReadLine() method
        string filePath = @"C:\Texts\Questions.txt";

        
        /*
        By what initials was Franklin Roosevelt better known?:FDR
        Which number president was Franklin Roosevelt?:32
        Which state was Franklin Roosevelt born in?:New York
        In which year did Roosevelt become Governor of New York?:1929
        What was the name of Franklin Roosevelt's wife?:Eleanor
        How many children did Franklin Roosevelt have?:6
        From which university did Franklin Roosevelt graduate with an A.B in history?:Harvard
        What was the first name of Franklin Roosevelt's 5th cousin, who was also President?:Theodore
        Which disease is believed to be the causes of Franklin Roosevelt's paralysis?:Polio
        At what age did Franklin Roosevelt die?:63
        */

        // StreamReader strObj =  new StreamReader(filePath);
        // string line = ""; 
        // line = strObj.ReadLine();
        // while (line != null){
        //     Console.WriteLine(line);
        //     line = strObj.ReadLine();
        // }
        
        // strObj.Close();

        // using (StreamReader strObj_ =  new StreamReader(filePath)) {
        //     string line_ = ""; 
        //     line_ = strObj.ReadLine();
        //     while (line != null){
        //         Console.WriteLine(line_);
        //         line = strObj.ReadLine();
        // }

        string[] questions = new string[10]; 
        string[] answers = new string[10]; 

        using(StreamReader strObj_2 =  new StreamReader(filePath)) {
            string l = "";
            //reading from my file
            l = strObj_2.ReadLine();
            int count = 0;
            while(l != null){                
                // processing the data
                string[] questionAnswer = l.Split(":");
                questions[count] = questionAnswer[0];
                answers[count] = questionAnswer[1];
                count++;
                l = strObj_2.ReadLine();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Question_{i}: " + questions[i]);
                Console.WriteLine($"answer_{i}: " + answers[i]);
            }
                


        }   

        // read all lines and create an array of questons and answers     
    }
}
