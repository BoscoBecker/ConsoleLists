
internal class Program
{
    public static void Main(string[] args)
    {
        List<string> fruits = new List<string>();
        fruits.Add(item: "banana");
        fruits.Add(item: "morango");
        fruits.Add(item: "abacaxi");
        fruits.Add(item: "cereja");

        // 1- Primeiro elemento
        Console.WriteLine(fruits.First());
        Console.WriteLine(fruits.FirstOrDefault());
        // 2 - Verificar se um elemento existe
        Console.WriteLine(fruits.Any(x => x == "cereja")); /// Mais performático
        // 3 - Verificar se todos elementos são do mesmo tipo
        Console.WriteLine(fruits.All(x => x == "cereja"));
        // 4 - Contar
        Console.WriteLine(fruits.Count());
        // 5  - ElementAt
        Console.Write(fruits.ElementAt(2)); ///Obter o elemento na 2ª posição =  abacaxi
        // 6 - Take
        Console.WriteLine(fruits.Take(1..3)); // Range Operator
        // 7 - Where
        Console.WriteLine(fruits.Where(x => x == "cereja"));
        // 8 - Single
        Console.WriteLine(fruits.SingleOrDefault(x => x == "cereja", "Mais de um elemento la lista")); // Deve ter apenas 1 elemento na list
        // 9 - Último elemento
        Console.WriteLine( fruits.Last());
        // 10 - Skip/Pular
        Console.WriteLine(fruits.Skip(2));

        foreach (string fruta in fruits /* or fruits.Where(x => x == "cereja" || x == "banana")*/ )
        {
            Console.WriteLine(fruta);
        }
    }
}