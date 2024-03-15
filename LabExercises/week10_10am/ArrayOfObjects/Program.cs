class Student
{
    //firstName , lastName, grade
    public string firstName;
    public string lastName;
    public double grade;

    //write a constructor
    public Student(){

    }
    public Student (string firstName, string lastName, double grade) {
        //initialize the class variables
        this.firstName = firstName;
        this.lastName = lastName;
        this.grade = grade;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //create 3 objects from the class student
        Student student_1 = new Student("a", "aa", 40); 
        Student student_2 = new Student("b", "bb", 80.5);
        Student student_3 = new Student("c", "cc", 60.2);

        int[] valueArray = new int[3] {1, 2, 3};
        
        //array of objects
        Student[] students = new Student[3]{student_1, student_2, student_3}; 

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(students[i].grade);            
        }



    }
}
