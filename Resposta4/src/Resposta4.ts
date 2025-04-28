"use strict";
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

class Animal {
  // Só acessível dentro da classe Animal.
  private nome: string;
  // Acessível em Animal e suas subclasses.
    protected idade: number;     

    constructor(nome: string, idade: number) {
        this.nome = nome; 
        this.idade = idade;  
    }

    getName(): string {
        return this.nome; 
    }

}

class Cachorro extends Animal {
    constructor(nome: string, idade: number) {
        super(nome, idade);
    }

    bark(): string {
        console.log(this.idade);  

        return `Idade: ${this.idade}`;
    }
}

function askQuestions(): void {
    rl.question("Nome do cachorro: ", (nome: string) => {
        rl.question("Idade do cachorro: ", (idade: string) => {
            const cachorro = new Cachorro(nome, parseInt(idade));
            console.log("O nome é: ",cachorro.getName());
            console.log(cachorro.bark());

            rl.close();
        });
    });
}

askQuestions();
//como podemos ver, dentro de uma mesma classe, protected e private funcionam de forma bem semelhante, porém, a diferença entre eles, evidenciada em class Animal é que, quando temos um variável privada (nome),
//não conseguimos acessar seu valor em subclasses sem ser através de um get, já uma variável protected, não precisa de um método publico para ter seu valor acessado em uma subclasse de onde
//foi declarado.