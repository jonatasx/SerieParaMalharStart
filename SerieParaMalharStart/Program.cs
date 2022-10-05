internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string nome = "Rômulo";
        double media = 70;
        int idade = 18;
        string mensagem = idade < 18 ? "menor" : "maior "; //erro lógico
        Console.WriteLine($"{nome} sua média foi {media}");
        Console.WriteLine($"{nome} você é {mensagem.ToUpper()}");
        Console.ReadKey();
    }
}