int x, y;

string[] values = Console.ReadLine().Split(' ');

x = int.Parse(values[0]);
y = int.Parse(values[1]);

while (x != 0 & y != 0)
{
    if (x > 0 & y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 & y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (x < 0 & y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("quarto");
    }
    values = Console.ReadLine().Split(' ');
    x = int.Parse(values[0]);
    y = int.Parse(values[1]);
}
