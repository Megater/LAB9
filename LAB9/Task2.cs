namespace LAB9;



class Dog
{
    private string name;
    private int age;

    public Dog()
    {
        this.name = "unnamed";
    }

    public void NameTheDog(string new_name)
    {
        this.name = new_name;
    }

    public void Birthday()
    {
        age += 1;
    }
    
    public override string ToString()
    {
        return $"Name of the dog is {name} and age is {age}";
    }
}
class Task2
{
    public static void TasK2()
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        Console.WriteLine("dog1");
        Console.WriteLine(dog1.ToString());
        Console.WriteLine("Name the dog1");
        dog1.NameTheDog(Console.ReadLine());
        dog1.Birthday();
        Console.WriteLine(dog2.ToString());
        Console.WriteLine("dog2");
        Console.WriteLine(dog1.ToString());
        Console.WriteLine("Name the dog2");
        dog2.NameTheDog(Console.ReadLine());
        dog2.Birthday();
        Console.WriteLine(dog2.ToString());
        
            
        

    }
}