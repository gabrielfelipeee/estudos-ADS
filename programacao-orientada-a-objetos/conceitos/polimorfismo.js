// Polimorfismo => é o mecanismo pelo qual uma subclasse (classe que herdou) sobrescreve uma função/método da classe pai para se adequar às necessidades da classe.


class Animal {
    constructor(nome) {
      this.nome = nome;
    }
  
    fazerSom() {
      console.log(`${this.nome} faz um som.`);
    }
}
  

class Cachorro extends Animal {
    fazerSom() { // Método alterado
        console.log(`${this.nome} late.`);
    }
}
  

class Gato extends Animal {
    fazerSom() { // Método alterado
        console.log(`${this.nome} mia.`);
    }
}
  
// Criando instâncias de diferentes animais
const meuCachorro = new Cachorro("Rex");
const meuGato = new Gato("Whiskers");


// Chamando o método fazerSom() de maneira polimórfica
meuCachorro.fazerSom(); // O cachorro late
meuGato.fazerSom();    // O gato mia
  