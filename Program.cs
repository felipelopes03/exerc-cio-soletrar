Console.WriteLine("digite uma palavra para soletrar");
string texto = Console.ReadLine()!;

Console.WriteLine("\nsoletrando fica..\n");

Console.WriteLine(string.Join("-",texto.ToUpper().ToArray()));

