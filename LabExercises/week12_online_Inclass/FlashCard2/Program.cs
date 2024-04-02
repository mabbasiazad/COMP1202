class Program
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\Texts\Questions.txt";
        //string filePath = @"C:\Texts\QuestionsDocx.docx";
        string[] questions = new string[10];
        string[] answers = new string[10];
        

        using(StreamReader read = new StreamReader(filePath)){
            string line = read.ReadLine();            
            //questionAnswer[0] (left side of the split)   questionAnswer[1] (right side of split)
            int count = 0;
            while (line != null)
            {
                string[] questionAnswer = line.Split(":");
                questions[count] = questionAnswer[0];
                answers[count] = questionAnswer[1];
                Console.WriteLine(line);
                line = read.ReadLine(); 
                count++;               
            }
        }

        for (int i = 0; i < answers.Length; i++)
        {
            Console.WriteLine($"Question_{i}: " + questions[i]);
            Console.WriteLine($"Answer_{i}: " + answers[i]);
            
        }
        
    }
}
