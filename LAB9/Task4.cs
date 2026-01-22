using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace LAB9;

class Vector3D
{
    double x, y, z;

    public Vector3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double Length()
    {
        return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2));
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
    }

    public static Vector3D operator *(Vector3D v1, Vector3D v2)
    {
        
    }
        

    public override string ToString()
    {
        return $"[{x}\t{y}\t{z}]";
    }
    
}

public class Task4
{
    static Vector3D upload()
    {
        double[] numb = new double[3];
        for (int x = 0; x < 3; x++)
        {
            Console.Write("Type argument:\t");
            numb[x] = double.Parse(Console.ReadLine());
        }
        return new Vector3D(numb[0], numb[1], numb[2]);
    }
    public static void TasK4()
    {
        Vector3D v1 = upload();
        Vector3D v2 = upload();
        Console.WriteLine("Choose action:\n(+) --- adding two vectors\n(-) --- subtracting\n(*) --- scalar product\n(&) --- vector product\n(/) --- division by the number");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "+":
                Console.WriteLine("Adding two vectors");
                Vector3D adding = v1 + v2;
                Console.WriteLine(adding.ToString());
                break;
            case "-":
                Console.WriteLine("Subtracting two vectors");
                Vector3D subtracting = v1 - v2;
                Console.WriteLine(subtracting.ToString());
                break;
        }
    }
}