


class ProcessedPhoto : Phtoto
{
    public string Filter {get; set;}
    public string Fulter {get; set;}

    public override void Display()
    {
        base.Display();
        System.Console.WriteLine($"alish kadem filtra {Name}");
        System.Console.WriteLine($"alish kadem fultera {Name}");

    }


}