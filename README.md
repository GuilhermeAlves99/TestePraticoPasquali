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
## 4. Qual a diferença entre private, protected e public em Typescript? Dê um exemplo para cada um.
[Resposta](https://github.com/GuilhermeAlves99/TestePraticoPasquali/tree/master/Resposta4)
______________________________________________________________________________________________________________
## 6. Considere a tabela Pessoas com os campos(CPF, Nome, Genero, Endereço, Idade, Municipio, Estado). Escreva uma query SQL para buscar todas as pessoas do estado de SP com idade entre 25 e 40 anos, ordenadas pelo nome.
[Resposta](https://github.com/GuilhermeAlves99/PipesAngular)
______________________________________________________________________________________________________________
## 7. Explique como funciona o ciclo de vida de um componente angular. Qual método é ideal para fazer uma chamada HTTP?
```typescript
//O ciclo de vida de um componente em angular é gerenciado por métodos (hooks)
//Os principais hooks são:
//1. ngOnInit(): método de inicialização, ideal para chamadas http, seu ciclo de vida se encerra após a inicialização.
//2. ngOnChanges(): chamado quando propriedades de entrada (@Input) mudam. Seu ciclo de vida é atualizado a cada interação com um input.
//3. ngDoCheck(): fica a cargo de detectar mudanças no template. Seu ciclo de vida é renovado quando há mudanças na tela.
//4. ngAfterViewInit(): executado após a renderização da view. Seu ciclo de vida se encerra quando a View é carregada
//5. ngOnDestroy(): executado antes um elemento ser destruido, serve para limpeza de dados.
```
______________________________________________________________________________________________________________

## 8. Analise o trecho abaixo: 
```typescript
this.http.get('api/pessoas').subscribe(data => {  
    this.pessoas = data;  
});  

console.log(this.pessoas);
```

O código acima tem um erro de assincronia, o console log está tentando buscar o valor de this.pessoas em um tempo de execussão onde ela não é mais acessível.

Correção:
```typescript
this.http.get('api/pessoas').subscribe(data => {  
    this.pessoas = data;  
    console.log(this.pessoas);
});
```
