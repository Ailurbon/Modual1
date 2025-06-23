namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("What is the radius of the circle");
        var radius = Console.ReadLine(); 
        Console.WriteLine( CArea (Convert.ToDouble (radius)));
    }
    static double CArea(double radius)
    {
        return Math.PI * radius * radius;
       
    }
}