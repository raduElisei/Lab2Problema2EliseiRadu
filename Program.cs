namespace Lab2Problema2EliseiRadu;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scrie deimpartit:");
        decimal deimpartit = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Scrie impartitor");
        decimal impartitor = Convert.ToDecimal(Console.ReadLine());
        decimal rezultat = deimpartit / impartitor;

        Console.WriteLine("Rezultatul este " + rezultat);

        if((rezultat % 1) == 0)
        {
            Console.WriteLine("Impartirea este exacta.");
        }
        else
        {
            Console.WriteLine("Impartirea nu este exacta.");
        }
    }
}