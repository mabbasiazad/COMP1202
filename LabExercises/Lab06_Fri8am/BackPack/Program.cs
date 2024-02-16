using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class BackPack
{
    public int idNum; 
    public string mainColor;
    public int numStains;
    public int numStraps;

    public BackPack(int id_num, string main_color, int num_stains, int num_straps){
        idNum = id_num;
        mainColor = main_color; 
        numStains = num_stains; 
        numStraps = num_straps;
    }

    public void print(){
        string msg = "ID: " + idNum +
                    "\t\tColor: " + mainColor +
                    "\t\tNum of Stains: " + numStains +
                    "\t\tNum of Straps: " + numStraps;

        Console.WriteLine(msg);
    }  

}

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}
