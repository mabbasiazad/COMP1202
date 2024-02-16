namespace week06_Fri10am; 

class BackPack
{
    //variables
    //id, color, numStains, numStraps

    //public means: I can read/write the varible or method form outside the class
    public int idNum;
    public string mainColor;
    private int numStains; 
    public int numStraps; 

    //default construcor - mehtod by nature
    public BackPack() {

    }

    //user defined constructor
    // public BackPack(int id_num, string main_color, int num_stains, int num_straps) {
    //     //operations
    //     idNum = id_num;
    //     mainColor = main_color; 
    //     numStains = num_stains; 
    //     numStraps = num_straps;
    // }

        // BackPack this = new BackPack(....) (is hidden form us)
        public BackPack(int idNum, string mainColor, int numStains, int numStraps) {
        //operations
        this.idNum = idNum;
        this.mainColor = mainColor; 
        this.numStains = numStains; 
        this.numStraps = numStraps;
    }

    // define a method called print() which prints out the varibles on the console
    // I want to use the method from outside of the class
    
    public bool isBright() {
        //return mainColor == "red" || mainColor == "yellow" || mainColor == "orange";
        Console.Write($"Is back pack {idNum} bright? ");
        if (mainColor == "red" || mainColor == "yellow" || mainColor == "orange"){
            Console.WriteLine("Yes");
            return true;
        }

        Console.WriteLine("No");
        return false; 
    }

    public bool isClean() {
        Console.Write($"Is back pack {idNum} clean? ");
        if (numStains < 2){
            Console.WriteLine("Yes");
            return true;
        }

        Console.WriteLine("No");
        return false; 
    }


    
    public void print() {
        string msg = "ID: " + idNum +
                    "\t\tMain Color: " + mainColor +
                    //"\t\tNum of Stains: " + numStains + 
                    "\t\tNum of Straps: " + numStraps; 
        
        Console.WriteLine(msg); 

    }

    public override string ToString() {
        string msg = "ID: " + idNum +
                "\t\tMain Color: " + mainColor +
                //"\t\tNum of Stains: " + numStains + 
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
        //numStains = 0, 
        numStraps = 2
    };

    //bp_0.print();
    bp_0.mainColor = "red";
    bp_0.print();

    //Approach #2: using constructor to creat an object / instance
    BackPack bp_1 = new BackPack(); 
    // define: id = 1, color = blue, numStains = 5, numStraps = 1
    bp_1.idNum = 1; 
    bp_1.mainColor = "blue"; 
    //bp_1.numStains = 5; 
    //bp_1.numStraps = 1; 

    //Console.WriteLine("print by my print method");
    //bp_1.print();
    //Console.WriteLine("print by Console.WriteLine");
    Console.WriteLine(bp_1.ToString());
    // you can delet .ToString()
    //Console.WriteLine(bp_1);

    var bp_3 = new BackPack(idNum: 3, mainColor: "yellow", numStains: 4, numStraps: 0);
    Console.WriteLine(bp_3);

    // int[] numbers = {1 , 3, 5, 8}; 
    // foreach (int num in numbers)
    // {
    //     Console.WriteLine(num);
    // }

    // BackPack[] bp_lists = {bp_0,  bp_1, bp_3};

    // foreach (var bp in bp_lists)
    // {
    //     Console.WriteLine(bp.mainColor); 
    // }

    bp_0.isBright();
    bp_1.isBright();
    //bp_3.isBright();

    bp_1.mainColor = "orange"; 
    bp_1.isBright();

    bp_0.isClean();
    bp_1.isClean();
    bp_3.isClean();

    //Console.WriteLine("number of stains" + bp_0.numStains); 

  }  
}
