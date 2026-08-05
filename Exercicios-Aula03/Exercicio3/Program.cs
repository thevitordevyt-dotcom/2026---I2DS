internal class Program
{
    private static void Main(string[] args)
    {
        /*# Exercício 03 — Sistema de Aprovação Escolar

## Nível

Fácil

---

## Objetivo

Criar um sistema que calcule a média de um aluno e informe sua situação.

Conceitos utilizados:

- Variáveis;
- Condições;
- Operadores relacionais;
- Métodos.

---

# Enunciado

Desenvolva um programa escolar que receba:

- Nome do aluno;
- Três notas.

O sistema deve calcular a média final.*/

int idade = 16;
string nome = "Pafunso";
bool estudante = true;
double d1 = 70;
double d2 = 60;
double d3 = 30;

double resultado = 0;

// Calcular a nota do aluno Pafunso
resultado = d1 + d2 + d3 ;

Console.WriteLine("A soma das suas notas é: "+ resultado);

resultado = d1 / d2 / d3 ;
Console.WriteLine("Nome do aluno registrado no sistema: " + nome);

Console.WriteLine("Idade do aluno no sistema : " + idade);

Console.WriteLine("A medía final do aluno Pafunso é: " + resultado);

Console.WriteLine("O aluno se encontra na profissão de: "  + estudante);

    }
}