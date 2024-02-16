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

    // define a method called print() which prints out the varibles on the console
    // I want to use the method from outside of the class
    public void print() {
        string msg = "ID: " + idNum +
                    "\t\tMain Color: " + mainColor +
                    "\t\tNum of Stains: " + numStains + 
                    "\t\tNum of Straps: " + numStraps; 
        
        Console.WriteLine(msg); 

    }




    //methods for this class
}
public class Proram
{
  public static void Main(string[] args)
  {
    //create an "instance" or an "object" from my class (BackPack)
    BackPack bp_0 = new BackPack {
        idNum = 0, 
        mainColor = "black", 
        numStains = 0, 
        numStraps = 2
    };

    bp_0.print();
    bp_0.mainColor = "red";
    bp_0.print();


  }  
}
