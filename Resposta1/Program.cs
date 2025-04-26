using Microsoft.VisualBasic;
using System;

public class Personagem
{
    private int vida;

    public Personagem(int vidaInicial)
    {
        if (vidaInicial < 0)
            //caso o usuário tente digitar um valor negativo, o programa irá lançar uma exceção
            throw new ArgumentException("A vida inicial não pode ser negativa.");
        //atribui o valor de vida recebido a variável privada
        this.vida = vidaInicial;
    }

    //retona o valor da vida do personagem
    public int Vida
    {
        get { return vida; }
    }
    //metodo para calcular a perda de vida do personagem de acordo com o valor recebido
    public void PerderVida(int dano)
    {
        if (dano < 0)
            throw new ArgumentException("O dano não pode ser negativo.");
        //subtrai o valor de dano da vida atual do personagem
        vida = Math.Max(0, vida - dano);

        //informa o valor atual da vida do personagem
        Console.WriteLine($"Vida do personagem: {vida}");
    }
    //metodo para calcular o ganho de vida do personagem de acordo com o valor recebido
    public void GanharVida(int quantidade)
    {
        if (quantidade < 0)
            throw new ArgumentException("A quantidade de vida ganha não pode ser negativa.");
        //soma a vida atual com a quantidade recebida
        vida += quantidade;
        Console.WriteLine($"Vida do personagem: {vida}");
    }
}

/// <summary>
/// Parte para testar a lógica de encapsulamento
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite a vida inicial do herói: ");
            int vidaInicial = int.Parse(Console.ReadLine());

            if (vidaInicial < 0)
            {
                Console.WriteLine("A vida inicial não pode ser negativa.");
                return;
            }

            Personagem heroi = new Personagem(vidaInicial);
            Console.WriteLine($"Vida inicial do herói: {heroi.Vida}");

            while (true)
            {
                Console.WriteLine("\nEscolha uma ação:");
                Console.WriteLine("1. Perder vida");
                Console.WriteLine("2. Ganhar vida");
                Console.WriteLine("3. Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "3")
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                if (opcao == "1")
                {
                    Console.Write("Digite a quantidade de dano: ");
                    int dano = int.Parse(Console.ReadLine());
                    heroi.PerderVida(dano);
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite a quantidade de vida a ganhar: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    heroi.GanharVida(quantidade);
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, insira um número válido.");
        }
    }
    
}

// Esse código foi escrito para demonstrar como é feito o encapsulamento em c#, da seguinte forma: dentro da classe "Personagem" temos uma variável privada chamada "vida",
// que é acessada através de métodos públicos "PerderVida" e "GanharVida".