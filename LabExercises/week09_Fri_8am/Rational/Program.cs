using System.ComponentModel;
using System.Net.Security;

class Rational {
    //define class variables
    public int numer;
    public int denom;

    //default: Constructor 1
    public Rational(){

    }
    //user defined constructor: Constructor number 2 (main)
    public Rational(int x, int y) {
        numer = x; 
        denom = y;
    }

    //constructor numver 3: short hand form
    public Rational(int x){
        numer = x; 
        denom = 1;
    }

    public Rational add(Rational anotherR){
        int newNumer = this.numer * anotherR.denom + this.denom * anotherR.numer;
        int newDenom = this.denom * anotherR.denom;

        Rational resultR = new Rational(newNumer, newDenom);
        
        return resultR;
    }

    public Rational neg() {
        Rational negR = new Rational(-numer, denom);
        return negR;
    }

    public Rational sub(Rational anotherR) {
        return this.add(anotherR.neg());
    }





    public override string ToString(){
        string msg = $"{numer}/{denom}";
        return msg;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //main constructor: do the creation step : make an object or an instance of your class
        Rational r1 = new Rational(x:2, y:3);
        Console.WriteLine("The rational number is: " + r1);

        //default constructor
        Rational r2 = new Rational();
        r2.numer = 5;
        r2.denom = 8; 

        Console.WriteLine("The rational number is: " + r1.ToString());
        Console.WriteLine("The rational number is: " + r2);

        Rational r3 = new Rational(5); 
        Console.WriteLine("The rational number is: " + r3);

        Rational addResult = r1.add(r2);
        Console.WriteLine($"{r1} + {r2} = {addResult}");

        Rational r2Negative = r2.neg();
        Console.WriteLine("The neg() method test : " + r2Negative);

        Rational subResult = r1.add(r2.neg());
        Console.WriteLine("the subtract result is: "+ subResult);

        subResult = r1.sub(r2)

        
    }
}