﻿Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

double X, Y;

string[] values = Console.ReadLine().Split(' ');

X = double.Parse(values[0]);
Y = double.Parse(values[1]);

if (X > 0.0 && Y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (X < 0.0 && Y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (X < 0.0 && Y < 0.0)
{
    Console.WriteLine("Q3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Q4");
}
else if (X == 0 & Y == 0)
{
    Console.WriteLine("Origem");
}
else if (X < 0 || X > 0)
{
    Console.WriteLine("Eixo X");
}
else if (Y < 0 || Y > 0)
{
    Console.WriteLine("Eixo Y");
}