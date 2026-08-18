internal class Program
{
    private static void Main(string[] args)
    {
        /* Vetores e matrizes 
         Vetor => É uma estrutura de dados utilizada para armazenar varios valores de um mesmo tipo dentro de uma única varíavel.

         tipo[]nome vetor = new tipo [tamanho];
        */
        /* Iniciar um vetor -> Lista de frutas*/

        string[] listaFrutas = {"maça","manga","morango","melancia","melão"};

        Console.WriteLine("Acessar o  terceiro elemento da lista");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Alterar o segundo elemento da lista: ");
        listaFrutas[1] = "banana";

        for (int indice = 0; indice < listaFrutas.Length; indice++)
        {
            Console.WriteLine(listaFrutas[indice]);

            /*********************************************************************/

            foreach (string fruta in listaFrutas)
            {
                Console.WriteLine(fruta);
            }
        }
}
}