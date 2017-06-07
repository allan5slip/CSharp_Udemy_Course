// var getIdade = function(extra)
//     {
//         console.log(arguments)
//         return this.idade + extra;
//     }

// var pessoa = 
// {
//     nome: "Joao" ,
//     idade: 20,
//     getIdade: getIdade
// };

// console.log(pessoa.getIdade(2));
// console.log(getIdade.apply(pessoa, [2,1,3]));
// console.log(getIdade.call(pessoa, 2, 1, 3));





//função fabrica 
var criarPessoa = function(nome, idade)
{
    return {
        nome: nome,
        idade: idade
    };
}

console.log(criarPessoa("Pedro", 20));
console.log(criarPessoa("Maria", 30));

//função Construtora

var Pessoa = function(nome, idade)
{
    this.nome = nome;
    this.idade = idade;
};


console.log(new Pessoa("Pedro",20));
console.log(new Pessoa("Maria",30));

var pedro = {};
Pessoa.call(pedro, "Pedro", 20);
console.log(pedro);

var maria = {};

Pessoa.call(maria, "Maria", 30);
console.log(maria);