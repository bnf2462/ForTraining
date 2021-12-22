// See https://aka.ms/new-console-template for more information


bool result = int.TryParse(Console.ReadLine(), out int number);
if (!result)
{
    return;
}
List<string> spaces = new List<string>();
List<string> stars = new List<string>();

for (int i = 0; i < number; i++)
{
    spaces.Add(" ");
}

for (int i = 0; i < number; i++)
{
    if (i != 0)
    {
        stars.Add("*");
        stars.Add("*");
    }
    else
    {
        stars.Add("*");
    }
    spaces.Remove(" ");

    //output
    foreach (var item in spaces)
    {
        Console.Write(item);
    }

    foreach (var item in stars)
    {
        Console.Write(item);
    }
    Console.WriteLine();
}



Console.ReadKey();