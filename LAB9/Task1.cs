namespace LAB9;


    class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double c, double d)
        {
            a = c;
            b = d;
        }
        
        public double Area()
        { 
            return a * b;
        }

        public double Perimeter()
        {
            return a + a + b + b;
        }

        public double Diagonal()
        {
            double apow = Math.Pow(a, 2);
            double bpow = Math.Pow(b, 2);
            return Math.Sqrt(apow + bpow);
        }
    }
    public class Task1
    {
    public static void TasK1()
    {
        int counter = 1;
        while (counter <= 2)
        {
        Console.WriteLine("Type leng of side a of Rectangle");
        double c =  double.Parse(Console.ReadLine());
        Console.WriteLine("Type leng of side b of Rectangle");
        double d = double.Parse(Console.ReadLine());

        Rectangle r = new Rectangle(c, d);
            
        Console.WriteLine($"Ractangle number {counter}");
        Console.WriteLine("Area:" +  r.Area()); 
        Console.WriteLine("Perimeter:" +  r.Perimeter()); 
        Console.WriteLine("Diagonal:" +  r.Diagonal());
        
        counter++;
        
        }

    }
    
    }