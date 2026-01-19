namespace LAB9;



class Dog
{
    private string name;
    private int age;

    public Dog()
    {
        this.name = "unnamed";
        this.age = age;
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
        return $"Name of the dog is {name} and age  is {age}";
    }
}
public class Task2
{
    public static void TasK2()
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        string name = Console.ReadLine();
        dog1.ToString();
        dog1.NameTheDog(name);
        dog1.Birthday();
        dog2.ToString();
        dog2.NameTheDog(name);
        dog2.Birthday();

    }
}