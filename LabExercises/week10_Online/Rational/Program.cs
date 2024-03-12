using System.Runtime.InteropServices;

class Rational{
    private int numer;
    public int Numer{
        set {numer = value;} // writing the value numer
        get {return numer;}  // reading the value numer
    }


    public int denom;
    // Step 1:define constructor
    // identifier nameOfConstructor(inputs)
    public Rational() {
        // we don't have any operation here
    }
    public Rational(int x, int y){
        //initialize class variables
        numer = x; 
        denom = y;
    }

    public override string ToString(){
        //
        string message = $"{numer} / {denom}";
        return message;
    }

    


}

class Program {
    public static void Main(string[] args)
    {
        //Step 2: define an object/ instance of the class Rational
        int x = 2;
        int y = 3;
        Rational r1 = new Rational(x, y);

        //exercise: Step 2: use default constructor r2= 5 / 8
        Rational r2 = new Rational();
        r2.Numer = 5; 
        r2.denom = 8;
        // display the r1 object
        Console.WriteLine("My first rarional number: " + r1.ToString());
        Console.WriteLine("My second rational number: " + r2 );

        
    }
}