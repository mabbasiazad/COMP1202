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
        r2.Denom = 5;
        r2.numer = 8; 
        Console.WriteLine("the second rational number is: " + r2);

        

    }
}