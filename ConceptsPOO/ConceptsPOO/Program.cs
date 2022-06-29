

using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("==============");

try
{
    Console.WriteLine(new Date(2022, 2, 7));
    Console.WriteLine(new Date(2022, 06, 5));
    Console.WriteLine(new Date(2022, 4, 30));
   Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
