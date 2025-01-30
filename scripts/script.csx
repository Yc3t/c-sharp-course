#nullable enable
#r "System.Console"

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        Console.WriteLine("hi!");
    }
}

var person = new Person();
person.Name = "John";
person.Age = 25;
person.Introduce();
