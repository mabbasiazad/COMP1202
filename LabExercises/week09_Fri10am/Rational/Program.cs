class Rational
{
    public int numer; 
    public int denom; 

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

    }
}

class Program
{
    public static void Main(string[] args)
    {
        // create an object or instance from my class
        // declare / assignment / intializae/ ... 
        Rational r1 = new Rational(x:2, y:3); 
        Console.WriteLine("my rational number is: " + r1.ToString());
        
    }
}