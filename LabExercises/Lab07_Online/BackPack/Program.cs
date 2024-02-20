namespace week07;

class BackPack
{
    //variables/ fileds : (1)idNum, (2)mainColor, (3)numStains, (4)numStraps
    public int idNum; 
    public string mainColor;
    public int numStains; 
    public int numStraps;

    //default constructor
    public BackPack() {
        //do nothing 
    }

    // //user defined constructor (1)
    // public BackPack(int id_num, string main_color, int num_stains, int num_straps) {
    //     //operation is a bunch of variable assignment
    //     idNum = id_num;
    //     mainColor = main_color;
    //     numStains = num_stains;
    //     numStraps = num_straps;
    // }

    //user defined constructor
    // var this = new BackPack(...)
    public BackPack(int idNum, string mainColor, int numStains, int numStraps) {
        //operation is a bunch of variable assignment
        this.idNum = idNum;
        this.mainColor = mainColor;
        this.numStains = numStains;
        this.numStraps = numStraps;
    }

    public  bool isBright() {
        //if the color is "red"/"orange" /"yellow"
        // if the color is "red"/"orange"/"yellow" should say it's bright
        if (mainColor == "red" || mainColor == "orange" || mainColor == "yellow"){
            Console.WriteLine($"The back pack {idNum} of color {mainColor} is bright.");
            return true;
        }

        Console.WriteLine($"The back pack {idNum} of color {mainColor} is not bright.");
        return false;
   
    }

    public void print() {
        //print out all variables of back pack class
        string msg = $"The backpack number {idNum} is {mainColor} has {numStains} stains and {numStraps} straps";
        Console.WriteLine(msg);
    } 



}

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello world");
        // Create an object/instance from class BackPack
        // instantiation
        // First approach
        BackPack bp_0 = new BackPack {
            idNum = 0, 
            mainColor = "black", 
            numStains = 0, 
            numStraps = 0
        };

        bp_0.print(); 

        bp_0.mainColor = "blue";

        bp_0.print(); 

        //scond method to create an object / instance (of a class)
        //by using default constructor
        BackPack bp_1 = new BackPack();  
        bp_1.idNum = 1;
        bp_1.mainColor = "red";
        bp_1.numStains = 6;
        bp_1.numStraps = 2;

        bp_1.print();

        //third method to create an instance of a class
        //using user defined constructor
        // 1. I used constructor to crate an object
        // 2. I used constructor to initialize my class variables
        //BackPack bp_2 = new BackPack(id_num: 2, main_color: "yellow", num_stains: 4, num_straps: 1); 
        BackPack bp_2 = new BackPack(idNum: 2, mainColor: "yellow", numStains: 4, numStraps: 1); 
        BackPack bp_3 = new BackPack(3, "yellow", 4, 1); 

        bp_2.print();

        bp_0.isBright();
        bp_1.isBright();
        bp_3.isBright();

        // 





        

    }
}