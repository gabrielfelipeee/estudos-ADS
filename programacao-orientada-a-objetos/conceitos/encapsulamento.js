// Encapsulamento => Encapsulamento é o mecanismo pelo qual protegemos variáveis e métodos de uma classe. Existem classes que não devem permitir que certas variáveis sejam públicas, isto é, que possam ser manipulados por outras classes e objetos externos. Então nós as encapsulamos, tornando-as privadas.

class Pessoa {
    constructor() {

        // Atributo privado/Encapsulamento
        let nome = "";

        // Método público para definir o nome
        this.setNome = (novoNome) => {
            nome = novoNome;
        };

        // Método público para obter o nome
        this.getNome = () => {
            return nome;
        };
    };
};
const pessoa = new Pessoa();
pessoa.setNome("João");
console.log(`Nome: ${pessoa.getNome()}`);
