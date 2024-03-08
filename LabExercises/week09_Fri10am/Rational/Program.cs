using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Xml.Schema;

class Rational
{
    public int numer; 
    private int denom; 

    public int Denom {
        set {
            denom = value;
        }

        get {
            return denom;
        }
    }



    //default construcor
    public Rational() {

    }

    //user defined constructor
    public Rational(int x, int y) {
        numer = x;
        denom = y;
    }

    public Rational(int x) {
        //your code here
        numer = x;
        denom = 1;
    }

    //this as an obj inside the class this.numer
    public Rational add(Rational anotherR) {
        int newNumer = this.numer * anotherR.denom + this.denom * anotherR.numer;
        int newDenom  = this.denom * anotherR.denom;

        Rational obj = new Rational(newNumer, newDenom);

        return obj;
    }

    public Rational neg() {
        return new Rational(-numer, denom);
    }

    //override ToString() method
    public override string ToString(){
        //show your desired message when outputing / printing the object of class Rational
        string msg = $"{numer}/{denom}";

        return msg; 

    }
}

class Program
{
    public static void Main(string[] args)
    {
        // create an object or instance from my class
        // declare / assignment / intializae/ ... 
        Rational r1 = new Rational(x:2, y:3); 
        Console.WriteLine("the first rational number is: " + r1.ToString());

        //type(classname) nameforvarialble = new calltheconstructor
        Rational r2 = new Rational();
        // . (dot)is my access operator to varialbes class
        r2.numer = 5;
        r2.Denom = 8;         
        Console.WriteLine("the second rational number is: " + r2); 

        Rational r3 = new Rational(x:5); 
        Console.WriteLine("the second rational number is: " + r3); 
        
        Rational addResult = r1.add(r2);
        Console.WriteLine("the result of sume is: " + addResult);

        Rational negResult = r1.neg();
        Console.WriteLine("the result of negation is: " + negResult);

        var subResult = r1.add(r2.neg());
        Console.WriteLine("the result of subtraction is: " + subResult);



    }
}