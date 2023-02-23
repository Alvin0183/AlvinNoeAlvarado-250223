
Console.WriteLine("Si deseas saber cuales son los numero pares que hay entre dos cantidades distintas, ingresa los datos que se te pidan a continuacion: ");
Console.WriteLine("");
Console.Write("Ingrese el valor inicial: ");
String inicio = Console.ReadLine();
int dato = Convert.ToInt32(inicio);

Console.WriteLine("");

Console.Write("Ingrese el valor final: ");
String fin = Console.ReadLine();
int dato2 = Convert.ToInt32(fin);

Console.WriteLine("");
Console.WriteLine("A continuacion se muestran los numeros pares que estan entre de las dos cantidades ingresadas anterorimente: ");
Console.WriteLine("");

for (int i = dato; i < dato2; i++)
{
    if ( i % 2 == 0)
    {
        Console.WriteLine(i);

    }
}