// Herança =>  permite que as subclasses herdem atributos e métodos da classe pai e, ao mesmo tempo, adicionem novos atributos e métodos ou modifiquem os já existentes.


// Classe pai
class Animal {
    constructor(nome) {
    this.nome = nome;
};

fazerSom() { // Método
    console.log(`${this.nome} faz um som.`);
    }
};


// Classe Filha (Subclasse)
class Cachorro extends Animal {
    latir() { // Método
        console.log(`${this.nome} late.`);
    }
};

// Exemplo de uso
const meuCachorro = new Cachorro("Rex");
meuCachorro.fazerSom(); // Chama o método da classe pai
meuCachorro.latir(); // Chama um método da classe filha
