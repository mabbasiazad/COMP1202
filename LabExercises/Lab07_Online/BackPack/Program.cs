namespace week07;

class BackPack
{
    //variables/ fileds : (1)idNum, (2)mainColor, (3)numStains, (4)numStraps
    public int idNum; 
    public string mainColor;
    public int numStains; 
    public int numStraps;

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
        
        BackPack bp_0 = new BackPack {
            idNum = 0, 
            mainColor = "black", 
            numStains = 0, 
            numStraps = 0
        };

        bp_0.print(); 

        

    }
}