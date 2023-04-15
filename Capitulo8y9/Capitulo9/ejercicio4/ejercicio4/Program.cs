TipoNeumatico neumatico1 = TipoNeumatico.Verano;
TipoNeumatico neumatico2 = TipoNeumatico.Invierno;
TipoNeumatico neumatico3 = TipoNeumatico.TodoTerreno;

Console.WriteLine("Tipo de neumatico 1: " + (int)neumatico1 + " - " + neumatico1);
Console.WriteLine("Tipo de neumatico 2: " + (int)neumatico2 + " - " + neumatico2);
Console.WriteLine("Tipo de neumatico 3: " + (int)neumatico3 + " - " + neumatico3);


enum TipoNeumatico
{
    Verano = 5,
    Invierno = 5,
    TodoTerreno = 5
   
}