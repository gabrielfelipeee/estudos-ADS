// Classe
class Carro {
    constructor(marca, modelo, ano) { // marca, modelo, ano => propriedades
        this.marca = marca,
        this.modelo = modelo, 
        this.ano = ano,
        this.velocidade = 0
    }

    acelerar(aceleracao) { // Método acelerar
        this.velocidade += aceleracao;
        return aceleracao;
    }

    buzinar() { // Método Buzinar
        console.log("Beeeep!")
    }
};


 // Objetos
const fusca = new Carro("Volkswagen", "Fusca", 1970);
fusca.buzinar(); // chamando o método

const civic = new Carro("Honda", "Civic", 2022);
civic.acelerar(100);