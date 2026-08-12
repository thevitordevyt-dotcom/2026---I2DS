internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM DICIONÁRIOS (FIFO - FIRST IN FIRST OUT) ===");

        // 1 - Criar uma fila vazia;
        Queue<string> FilaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila;
        FilaBanco.Enqueue("Zuleika");               // 0
        FilaBanco.Enqueue("Astrubal");              // 1
        FilaBanco.Enqueue("Pafúncio");              // 2
        FilaBanco.Enqueue("Epaminondas");           // 3


         // 3 - Percorrer  elementos em uma fila;
         Console.WriteLine();
         foreach( var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }
          
          // 4 - Retirar um elemento da lista
          string pessoaRetirada = FilaBanco.Dequeue();
          Console.WriteLine();
          Console.WriteLine($"O nome chamado foi:  {pessoaRetirada}");
          
          // Adicionar uma nova  pessoa;
          FilaBanco.Enqueue("Lucrécia");

          Console.WriteLine();
          foreach( var pessoa in FilaBanco)
          {
            Console.WriteLine(pessoa);
          }



          // 5 - Verificar se existe um determinado elemento na lista;
          string procurar = "Pafúncio";
          bool achou = FilaBanco.Contains(procurar);

          if (achou)
        {
            Console.WriteLine($"{procurar} está na fila");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO está na fila!");

        }
    }
}