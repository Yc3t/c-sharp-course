// Main program
Person person = new Person();
person.Name = "John";
person.Age = 25;
person.Test = 34;

person.Introduce();

Console.ReadLine(); // Keep console window open

// Create a class
class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Test { get; set; }


    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        Console.WriteLine($"hi im {Test}");

    }
}
