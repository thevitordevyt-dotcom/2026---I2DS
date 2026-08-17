internal class Program
{
        public class Cidades
    {
        public string Cidade {get;set;}
        public string Nome {get;set;}
    }

    private static void Main(string[] args)
    {
       Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

       List<Cidades> listaCidades = new List<Cidades>();

      Cidades cidade1 = new Cidades{ 
      Nome = "Brasília"};
      Cidades cidade2 = new Cidades{ 
      Nome = "Jahu"};
      Cidades cidade3 = new Cidades{ 
      Nome = "Bauru"};
      Cidades cidade4 = new Cidades{ 
      Nome = "Brotas"};
      Cidades cidade5 = new Cidades{ 
      Nome = "Barra-Bonita"};
       


       listaCidades.Add(cidade1);
       listaCidades.Add(cidade2); 
       listaCidades.Add(cidade3);
       listaCidades.Add(cidade4);
       listaCidades.Add(cidade5);




      foreach (var Cidades in listaCidades)
        {
             Console.WriteLine($"{Cidades.Nome}");
        }

    }
}