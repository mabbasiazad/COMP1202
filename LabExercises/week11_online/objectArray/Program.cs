using System.Diagnostics.Contracts;

class Student
{
    //define the variables firstName, lastName, grade
    private string firstName;
    private string lastName;
    private int grade;


    //user defined deconstructor
    public Student(string firstName, string lastName, int grade)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.grade = grade;
    }


    //override ToString method()
    public override string ToString()
    {
        string msg =  "First Name: " + 
                    firstName + 
                    "\tLast Name: " + 
                    lastName + 
                    "\t\tGrade: "+
                    grade ;
        return msg;
    }

    
}

class Program
{
    public static void Main(string[] args)
    {
        //some objects from our class
        Student student_1 = new Student("Mehdi", "Azad", 80); 
        Student student_2 = new Student("Clair", "Lee", 85); 
        Student student_3 = new Student("Sofiia", "Beliak", 90); 

        Console.WriteLine(student_1);

        int[] array = new int[3] {1, 2, 3};
        Student[] students = new Student[3]{student_1, student_2, student_3}; 

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }
        
        foreach(Student item in students){
            Console.WriteLine(item);

        }








        //print the objects
        
    }
}