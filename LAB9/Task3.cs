namespace LAB9;

class Matrix3D
{
    private int a11;
    private int a12;
    private int a13;
    private int a21;
    private int a22;
    private int a23;
    private int a31;
    private int a32;
    private int a33;

    public Matrix3D(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
    {
        this.a11 = a11; this.a12 = a12; this.a13 = a13;
        this.a21 = a21; this.a22 = a22; this.a23 = a23;
        this.a31 = a31; this.a32 = a32; this.a33 = a33;
    }

    public static Matrix3D operator +(Matrix3D m1, Matrix3D m2)
    {
        return new Matrix3D(
            m1.a11 + m2.a11, m1.a12 + m2.a12, m1.a13 + m2.a13,
            m1.a21 + m2.a21, m1.a22 + m2.a22, m1.a23 + m2.a23,
            m1.a31 + m2.a31, m1.a32 + m2.a32, m1.a33 + m2.a33);
    }

    public string ToString()
    {
        return $"\n{a11}  {a21}   {a31}\n{a12}   {a22}   {a32}\n{a13}    {a23}   {a33}";
    }
}

public class Task3
{
    static Matrix3D WczytajMacierz(string nazwa)
    {
        Console.WriteLine($"Render{nazwa}");
        int[] dane = new int [9];
        for (int i = 0; i < 9; i++)
        {
            dane[i] = int.Parse(Console.ReadLine());
        }
        return new Matrix3D(dane[0], dane[1], dane[2], dane[3], dane[4], dane[5],  dane[6], dane[7], dane[8]);
    }
    public static void TasK3()
    {

        Matrix3D m1 = WczytajMacierz("Matrix3D--1");
        Console.WriteLine(m1.ToString());
        Matrix3D m2 = WczytajMacierz("Matrix3D--2");
        Console.WriteLine(m2.ToString());
        string wybor = Console.ReadLine();
        switch (wybor)
        {
            case "+":
                Matrix3D suma = m1 + m2;
                Console.WriteLine(suma.ToString());
                break;
        }
    }

}