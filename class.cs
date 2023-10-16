using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
public class Tamagotchi
{
    int hunger = 80;
    int boredom = 80;
    List<string> words = new() { "Hej", "blomma", "fjäril", "plan", "bil", "sol", "måne", "penna", "sudd" };
    int x;
    Random generator = new();
    public string name;

    public void Feed()
    {
        if (hunger < 100)
        {
            hunger += 15;
            Console.WriteLine("Du gav " + name + " mat!");
            Printstat();
        }
        else
        {
            Console.WriteLine(name + " är inte hungrig:(");
        }
    }

    public void Hi()
    {
        if (boredom < 100)
        {
            ReduceBoredom();
            Console.WriteLine("Du sa hej till " + name + "!");
            Printstat();
        }
        else
        {
            Console.WriteLine(name + " blev glad men är inte utråkad");
        }
    }
    public void Teach()
    {
        if (boredom < 100)
        {
            if (x <= 9)
            {
                Console.WriteLine("Du lärde " + name + " ordet: " + words[x]);
                ReduceBoredom();
                x++;
            }
            else
            {
                Console.WriteLine("Du lärde inga ny ord men " + name + " blev glad för försöket");
                ReduceBoredom();
            }
        }
        else
        {
            Console.WriteLine(name + " blev glad men är inte utråkad");
        }
    }
    public void Tick()
    {
        boredom -= 10;
        hunger -= 10;
    }
    public void Printstat()
    {
        Console.WriteLine("hunger is: " + hunger);
        Console.WriteLine("boredom is: " + boredom);
    }
    public bool GetAlive()
    {
        if (boredom > 0 && hunger > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void ReduceBoredom()
    {
        boredom += 15;
    }
}