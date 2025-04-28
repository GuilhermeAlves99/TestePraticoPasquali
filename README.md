# Teste Pasquali Solution

## 1.Explique o conceito de encapsulamento e como ele pode ser aplicado a uma classe c#. De um exemplo prático
[Reposta](https://github.com/GuilhermeAlves99/TestePraticoPasquali/blob/master/Resposta1/Program.cs)
______________________________________________________________________________________________________________
## 2.Descreva o principio de open/closed e implemente um pequeno exemplo em c# que respeite esse princípio
[Resposta](https://github.com/GuilhermeAlves99/TestePraticoPasquali/blob/master/Resposta2/Program.cs)
______________________________________________________________________________________________________________
## 3. Qual será a saída do código abaixo? Justifique sua resposta.
```csharp
public class Animal
{
    public virtual void Falar() => Console.WriteLine("Animal faz som");
}

public class Cachorro : Animal
{
    public override void Falar() => Console.WriteLine("Latido");
}

public class Gato : Animal
{
    public new void Falar() => Console.WriteLine("Miau");
}

Animal a1 = new Cachorro();
Animal a2 = new Gato();

a1.Falar();
a2.Falar();

//O retorno de a1 será "Latido" e o retorno de a2 será "Animal faz som", pois apenas a classe Cachorro sobrescreve o valor de Falar()
```
______________________________________________________________________________________________________________
## 4. Qual a diferença entre private, protected e public em Typescript? Dê um exemplo para cada um
