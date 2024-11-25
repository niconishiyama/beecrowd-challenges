int X, i, impares;

X = int.Parse(Console.ReadLine());
impares = 0;

for (i = 1; i <= X; i++)
{
   if (i % 2 != 0)
    {
        impares = i;
        Console.WriteLine(impares);
    }
}
