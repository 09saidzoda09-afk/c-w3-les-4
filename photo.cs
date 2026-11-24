

class Phtoto
{
    public string Name {get; set;}

    public virtual void Display()
    {
        System.Console.WriteLine($"photo {Name}");
    }


}