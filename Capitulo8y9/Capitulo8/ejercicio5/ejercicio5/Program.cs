Console.WriteLine("Ingrese la primera cadena: ");
string cadena1 = Console.ReadLine();

Console.WriteLine("Ingrese la segunda cadena: ");
string cadena2 = Console.ReadLine();

string resultado = string.Compare(cadena1, cadena2) < 0 ? cadena1 + "\n" + cadena2 : cadena2 + "\n" + cadena1;

Console.WriteLine("Cadenas en orden alfabético: \n" + resultado);