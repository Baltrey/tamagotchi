using Microsoft.VisualBasic;
public class Tamagotchi
{
    int hunger = 100;
    int boredom = 100;
    List<string> words = new();
    Random generator = new();
    public string name;

    public void Feed()
    {

    }

    public void Hi()
    {

    }
    public void Teach()
    {

    }
    public void Tick()
    {

    }
    public void Printstat()
    {
        Console.WriteLine("hunger is: " + hunger);
        Console.WriteLine("boredom is: " + boredom);
    }
    public bool GetAlive()
    {
        return true;
    }
    void ReduceBoredom()
    {

    }
}