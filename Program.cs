
var path = @"C:\Users\wtfsp\Desktop\BootCamp DIO\GFT Start #4 .NET\Aula Streams\ConsoleApp6\Entrada\usuario-exportacao.csv";
using var sr = new StreamReader (path);
var cabecalho = sr.ReadLine()?.Split(",");

while (true)
{
    var registro = sr.ReadLine()?.Split(",");
    if (registro == null) break;
    for (int i = 0; i < registro.Length; i++)
    {
        Console.WriteLine($"{cabecalho[i]}: {registro[i]}");

    }
    Console.WriteLine("_______________________");
}
Console.WriteLine("Pesione o [Enter] para finalizar!");
Console.ReadLine();
