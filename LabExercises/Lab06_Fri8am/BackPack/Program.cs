namespace wee06_Fri8am; 
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class BackPack
{
    public int idNum; 
    public string mainColor;
    private int numStains;
    public int numStraps;

    // public BackPack(int id_num, string main_color, int num_stains, int num_straps){
    //     idNum = id_num;
    //     mainColor = main_color; 
    //     numStains = num_stains; 
    //     numStraps = num_straps;
    // }

    // BackPack this = new BackPack(....)
    //default constructor
    public BackPack() {

    }
    
    //user defined constructor
    public BackPack(int idNum, string mainColor, int numStains, int numStraps){
        this.idNum = idNum;
        this.mainColor = mainColor; 
        this.numStains = numStains; 
        this.numStraps = numStraps;
    }

    public void print(){
        string msg = "ID: " + idNum +
                    "\t\tColor: " + mainColor +
                    //"\t\tNum of Stains: " + numStains +
                    "\t\tNum of Straps: " + numStraps;

        Console.WriteLine(msg);
    }  

    //ToString methods called by Console.WriteLine()
    public override string ToString() {
        string msg = "ID: " + idNum +
                "\t\tColor: " + mainColor +
                //"\t\tNum of Stains: " + numStains +
                "\t\tNum of Straps: " + numStraps;
        
        return msg;
    }

    //Static class: The same for all objects
    public static void info() {
        Console.WriteLine("==========================================================");
        Console.WriteLine("This class is for defining back pack objects"); 
        Console.WriteLine("with their IDs, Colors, Cleanliness state, and features");
        Console.WriteLine("==========================================================\n");
    }

    public bool isClean(){
        Console.Write($"Is back pack {idNum} clean? ");
        if(numStains < 2){
            Console.WriteLine("Yes");
            return true;
        }

        Console.WriteLine("No");
        return false; 
    }
    public bool isBright() 
    {
        Console.Write($"Is back pack {idNum} bright? ");

        switch (mainColor) {
            case "orange":
            case "red":
            case "yellow":
                Console.WriteLine("Yes");
                return true;
            default:
                Console.WriteLine("No");
                return false;
        }

        // if ((mainColor == "red") || (mainColor == "yellow") || (mainColor == "orange")) {
        //     return true;
        // } 

        // return false; 

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //Practise: Use default constructor to creat an object ????
        
        //Creating an object / instance form my defined constructor
        //BackPack bp_3 = new BackPack(id_num: 3, main_color: "red", num_stains: 2, num_straps: 2);
        BackPack bp_3 = new BackPack(idNum: 3, mainColor: "red", numStains: 2, numStraps: 2);
        //bp_3.info();
        BackPack.info();
        bp_3.print();
        Console.WriteLine("print using ToString() method");
        Console.WriteLine(bp_3.ToString());
        // you can also delete ToString() form above line
        Console.WriteLine(bp_3);
        bp_3.isBright();

        bp_3.mainColor = "black"; 
        bp_3.print();
        bp_3.isBright(); 

        BackPack bp_4 = new BackPack(4, "green", 6, 2);
        //bp_4.info();
        BackPack.info();
        Console.WriteLine(bp_4);
        bp_4.isClean();

        //bp_4.numStains = 5;

         
        
    }
}
