namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("What is the radius of the circle");
        var radius = Console.ReadLine(); 
        Console.WriteLine( "The area is "+ CArea (Convert.ToDouble (radius)));
        
        Console.WriteLine ("What is the base of the triangle");
        var baseLength = Console.ReadLine();
        Console.WriteLine ("What is the hight of the triangle");
        var hight = Console.ReadLine();
        Console.WriteLine("The area is " + TArea (Convert.ToDouble(baseLength),Convert.ToDouble(hight)));
        
        Console.WriteLine ("What is the length of the rectangle");
        var length = Console.ReadLine();
        Console.WriteLine ("What is the width of the rectangle");
        var width = Console.ReadLine();
        Console.WriteLine("The area is " + RArea (Convert.ToDouble(length),Convert.ToDouble(width)));
        
        Console.WriteLine ("How long are the sides");
        var side = Console.ReadLine(); 
        Console.WriteLine( "The area is "+ SArea (Convert.ToDouble (side)));
    }
    static double CArea(double radius)
    {
        return Math.PI * radius * radius;
       
    }
    static double TArea(double baseLength, double hight)
    {
        return baseLength * hight / 2;
        
    }
    static double RArea(double length, double width)
    {
        return length * width;
    }
    
    static double SArea(double side)
    {
        return side * side;
    }
  
}