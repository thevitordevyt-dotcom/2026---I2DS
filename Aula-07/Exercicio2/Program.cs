internal class Program
{

    public class  Valores
    {
        public int? Valor {get;set;}
        public string Nome {get;set;}
    }
    private static void Main(string[] args)
    {
        List<Valores> listaValor = new List<Valores>();

      Valores Valor1 = new Valores{ 
      Valor = 10};
      Valores Valor2 = new Valores{ 
      Valor = 25};
      Valores Valor3 = new Valores{ 
      Valor = 8};
      Valores Valor4 = new Valores{ 
      Valor = 42};
      Valores Valor5 = new Valores{ 
      Valor = 15};
      Valores Valor6 = new Valores{ 
      Valor = 30};

      listaValor.Add(Valor1);
      listaValor.Add(Valor2);
      listaValor.Add(Valor3);
      listaValor.Add(Valor4);
      listaValor.Add(Valor5);
      listaValor.Add(Valor6);
    
     listaValor.RemoveAt(0);
        Console.WriteLine();
        foreach (var Valores in listaValor)
        {
            Console.WriteLine($"{Valores.Nome} ");
        }
    }
}