using System;


class Program
{
    static void Main(string[] args){

        //Printf
        Console.WriteLine("Imprimir exemplo");
        
        //Scanf
        Console.ReadLine();


        //Tipos de valor
        float a = 7.8f;
        
        double b = 2.456;

        char c = 'e';
        
        string d = "exemplo";
        
        int e = 5;
        
        long f = 1000000000000;
        
        bool g = true;

        
        //Tipos de referencia;
        int[] z = new int[e];

        Exemplo o = new Exemplo();

        Console.WriteLine(Exemplo.atributoDaClasse);//Chama um atributo da classe e não do objeto; 


        //Console.WriteLine(o.naoDaPraVerNoMain);

        Console.WriteLine(o.daPraVerNoMain);//Lê um atributo do objeto, algo similar com um campo em uma struct ou uma variável no Main;
        
        o.imprimeVisivel();//Chama um método do objeto;

        Exemplo.imprimeAttrClasse();

        Exemplo o2 = new Exemplo();
        Exemplo o3 = new Exemplo();
        Exemplo o4 = new Exemplo();

        Console.WriteLine(o.NumObj2);
        Console.WriteLine(Exemplo.NumObj);

        
    }


}

class Exemplo
{
    public bool daPraVerNoMain = true;
    private bool naodaPraVerNoMain = false;

    public static int NumObj = 0;
    public int NumObj2 = 0;

    private static string atributoDaClasseInvisivel = "Só da para acessar dentro da classe";
    public static string atributoDaClasse = "Só da para acessar pela classe e não objeto";

    public void imprimeVisivel()
    {
        Console.WriteLine("Dá pra acessar pelo main");

        //imprimeInvisivel();
    }
    private void imprimeInvisivel()
    {
        Console.WriteLine("Não dá pra acessar pelo main");
    }

    public static void imprimeAttrClasse()
    {
        Console.WriteLine(atributoDaClasseInvisivel);
    }

    public Exemplo()
    {
        NumObj++;
        NumObj2++;
    }

}

