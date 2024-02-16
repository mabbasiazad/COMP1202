namespace week06_Fri10am; 

class BackPack
{
    //variables
    //id, color, numStains, numStraps

    //public means: I can read/write the varible or method form outside the class
    public int idNum;
    public string mainColor;
    public int numStains; 
    public int numStraps; 

    //default construcor - mehtod by nature
    public BackPack() {

    }

    // define a method called print() which prints out the varibles on the console
    // I want to use the method from outside of the class
    public void print() {
        string msg = "ID: " + idNum +
                    "\t\tMain Color: " + mainColor +
                    "\t\tNum of Stains: " + numStains + 
                    "\t\tNum of Straps: " + numStraps; 
        
        Console.WriteLine(msg); 

    }

    public override string ToString() {
        string msg = "ID: " + idNum +
                "\t\tMain Color: " + mainColor +
                "\t\tNum of Stains: " + numStains + 
                "\t\tNum of Straps: " + numStraps; 
        return msg;

    }




    //methods for this class
}
public class Proram
{
  public static void Main(string[] args)
  {
    //create an "instance" or an "object" from my class (BackPack)
    // Approach #1
    BackPack bp_0 = new BackPack {
        idNum = 0, 
        mainColor = "black", 
        numStains = 0, 
        numStraps = 2
    };

    bp_0.print();
    bp_0.mainColor = "red";
    bp_0.print();

    //Approach #2: using constructor to creat an object / instance
    BackPack bp_1 = new BackPack(); 
    // define: id = 1, color = blue, numStains = 5, numStraps = 1
    bp_1.idNum = 1; 
    bp_1.mainColor = "blue"; 
    bp_1.numStains = 5; 
    bp_1.numStraps = 1; 

    bp_1.print();
    Console.WriteLine(bp_1.ToString());




  }  
}
