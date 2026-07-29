using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //comentário de linha
        
        //Escreve uma linha de texto na tela
        Console.WriteLine("Programação orientada a objetos \n");

        Console.WriteLine("Abstração - 1o. pilar da POO");

        // Criar uma classe em C#/*
        // Classe deve ser declarada fora do bloco do programa/*

        //Criar objeto a  partir da classe
        
        Pet pet1 = new Pet();
        
        pet1.nome = "Toto";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;
        
        pet1.MostrarNome();
        
        Pet pet2 = new Pet();
        
        pet2.nome = "Mingau";
        pet2.tipo = "Gato";
        pet2.idade = 8;
        
        pet2.MostrarNome();


    }
}
public class Pet // Nome da classe sempre inicia com letras maiusculas/*
{
    // Declaração dos atributos/*
   public string nome;
   public string tipo;
   public int idade;
    // Declaração dos métodos/*
   public void MostrarNome()
    {
        Console.WriteLine("Meu nome é " + this.nome);

    }

}