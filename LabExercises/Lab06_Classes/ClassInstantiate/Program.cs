using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace week06; 
public class BackPack
{
    public int idNum;
    public string mainColor;
    private int _numStain; 
    public int numStraps; 

    // defining property
    public int NumStain {
        set {
            _numStain = value;
        }

        get {
            return _numStain;
        }
    } 

    //default constructor
    public BackPack(){

    }

    //user defined constructor
    public BackPack(int idNum, string mainColor, int _numStain, int numStraps) {
        this.idNum = idNum;
        this.mainColor = mainColor; 
        this._numStain = _numStain; 
        this.numStraps = numStraps;
    }

    public Boolean isBright() {
        Console.Write($"Is back pack {idNum} bright? ");
        if (mainColor == "yellow" || mainColor =="red" || mainColor == "orange") {
            Console.WriteLine("Yes");
            return true;
        }
        
        Console.WriteLine("No");
        return false;
    }

    //static method vs. instance method
    public static void info(){
        Console.WriteLine("======================================================================");
        Console.WriteLine("This class is about creating beckpack objects");
        Console.WriteLine("with different colors, type of colors (dark/bright), and cleanliness");
        Console.WriteLine("======================================================================\n");
                
    }
    public Boolean isDirty() {
        Console.Write($"Is back pack {idNum} dirty? ");
        if (_numStain > 2) {
            Console.WriteLine("Yes");
            return true;
        }
        
        Console.WriteLine("No");
        return false;
    }
    public void print() {
        string msg = "ID: " + idNum + 
                    "\t\tColor: " + mainColor + 
                    //"\t\tNum of Stain: " + _numStain + 
                    "\t\tnumStraps: " + numStraps;
        
        Console.WriteLine(msg);
    }

    //ToString mehtod
    //public override string ToString()

}
public class CreateObject
{
    public static void Main(string[] args)
    {
        //Calling static method
        BackPack.info(); 
        
        //Creat an instance / object of a class : instatiating a class
        // First approch
        BackPack first_bp = new BackPack{
            idNum = 0,
            mainColor = "black", 
            //_numStain = 2,
            numStraps = 0
        }; 

        //accessing to the fields and properties
        first_bp.NumStain = 5; 

        //calling instace methods
        first_bp.print(); 
        first_bp.isBright(); 
        first_bp.isDirty(); 

        //second approach: using default constructor

        BackPack second_bp = new BackPack(); 
        second_bp.idNum = 1;
        second_bp.mainColor = "blue"; 
        //second_bp._numStain = 1;
        second_bp.numStraps = 2;

        second_bp.print(); 

        var third_bp = new BackPack(idNum: 2, mainColor: "yellow", _numStain: 1, numStraps: 0);
        third_bp.print(); 

    }
}