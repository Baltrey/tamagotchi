Tamagotchi Tama = new Tamagotchi();
string[] choices = { "Feed", "Hi", "Teach", "Ingenting" };

while (true)
{
    Console.WriteLine("Vad vill du döpa din tamagotchi?");
    Tama.name = Console.ReadLine();
    while (Tama.GetAlive())
    {
        Console.WriteLine("vad vill du göra " + string.Join(",", choices));
        string a = answer();
        if (a == "FEED" || a == "1")
        {
            Tama.Feed();
            Tama.Tick();
        }
        if (a == "HI" || a == "2")
        {
            Tama.Hi();
            Tama.Tick();
        }
        if (a == "TEACH" || a == "3")
        {
            Tama.Teach();
            Tama.Tick();
        }
        else
        {
            Tama.Tick();
        }
    }
    bool goodanswer = true;
    while (goodanswer)
    {
        Console.WriteLine("Vill du köra igen?");
        string a = answer();
        if (a == "YES" || a == "Y")
        {
            goodanswer = false;
        }
        if (a == "NO" || a == "N")
        {
            return;
        }
        else
        {

        }
    }

}


string answer()
{
    string answers = Console.ReadLine();
    answers = answers.ToUpper();
    return answers;
}