

using Aula05;

class Program
{
    public static void Main(string[] args)
    {
        Casa casa = new Casa();
        casa.Pinta("Azul");

        Porta porta = new Porta();
        Porta porta2 = new Porta();
        Porta porta3 = new Porta();

        porta.Destrancar();
        porta.Abrir();

        porta3.Destrancar();

        Porta porta4 = new Porta();
        porta4.Destrancar();
        porta4.Abrir();

        Porta porta5 = new Porta();
        porta5.Destrancar();
        porta5.Abrir();


        casa.AdicionaPorta(porta);
        casa.AdicionaPorta(porta2);
        casa.AdicionaPorta(porta3);
        casa.AdicionaPorta(porta4);
        casa.AdicionaPorta(porta5);

        Console.WriteLine($"Cor da casa: {casa.Cor}\nNúmero de portas: {casa.TotalPortas()}\nN° de portas abertas: {casa.TotalPortasAbertas()}");

        Console.WriteLine("\n\n");

        int[] ints = new int[5];

        ints[0] = 8;
        ints[1] = 69;
        ints[2] = 777;
        ints[3] = 777;
        ints[4] = 6;

        int moda = Estatistica.Moda(ints);
        int mediana = Estatistica.Mediana(ints);
        double media = Estatistica.Media(ints);

        Console.WriteLine($"Moda: {moda}");
        Console.WriteLine($"Mediana: {mediana}");
        Console.WriteLine($"Média: {media}");

        Console.WriteLine("\n\n");

        Pascal.TrianguloP();

        Console.ReadLine();
    }

}