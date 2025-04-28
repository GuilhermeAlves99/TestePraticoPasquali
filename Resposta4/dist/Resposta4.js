"use strict";
const readline = require('readline');
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
class Animal {
    constructor(nome, idade) {
        this.nome = nome;
        this.idade = idade;
    }
    getName() {
        return this.nome;
    }
}
class Cachorro extends Animal {
    constructor(nome, idade) {
        super(nome, idade);
    }
    bark() {
        console.log(this.idade);
        return `Idade: ${this.idade}`;
    }
}
function askQuestions() {
    rl.question("Nome do cachorro: ", (nome) => {
        rl.question("Idade do cachorro: ", (idade) => {
            const cachorro = new Cachorro(nome, parseInt(idade));
            console.log("O nome é: ", cachorro.getName());
            console.log(cachorro.bark());
            rl.close();
        });
    });
}
askQuestions();
