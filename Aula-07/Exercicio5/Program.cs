internal class Program
{
    private static void Main(string[] args)
    {
         Console.WriteLine("=== TRABALHANDO COM PILHAS (FILO) ===");

         Stack<string> PilhaEditor = new Stack<string>();

         PilhaEditor.Push("Digitar");
         PilhaEditor.Push("Colar");
         PilhaEditor.Push("Negrito");
         PilhaEditor.Push("Apagar");

         Console.WriteLine();
         foreach (var Editor in PilhaEditor)
        {
            Console.WriteLine(Editor);
        }
           Console.WriteLine();
        Console.WriteLine();
         foreach (var Editor in PilhaEditor)
        {
            Console.WriteLine(Editor);
        }
           Console.WriteLine();
           
           // Remover "Negrito"
           if (PilhaEditor.Count > 2)
           {
               string itemRemovido1 = PilhaEditor.Pop();
               Console.WriteLine($"Item removido: {itemRemovido1}");
           }
           
           // Remover "Apagar"
           if (PilhaEditor.Count > 3)
           {
               string itemRemovido2 = PilhaEditor.Pop();
               Console.WriteLine($"Item removido: {itemRemovido2}");
           }
    }
}