using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Rational{
    public int numer;
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
        this.numer = x; 
        this.denom = y;
    }

    public  Rational neg() {
        int newNumer =  -numer;
        int newDenom = denom;
        Rational newObject = new Rational(newNumer, newDenom);
        return newObject;
        //return statement
    }

    public Rational add(Rational anotherR) {
        int newNumer =  numer * anotherR.denom + denom * anotherR.numer;
        int newDenom = denom * anotherR.denom;   //d1 * d2
        Rational newObject = new Rational(newNumer, newDenom);
        return newObject;
    }
    public override string ToString(){
        //
        string message = $"{this.numer} / {this.denom}";
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
        Console.WriteLine("My first rarional number: " + r1.ToString());
        
        // approach 1 for negation
        Rational r1_neg = new Rational(); 
        r1_neg.Numer = -r1.Numer;
        r1_neg.denom = r1.denom;
        Console.WriteLine("negative of r1: " + r1_neg);        
        

        //exercise: Step 2: use default constructor r2= 5 / 8
        Rational r2 = new Rational();
        r2.Numer = 5; 
        r2.denom = 8;
        Console.WriteLine("My second rational number: " + r2 );

        //second approach for negation
        Rational r2_neg = r2.neg();
        Console.WriteLine("negative of r2: " + r2_neg);

        Rational addResult = r1.add(r2);
        Console.WriteLine("the add result: " + addResult);
        
    }
}