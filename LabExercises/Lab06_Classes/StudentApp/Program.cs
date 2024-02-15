using Lab06;
public class Program
{
    public static void Main(string[] args)
    {
        Student student_1 = new Student("Jane", "Austin", 100, "Computer");
        Student student_2 = new Student("Adam", "Phillips", 101, "Math");
        Student student_3 = new Student("Haruki", "Murakami", 102, "Physics");
        
        //type[] variableName
        int[] numbers = {1, 3, 5};
        Student[] students = {student_1, student_2, student_3};
        
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
        
    }
}

