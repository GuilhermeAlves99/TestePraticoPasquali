using System;


public interface IAtaque
{
    int AcertaHit();
}

public class AtaqueFraco : IAtaque
{
    public int AcertaHit()
    {
        return 1;
    }
}

public class AtaqueForte : IAtaque
{
    public int AcertaHit()
    {
        return 2;
    }
}

public class Combate
{
    public void Atacar(IAtaque ataque)
    {
        int dano = ataque.AcertaHit();
        Console.WriteLine($"Ataque realizado! Dano: {dano}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Solicita que o usuário digite o ataque
            Console.WriteLine("Digite o ataque (AtaqueFraco ou AtaqueForte): ");
            string entrada = Console.ReadLine().Trim();

            // Instancia o ataque com base na entrada
            IAtaque ataque = entrada.ToLower() switch
            {
                "ataquefraco" => new AtaqueFraco(),
                "ataqueforte" => new AtaqueForte(),
                _ => throw new ArgumentException("Ataque inválido. Use 'AtaqueFraco' ou 'AtaqueForte'.")
            };

            // Executa o ataque
            Combate combate = new Combate();
            combate.Atacar(ataque);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
}

//Os dois primeiros ataques (AtaqueForte ou AtaqueFraco) foram definidos para a classe de combate poder utilizá-los e, caso exista a necessidade de criar um terceiro ataque
//basta criar uma nova classe que implemente a interface IAtaque e adicionar a lógica necessária. O que aplica de forma consisa o conceito de open/closed, a classe combate nunca
//terá a necessidade de ser alterada, mas aceita modificadores que vêm da interface.


