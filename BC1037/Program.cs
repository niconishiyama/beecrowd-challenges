Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

double valor;
string intervalo = " ";

valor = double.Parse(Console.ReadLine());

if (valor >= 0 & valor <= 25.00)
{
    intervalo = "[0,25]";
    Console.WriteLine("Intervalo {0}", intervalo);
}
else if (valor > 25 & valor <= 50)
{
    intervalo = "(25,50]";
    Console.WriteLine("Intervalo {0}", intervalo);
}
else if (valor > 50 & valor <= 75)
{
    intervalo = "(50,75]";
    Console.WriteLine("Intervalo {0}", intervalo);
}
else if (valor > 50 & valor <= 100)
{
    intervalo = "(75,100]";
    Console.WriteLine("Intervalo {0}", intervalo);
}
else
{
    Console.WriteLine("Fora de intervalo");
}

Console.ReadLine();