

class User
{
    public string Name {get; set; }

    public virtual void ViewActivity()
    {
        System.Console.WriteLine($"{Name} is viewing activity");
    }



}