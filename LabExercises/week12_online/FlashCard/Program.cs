class Program
{
    public static void Main(string[] args)
    {
        string inputFile = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Texts\Questions.txt";
        //read the file line by line and show the content 
        StreamReader reader = new StreamReader(inputFile);
        string line;
        line = reader.ReadLine();  
        Console.WriteLine(line);
        string[] questioAnswer = line.Split(':');
        Console.WriteLine("Question: " + questioAnswer[0]);
        Console.WriteLine("Answer: " + questioAnswer[1]);


        reader.Close();

        
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();

        //using syntax for reading line by line
        using (StreamReader reader2 = new StreamReader(inputFile))
        {
            string line2;
            while ((line2 = reader2.ReadLine()) != null)
            {
                Console.WriteLine(line2);
                string[] questioAnswer2 = line2.Split(':');
                questions.Add(questioAnswer2[0]);
                answers.Add(questioAnswer2[1]);
            }        
        }

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"Question_{i}: " + questions[i]);
            Console.WriteLine($"Answer_{i}: " + answers[i]);
        }
        
    }
 
}