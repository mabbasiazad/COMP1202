using System.ComponentModel;
using System.Net.Security;

/// <summary>
/// Represents a rational number.
/// </summary>
class Rational {
    //define class variables
    public int numer;
    public int denom;

    //default: Constructor 1
    public Rational(){

    }
    
    /// <summary>
    /// Initializes a new instance of the Rational class with the specified numerator and denominator.
    /// </summary>
    /// <param name="x">The numerator.</param>
    /// <param name="y">The denominator.</param>
    public Rational(int x, int y) {
        numer = x; 
        denom = y;
    }

    //constructor number 3: short hand form
    public Rational(int x){
        numer = x; 
        denom = 1;
    }

    /// <summary>
    /// Adds another rational number to the current rational number.
    /// </summary>
    /// <param name="anotherR">The rational number to add.</param>
    /// <returns>A new Rational object representing the sum of the two rational numbers.</returns>
    public Rational add(Rational anotherR){
        int newNumer = this.numer * anotherR.denom + this.denom * anotherR.numer;
        int newDenom = this.denom * anotherR.denom;

        Rational resultR = new Rational(newNumer, newDenom);
        
        return resultR;
    }

    /// <summary>
    /// Returns the negation of the current rational number.
    /// </summary>
    /// <returns>A new Rational object representing the negation of the current rational number.</returns>
    public Rational neg() {
        Rational negR = new Rational(-numer, denom);
        return negR;
    }

    /// <summary>
    /// Subtracts another rational number from the current rational number.
    /// </summary>
    /// <param name="anotherR">The rational number to subtract.</param>
    /// <returns>A new Rational object representing the difference between the two rational numbers.</returns>
    public Rational sub(Rational anotherR) {
        return this.add(anotherR.neg());
    }

    /// <summary>
    /// Multiplies the current rational number with another rational number.
    /// </summary>
    /// <param name="that">The rational number to multiply with.</param>
    /// <returns>A new Rational object representing the product of the two rational numbers.</returns>
    public Rational mul(Rational that) {
        int newNumer = this.numer * that.numer;
        int newDenom = this.denom * that.denom;
        return new Rational(newNumer, newDenom);
    }

    /// <summary>
    /// Returns a string representation of the current rational number.
    /// </summary>
    /// <returns>A string representation of the current rational number.</returns>
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

        subResult = r1.sub(r2);

        Rational mulResult = r1.mul(r2); 
        Console.WriteLine("the multiplication result is: "+ mulResult);
    }
}