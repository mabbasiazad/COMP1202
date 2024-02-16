using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class BackPack
{
    public int idNum; 
    public string mainColor;
    public int numStains;
    public int numStraps;

    // public BackPack(int id_num, string main_color, int num_stains, int num_straps){
    //     idNum = id_num;
    //     mainColor = main_color; 
    //     numStains = num_stains; 
    //     numStraps = num_straps;
    // }

    // var this = new BackPack(....)

    public BackPack(int idNum, string mainColor, int numStains, int numStraps){
        this.idNum = idNum;
        this.mainColor = mainColor; 
        this.numStains = numStains; 
        this.numStraps = numStraps;
    }

    public void print(){
        string msg = "ID: " + idNum +
                    "\t\tColor: " + mainColor +
                    "\t\tNum of Stains: " + numStains +
                    "\t\tNum of Straps: " + numStraps;

        Console.WriteLine(msg);
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
        //BackPack bp_3 = new BackPack(id_num: 3, main_color: "red", num_stains: 2, num_straps: 2);
        BackPack bp_3 = new BackPack(idNum: 3, mainColor: "red", numStains: 2, numStraps: 2);
        bp_3.print();
        bp_3.isBright();

        bp_3.mainColor = "black"; 
        bp_3.print();
        bp_3.isBright(); 
        
    }
}
