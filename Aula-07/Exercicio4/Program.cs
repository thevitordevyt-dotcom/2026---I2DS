internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM DICIONÁRIOS (FIFO - FIRST IN FIRST OUT) ===");

        // 1 - Criar uma fila vazia;
        Queue<string> FilaCaixa = new Queue<string>();

        // 2 - Adicionar elementos na fila;
        FilaCaixa.Enqueue("Zuleika");               // 0
        FilaCaixa.Enqueue("Astrubal");              // 1
        FilaCaixa.Enqueue("Pafúncio");              // 2
        FilaCaixa.Enqueue("Epaminondas");           // 3
        FilaCaixa.Enqueue("Perna-Longa");          // 4


         // 3 - Percorrer  elementos em uma fila;
         Console.WriteLine();
         foreach( var pessoa in FilaCaixa)
        {
            Console.WriteLine(pessoa);
        }
          
          // 4 - Retirar um elemento da lista
          string pessoaRetirada = FilaCaixa.Dequeue();
          Console.WriteLine();
          Console.WriteLine($"O nome chamado foi:  {pessoaRetirada}");
          string pessoaRetirada2 = FilaCaixa.Dequeue();
          Console.WriteLine($"O nome chamado foi:  {pessoaRetirada2}");

          // 5 - Verificar se existe um determinado elemento na lista;
          string procurar = "Pafúncio";
          bool achou = FilaCaixa.Contains(procurar);

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