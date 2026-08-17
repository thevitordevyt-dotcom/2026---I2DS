internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM DICIONÁRIOS ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<string, string> dicionario = new Dictionary<string, string>();
        
        // 2 - Adicionar elementos no dicionario
        dicionario.Add("X-Burger","Pão com carne e queijo artesanais.");
        dicionario.Add("X-bacon","Pão com uma suculenta carne e queijo com bacon moido por cima.");
        dicionario.Add("X-Salada","Pão com carne e queijo artesanal e alface americana por cima.");
        dicionario.Add("X-Costela","Pão com carne de costela desfiada e queijo cheddar e mineiro por cima.");

        // 3 - Percorrer todos os elemetos de um dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - Alterar um elemento do dicionario
        dicionario["X-Burguer"] = "Pão com carne e queijo artesanais.";
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - Verificar se uma chave (key) existe dentro do dicionário
        string termo;
        bool chaveExiste = dicionario.TryGetValue("X-Salada", out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no dicionário");
        }

        // 6 - Excluir um elemento do dicionario -> Somente por Chave(Key)
        dicionario.Remove("X-Burguer");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 7 - Ordenar um Dicionario por chave
        var DicionarioOrdenado = dicionario.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach (var item in DicionarioOrdenado)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}