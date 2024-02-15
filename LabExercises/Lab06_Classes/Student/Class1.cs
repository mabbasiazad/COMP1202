namespace Lab06;

public class Student
{
    private string firstName;
    private string lastName; 
    public int Id; 
    private string major; 

    public string FirstName{
        set {
            firstName = value;
        }

        get{
            return firstName;
        }

    }

    public Student(string firstName, string lastName, int Id, string major ) {
        this.firstName = firstName; 
        this.lastName = lastName; 
        this.Id = Id; 
        this.major = major;
    }

    public override string ToString()
    {
        string msg =  "First Name: " + 
                    firstName + 
                    "\tLast Name: " + 
                    lastName + 
                    "\tStudent ID: "+
                    Id +
                    "\tMajor: " + 
                    major;  

        return msg;
    }

}
